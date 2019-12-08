using System;
using System.Collections.Generic;
using System.Text;

namespace JM.Entities
{
    /// <summary>
    /// Enumeration type providing generic types to represent a redirection
    /// </summary>
    public enum RedirectionTypeEnum
    {
        /// <summary>
        /// Indicates not to redirect
        /// </summary>
        NoRedirection,
        /// <summary>
        /// Indicates a redirection to a specific route for SPAs
        /// </summary>
        RedirectToRoute,
        /// <summary>
        /// Indicates a static redirection to a URL
        /// </summary>
        RedirectToURL,
        /// <summary>
        /// Indicates a redirection to application error page
        /// </summary>
        RedirectToErrorPage,
        /// <summary>
        /// Indicates a redirection to the logout page
        /// </summary>
        RedirectToLogout
    }
}
