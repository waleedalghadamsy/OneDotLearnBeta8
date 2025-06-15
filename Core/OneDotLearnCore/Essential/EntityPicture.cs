using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    [Table("Pictures", Schema = "General")]
    public class EntityPicture : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int EntityId { get; set; }
        [Required]
        public EntityType EntityType { get; set; }
        [Required]
        public byte[]? Picture { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
