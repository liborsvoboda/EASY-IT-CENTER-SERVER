using ServiceStack;
using ServiceStack.Script;
using RouteAttribute = ServiceStack.RouteAttribute;

namespace EasyITCenter.SharpScript
{


    [Route("/products/view")]
    public class ViewProducts {
        public string Id { get; set; }
    }


    [Route("/customers/{Id}")]
    public class ViewCustomer
    {
        public string Id { get; set; }
    }


    [Route("/pages/eval")]
    public class EvaluateScripts : IReturn<string> {
        public Dictionary<string, string> Files { get; set; }
        public Dictionary<string, string> Args { get; set; }

        public string Page { get; set; }
    }


    [Route("/linq/eval")]
    public class EvaluateLinq : IReturn<string> {
        public string Code { get; set; }
        public string Lang { get; set; }
        public Dictionary<string, string> Files { get; set; }
    }


    [Route("/template/eval")]
    public class EvaluateScript {
        public string Template { get; set; }
    }

    [Route("/expression/eval")]
    public class EvalExpression : IReturn<EvalExpressionResponse> {
        public string Expression { get; set; }
    }


    [Route("/github/{UserName}")]
    public class GetGithubRepos : IReturn<List<GithubRepo>> {
        public string UserName { get; set; }
    }

    [Route("/introspect/state")]
    public class IntrospectState {
        public string Page { get; set; }
        public string ProcessInfo { get; set; }
        public string DriveInfo { get; set; }
    }


    [Route("/emails/order-confirmation/preview")]
    public class PreviewHtmlEmail : IReturn<PreviewHtmlEmailResponse> {
        public string EmailTemplate { get; set; }
        public string HtmlTemplate { get; set; }
        public string PreviewCustomerId { get; set; }
    }



}