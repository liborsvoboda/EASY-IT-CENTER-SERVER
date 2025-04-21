
namespace EasyITCenter.ServerCoreStructure {

    public record AddStripeCard
        (
            string Name,
            string CardNumber,
            string ExpirationYear,
            string ExpirationMonth,
            string Cvc
        );

    public record AddStripeCustomer
    (
        string Email,
        string Name,
        AddStripeCard CreditCard
    );

    public record AddStripePayment
    (
        string CustomerId,
        string ReceiptEmail,
        string Description,
        string Currency,
        long Amount
    );

    public record StripeCustomer
    (
        string Name,
        string Email,
        string CustomerId
    );

    public record StripePayment
    (
        string CustomerId,
        string ReceiptEmail,
        string Description,
        string Currency,
        long Amount,
        string PaymentId
    );

}