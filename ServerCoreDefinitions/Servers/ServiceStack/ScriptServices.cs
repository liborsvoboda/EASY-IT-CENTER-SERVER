using System.Collections.Generic;
using ServiceStack;
using ServiceStack.Script;
using ServiceStack.IO;
using System.Threading.Tasks;
using System;
using ServiceStack.OrmLite;
using ServiceStack.Data;
using RouteAttribute = ServiceStack.RouteAttribute;

namespace EasyITCenter.SharpScript
{


    public class EvalExpressionResponse
    {
        public object Result { get; set; }
        public string Tree { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }

    
    
}