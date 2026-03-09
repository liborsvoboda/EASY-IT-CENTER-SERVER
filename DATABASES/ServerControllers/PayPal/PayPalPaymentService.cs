using PayPal.Api;
using System;
using System.Collections.Generic;
using Transaction = PayPal.Api.Transaction;

namespace Paypal_Integration.Services
{
    public static class PayPalPaymentService
    {
        public static Payment CreatePayment(string baseUrl, string intent)
        {
            var apiContext = PayPalConfiguration.GetAPIContext();

            var payment = new Payment()
            {
                intent = intent,    // `sale` or `authorize`
                payer = new Payer() { payment_method = "paypal" },
                transactions = GetPaymentList(),
                redirect_urls = GetReturnUrls(baseUrl, intent)
            };

            var createdPayment = payment.Create(apiContext);
            return createdPayment;
        }

        private static List<Transaction> GetPaymentList()
        {
 
            var transactionList = new List<Transaction>();
            transactionList.Add(new Transaction()
            {
                description = "Payment description.",
                invoice_number = "",
                amount = new Amount()
                {
                    currency = "CZK",
                    total = "100.00",       // Total must be equal to sum of shipping, tax and subtotal.
                    details = new Details() // Details: Let's you specify details of a payment amount.
                    {
                        tax = "15",
                        shipping = "10",
                        subtotal = "75"
                    }
                },
                item_list = new ItemList()
                {
                    items = new List<Item>()
                    {
                        new Item()
                        {
                            name = "Item Name",
                            currency = "CZK",
                            price = "15",
                            quantity = "5",
                            sku = "sku"
                        }
                    }
                }
            });
            return transactionList;
        }

        private static RedirectUrls GetReturnUrls(string baseUrl, string intent)
        {
            var returnUrl = intent == "sale" ? "/Home/PaymentSuccessful" : "/Home/AuthorizeSuccessful";
            return new RedirectUrls()
            {
                cancel_url = baseUrl + "/Home/PaymentCancelled",
                return_url = baseUrl + returnUrl
            };
        }

        public static Payment ExecutePayment(string paymentId, string payerId)
        {
            var apiContext = PayPalConfiguration.GetAPIContext();
            
            var paymentExecution = new PaymentExecution() { payer_id = payerId };
            var payment = new Payment() { id = paymentId };
            var executedPayment = payment.Execute(apiContext, paymentExecution);

            return executedPayment;
        }

        
    }
}
