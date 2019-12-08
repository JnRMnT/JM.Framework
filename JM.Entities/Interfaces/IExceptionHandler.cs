using System;
using System.Collections.Generic;
using System.Text;

namespace JM.Entities.Interfaces
{
    /// <summary>
    /// Interface providing a method to handle any type of exception and return a handled custom result instance
    /// </summary>
    public interface IExceptionHandler
    {
        /// <summary>
        /// Method to handle any type of exception and return a custom result
        /// </summary>
        /// <param name="exception">Exception to be handled</param>
        /// <returns>Handled result that can be directly used on the UI</returns>
        JMResult HandleException(Exception exception);
    }
}
