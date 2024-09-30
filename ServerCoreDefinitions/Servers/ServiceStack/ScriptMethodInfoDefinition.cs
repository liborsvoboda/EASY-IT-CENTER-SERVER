using System.Linq;
using ServiceStack;
using ServiceStack.Script;
using ServiceStack.IO;
using RouteAttribute = ServiceStack.RouteAttribute;

namespace EasyITCenter.SharpScript
{
   
    /// <summary>
    /// ScriptMethodInfo Definition
    /// </summary>
    public class ScriptMethodInfo {
        public string Name { get; set; }
        public string FirstParam { get; set; }
        public string ReturnType { get; set; }
        public int ParamCount { get; set; }
        public string[] RemainingParams { get; set; }

        public static ScriptMethodInfo[] GetMethodsAvailable(Type filterType) {
            var filters = filterType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            var to = filters
                .OrderBy(x => x.Name)
                .ThenBy(x => x.GetParameters().Count())
                .Where(x => x.DeclaringType != typeof(ScriptMethods) && x.DeclaringType != typeof(object))
                .Where(m => !m.IsSpecialName)
                .Select(ScriptMethodInfo.Create);

            return to.ToArray();
        }

        public static ScriptMethodInfo Create(MethodInfo mi) {
            var paramNames = mi.GetParameters()
                .Where(x => x.ParameterType != typeof(ScriptScopeContext))
                .Select(x => x.Name)
                .ToArray();

            var to = new ScriptMethodInfo {
                Name = mi.Name,
                FirstParam = paramNames.FirstOrDefault(),
                ParamCount = paramNames.Length,
                RemainingParams = paramNames.Length > 1 ? paramNames.Skip(1).ToArray() : new string[] { },
                ReturnType = mi.ReturnType?.Name,
            };

            return to;
        }

        public string Return => ReturnType != null && ReturnType != nameof(StopExecution) ? " -> " + ReturnType : "";

        public string Body => ParamCount == 0
            ? $"{Name}"
            : ParamCount == 1
                ? $"|> {Name}"
                : $"|> {Name}(" + string.Join(", ", RemainingParams) + $")";

        public string Display => ParamCount == 0
            ? $"{Name}{Return}"
            : ParamCount == 1
                ? $"{FirstParam} |> {Name}{Return}"
                : $"{FirstParam} |> {Name}(" + string.Join(", ", RemainingParams) + $"){Return}";
    }


}