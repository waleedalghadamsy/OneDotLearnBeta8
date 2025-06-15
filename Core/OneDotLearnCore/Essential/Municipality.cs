using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    public class Municipality : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [StringLength(30)]
        public string? ArabicName { get; set; }
        [Required, StringLength(30)]
        public string? LatinName { get; set; }
        [NotMapped]
        public List<City>? Cities { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
