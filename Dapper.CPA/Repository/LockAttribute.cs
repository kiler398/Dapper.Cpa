using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Cpa.Repository
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class LockAttribute : Attribute
    {

    }
}
