using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Schema;

namespace OneDotLearnCore.Essential
{
    public class BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int CreatedById { get; set; }
        [Required, StringLength(25)] //dd-mm-yyyy hh:mm:ss.ffff
        public string? CreatedOn { get; set; }
        [Required]
        public EntityStatus EntityStatus { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}

/*
#region Data Memebers
#endregion

#region Constructors
#endregion

#region Properties
#endregion

#region Methods
#endregion
 */
