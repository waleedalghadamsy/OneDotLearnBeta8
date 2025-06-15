using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    /// <summary>
    /// Summary description for Communication.
    /// </summary>
    [Table("ContactDetails", Schema = "General")]
    public class Communication : BaseEntity
	{
		#region Data Members
		#endregion

		#region Constructors

		//public Communication()
		//{
		//}

		#endregion

		#region Properties
        [NotMapped]
        public List<TelephoneNumber>? HomePhones { get; set; }
        [NotMapped]
        public List<TelephoneNumber>? BusinessPhones { get; set; }
        [NotMapped]
        public List<TelephoneNumber>? Mobiles { get; set; }
        [NotMapped]
        public List<EmailAddress>? Emails { get; set; }
        [NotMapped]
        public List<string>? Faxes { get; set; }
        [StringLength(250)]
        public string? Website { get; set; }
        [StringLength(250)]
        public string? Facebook { get; set; }
        [StringLength(250)]
        public string? Twitter { get; set; }
        [StringLength(250)]
        public string? Instagram { get; set; }
        [StringLength(250)]
        public string? YouTube { get; set; }
        #endregion

        #region Methods


        #endregion
    }
}
