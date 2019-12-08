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
        /// Warning items
        /// </summary>
        public JMResultItem[] Warnings
        {
            get; set;
        }

        /// <summary>
        /// Information items
        /// </summary>
        public JMResultItem[] Informations
        {
            get; set;
        }

        /// <summary>
        /// Redirection info to handle this Result
        /// </summary>
        public JMRedirectionInfo RedirectionInfo
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

        /// <summary>
        /// Flag that reflects if the current result has any warning items
        /// </summary>
        public bool HasWarning
        {
            get
            {
                return Warnings != null && Warnings.Length != 0;
            }
        }

        /// <summary>
        /// Flag that reflects if the current result has any information items
        /// </summary>
        public bool HasInformation
        {
            get
            {
                return Informations != null && Informations.Length != 0;
            }
        }
    }
}
