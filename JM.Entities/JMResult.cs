using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Entities
{
    /// <summary>
    /// Custom result type that is used to hold result items after an action is performed such as a HTTP call
    /// </summary>
    public class JMResult
    {
        /// <summary>
        /// Error items
        /// </summary>
        public JMResultItem[] Errors
        {
            get; set;
        }

        /// <summary>
        /// Flag that reflects if the current result indicates a sucessful result
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                return Errors == null || Errors.Length == 0;
            }
        }
    }
}
