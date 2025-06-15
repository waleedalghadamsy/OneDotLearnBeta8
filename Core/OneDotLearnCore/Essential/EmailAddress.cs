using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    [Table("EmailAddresses", Schema = "General")]
    public class EmailAddress : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int ContactDetailId { get; set; }
        [Required, StringLength(25)]
        public string? Address { get; set; }
        public bool? IsBusiness { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
