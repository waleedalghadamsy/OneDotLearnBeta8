using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    [Table("TelephoneNumbers", Schema = "General")]
    public class TelephoneNumber : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int ContactDetailId { get; set; }
        [Required, StringLength(25)]
        public string? Number { get; set; }
        public bool? IsBusiness { get; set; }
        public bool? IsMobile { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
