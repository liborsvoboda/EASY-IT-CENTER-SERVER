using System;
using Paypal_Integration.Services;
using PayPal.Api;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;


namespace Paypal_Integration.Controllers
{
    public class HomeController : Controller
    {

        #region Single PayPal Payment
        public IActionResult CreatePayment()
        {
            var payment = PayPalPaymentService.CreatePayment(DbOperations.GetServerParameterLists("ServerPublicUrl").Value, "sale");
            
            return Redirect(payment.GetApprovalUrl());
        }


        public IActionResult PaymentSuccessful(string paymentId, string token, string PayerID)
        {
            // Execute Payment
            var payment = PayPalPaymentService.ExecutePayment(paymentId, PayerID);

            return View();
        }
        #endregion

        #region Authorize PayPal Payment
        public IActionResult AuthorizePayment()
        {
            var payment = PayPalPaymentService.CreatePayment(DbOperations.GetServerParameterLists("ServerPublicUrl").Value, "authorize");
            
            return Redirect(payment.GetApprovalUrl());
        }
        #endregion

    }
}
