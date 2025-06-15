using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Logging
{
    public class DebugEvent : LogEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        [Required]
        public LogLevel Level { get; set; }
        [Required, StringLength(300)]
        public string? SourceClass { get; set; }
        [Required, StringLength(300)]
        public string? SourceMethod { get; set; }
        [Required]
        public string? Message { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
