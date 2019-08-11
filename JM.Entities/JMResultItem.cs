using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Entities
{
    /// <summary>
    /// Basic Result item class
    /// </summary>
    public class JMResultItem
    {
        /// <summary>
        /// Identifier of the result item
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Message related to the result
        /// </summary>
        public string Message { get; set; }
    }
}
