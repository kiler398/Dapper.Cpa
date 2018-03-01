using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Cpa.Repository
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class QueryAttribute : Attribute
    {
        /// <summary>
        /// Defines the CPA query to be executed when the annotated method is called.
        /// </summary>
        public string Value { get; set; } = "";

        /// <summary>
        /// Defines a special count query that shall be used for pagination queries to lookup the total number of elements for
        ///a page.If non is configured we will derive the count query from the method name.
        /// </summary>
        public string CountQuery { get; set; } = "";


        /// <summary>
        /// Configures whether the given query is a native one. Defaults to {@literal false}.
        /// </summary>
        public string NativeQuery { get; set; } = "";


        /// <summary>
        /// The named query to be used. If not defined, a {@link javax.persistence.NamedQuery} with name of
        /// {@code $ domainClass }.${queryMethodName
        /// will be used.
        /// </summary>
        public string Name { get; set; } = "";


        /// <summary>
        /// Returns the name of the {@link javax.persistence.NamedQuery} to be used to execute count queries when pagination is
        /// used.Will default to the named query name configured suffixed by { @code.count}.
        /// @see #name()
        ///    * @return
        /// </summary>
        public string CountName { get; set; } = "";


 
    }
}
