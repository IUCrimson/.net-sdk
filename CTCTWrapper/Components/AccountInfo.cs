using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using CTCT.Components.Contacts;

namespace CTCT.Components
{    
	/// <summary>
	/// Represents Account summary information in Constant Contact.
	/// </summary>
	[DataContract]
	[Serializable]
	public class AccountInfo : Component
	{
		/// <summary>
		/// Gets or sets the website.
		/// </summary>
		[DataMember(Name = "website", EmitDefaultValue = false)]
		public string Website { get; set; }
		/// <summary>
		/// Gets or sets the organization name.
		/// </summary>
		[DataMember(Name = "organization_name", EmitDefaultValue = false)]
		public string OrganizationName { get; set; }
		/// <summary>
		/// Gets or sets the time zone.
		/// </summary>
		[DataMember(Name = "time_zone", EmitDefaultValue = false)]
		public string TimeZone { get; set; }
		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		[DataMember(Name = "first_name", EmitDefaultValue = false)]
		public string FirstName { get; set; }
		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		[DataMember(Name = "last_name", EmitDefaultValue = false)]
		public string LastName { get; set; }        
		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		[DataMember(Name = "email")]
		public string EmailAddr { get; set; }
		/// <summary>
		/// Gets or sets the phone number.
		/// </summary>
		[DataMember(Name = "phone")]
		public string Phone { get; set; }
		/// <summary>
		/// Gets or sets the state code.
		/// </summary>
		[DataMember(Name = "state_code", EmitDefaultValue = false)]
		public string StateCode { get; set; }
		/// <summary>
		/// Gets or sets the country code.
		/// </summary>
		[DataMember(Name = "country_code", EmitDefaultValue = false)]
		public string CountryCode { get; set; }
		/// <summary>
		/// Gets or sets the addresses.
		/// </summary>
		[DataMember(Name = "organization_addresses")]
		public IList<Address> Addresses { get; private set; }
	}
}
