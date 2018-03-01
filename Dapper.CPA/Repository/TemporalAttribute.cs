using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Cpa.Repository
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class TemporalAttribute : Attribute
    {
        public TemporalType Value { get; set; } = TemporalType.DATE;
    }
}
