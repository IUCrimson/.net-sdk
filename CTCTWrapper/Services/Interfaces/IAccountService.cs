using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTCT.Components;
using CTCT.Components.Contacts;

namespace CTCT.Services
{
    /// <summary>
    /// Interface for account service
    /// </summary>
    public interface  IAccountService
    {
        /// <summary>
        /// Retrieve a list of all the account owner's email addresses
        /// </summary>
        /// <param name="accessToken">Constant Contact OAuth2 access token.</param>
        /// <param name="apiKey">The API key for the application</param>
        /// <returns>list of all verified account owner's email addresses</returns>
        IList<VerifiedEmailAddress> GetVerifiedEmailAddress(string accessToken, string apiKey);

	    /// <summary>
	    /// Retrieve account summary information
	    /// </summary>
	    /// <param name="accessToken">Constant Contact OAuth2 access token.</param>
	    /// <param name="apiKey">The API key for the application</param>
	    /// <returns>Account summary information</returns>
	    AccountInfo GetAccountInfo(string accessToken, string apiKey);
    }
}
