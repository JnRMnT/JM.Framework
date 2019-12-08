using System;
using System.Collections.Generic;
using System.Text;

namespace JM.Entities
{
    /// <summary>
    /// Class that holds all the relevant information about a redirection
    /// </summary>
    public class JMRedirectionInfo
    {
        /// <summary>
        /// Redirection Type to be performed
        /// </summary>
        public RedirectionTypeEnum RedirectionType { get; set; }

        /// <summary>
        /// Depending on the redirection type, it represents where to redirect
        /// </summary>
        public string RedirectionParameter { get; set; }
    }
}
