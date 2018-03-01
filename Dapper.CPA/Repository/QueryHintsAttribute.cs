using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Cpa.Repository
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class QueryHintsAttribute : Attribute
    {
        /// <summary>
        /// The {@link QueryHint}s to apply when the query will be executed.
        /// 
        /// @return
        /// </summary>
        public string QueryHint { get; set; } = "";

        /// <summary>
        /// Defines whether the configured {@link QueryHint}s shall be applied for count queries during pagination as well.
        /// Defaults to {@literal true}.
        /// 
        /// @return
        /// </summary>
        public string ForCounting { get; set; } = "";
    }
}
