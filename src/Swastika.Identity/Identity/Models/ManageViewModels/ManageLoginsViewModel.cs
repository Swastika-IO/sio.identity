using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;

namespace Swastika.Identity.Models.ManageViewModels
{
    public class ManageLoginsViewModel
    {
        /// <summary>
        /// Gets or sets the current logins.
        /// </summary>
        /// <value>
        /// The current logins.
        /// </value>
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        /// <summary>
        /// Gets or sets the other logins.
        /// </summary>
        /// <value>
        /// The other logins.
        /// </value>
        public IList<AuthenticationScheme> OtherLogins { get; set; }
    }
}
