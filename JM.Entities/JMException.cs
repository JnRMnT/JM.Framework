using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Entities.Framework
{
    /// <summary>
    /// Custom exception class definition to be able to distinguish functional errors and exception handling
    /// </summary>
    public class JMException : Exception
    {
        /// <summary>
        /// Custom code of the exception
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Code only exception constructor
        /// </summary>
        /// <param name="code">Functional Error Code</param>
        public JMException(string code): this(code, code)
        {

        }

        /// <summary>
        /// Code and Message based exception constructor.
        /// </summary>
        /// <param name="code">Functional Error Code</param>
        /// <param name="message">Exception Message (Passed to base Exception)</param>
        public JMException(string code, string message) : base(message)
        {
            this.Code = code;
        }
    }
}
