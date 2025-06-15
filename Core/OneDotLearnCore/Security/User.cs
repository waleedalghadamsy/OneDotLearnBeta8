using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneDotLearnCore.Essential;

namespace OneDotLearnCore.Security
{
    [Table("Users", Schema = "Security")]
    public class User : BaseEntity
    {

        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required, StringLength(30)]
        public string? LoginName { get; set; }
        [StringLength(100)]
        public string? FullName { get; set; }
        [NotMapped]
        public string? OriginalPassword { get; set; }
        [Required]
        public string? HashedPassword { get; set; }
        [Required]
        public UserRole Role { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset? LastSignedInAt { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
