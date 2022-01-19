using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi
{
    /// <summary>
    /// Classes used for passing query parameters into API services
    /// </summary>
    public class QueryOptions
    {
        public QueryOptions()
        {
            Options = new List<QueryOption>();
        }
        public List<QueryOption> Options { get; set; }
    }

    public class QueryOption
    {
        public QueryOption(string Parameter, string Value)
        {
            this.Parameter = Parameter;
            this.Value = Value;
        }

        public string Parameter { get; }
        public string Value { get; }
    }
}
