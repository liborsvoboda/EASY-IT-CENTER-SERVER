using System.Linq;
using System.Threading;

namespace EasyITCenter.Services {

    public class StripeSettings {
        public string SecretKey { get; set; }
        public string PublicKey { get; set; }
    }

    public static class StripeRedirection {
        public static string Currency = "EGP";
        public static string SuccessUrl = "https://localhost:44325/Home/Done";
        public static string CancelUrl = "https://localhost:44325/Home/Index";
    }

    public interface IStripeGateWay { Task<string> OnlinePaymentStripe(Amount amount); }


}