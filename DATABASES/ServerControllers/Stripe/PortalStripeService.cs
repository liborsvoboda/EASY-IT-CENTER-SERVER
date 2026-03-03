using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;


namespace server.Controllers {


    public class CreateCheckoutSessionRequest {
        public string ProductName { get; set; }
        public long Price { get; set; }
    }


    public class CreateCustomerRequest {
        public string Name { get; set; }
        public string Email { get; set; }
    }


    public class PaymentIntentRequest {
        public long Price { get; set; }
    }

    /// <summary>
    /// https://docs.stripe.com/get-started
    /// </summary>
    [AllowAnonymous]
    [Route("StripeService")]
    [ApiController]
    public class PaymentsController : Controller {


        [HttpPost("/StripeService/PaymentIntentService")]
        public ActionResult PaymentIntentService([FromBody] PaymentIntentRequest paymentIntentRequest) {
            var options = new PaymentIntentCreateOptions {
                Amount = paymentIntentRequest.Price,
                Currency = "czk",
                PaymentMethod = "pm_card_visa",
                PaymentMethodTypes = new List<string> { "card" },
            };
            var service = new PaymentIntentService();
            PaymentIntent paymentIntent = service.Create(options);

            return Json(new { paymentIntent = paymentIntent });
        }


        [HttpPost("/StripeService/CreateCheckoutSession")]
        public ActionResult CreateCheckoutSession([FromBody] CreateCheckoutSessionRequest createCheckoutSessionRequest) {
            SessionCreateOptions? options = new SessionCreateOptions {
                LineItems = new List<SessionLineItemOptions> {
                    new SessionLineItemOptions {
                        PriceData = new SessionLineItemPriceDataOptions {
                            //2000  = 20.00 CZK
                            UnitAmount = createCheckoutSessionRequest.Price * 100,
                            Currency = "czk",
                            ProductData = new SessionLineItemPriceDataProductDataOptions {
                                Name = createCheckoutSessionRequest.ProductName,
                            },
                        },
                    Quantity = 1,
                    },
                },
                Mode = "payment",
                UiMode = "embedded",
                ReturnUrl = $"{DbOperations.GetServerParameterLists("ServerPublicUrl").Value}/server-portal/addons/stripe/index.html?session_id={HttpContext.Session.Id}",
            };

            SessionService? service = new SessionService();
            Session session = service.Create(options);

            return Json(new { clientSecret = session.ClientSecret });
        }


        [HttpPost("/StripeService/CreateProduct")]
        public ActionResult CreateProduct([FromBody] CreateCheckoutSessionRequest createCheckoutSessionRequest) {
            var options = new ProductCreateOptions { Name = createCheckoutSessionRequest.ProductName };
            var service = new ProductService();
            Product product = service.Create(options);

            return Json(new { product = product });
        }


        [Route("/StripeService/SessionStatus")]
        [ApiController]
        public class SessionStatusController : Controller {
            [HttpGet]
            public ActionResult SessionStatus([FromQuery] string session_id) {
                var sessionService = new SessionService();
                Session session = sessionService.Get(session_id);

                return Json(new { status = session.Status, customer_email = session.CustomerDetails.Email });
            }
        }


        [HttpPost("/StripeService/CreateCustomer")]
        public ActionResult CreateCustomer([FromBody] CreateCustomerRequest createCustomerRequest) {
            var options = new CustomerCreateOptions {
                Name = createCustomerRequest.Name,
                Email = createCustomerRequest.Email,
            };
            var service = new CustomerService();
            Customer customer = service.Create(options);

            return Json(new { customer = customer });
        }


        [HttpPost("/StripeService/CreatePrice")]
        public ActionResult CreatePrice([FromBody] CreateCustomerRequest createCustomerRequest) {
            PriceCreateOptions? options = new PriceCreateOptions {
                Currency = "usd",
                UnitAmount = 1000,
                Recurring = new PriceRecurringOptions { Interval = "month" },
                ProductData = new PriceProductDataOptions { Name = "Gold Plan" },
            };
            PriceService? service = new PriceService();
            Price price = service.Create(options);

            return Json(new { price = price });
        }
    }
}



