using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Logging
{
    public class ErrorEvent : LogEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //[Required]
        public ErrorLevel Level { get; set; }
        //[Required, StringLength(10)]
        //public string Date { get; set; }
        //[Required, StringLength(14)]
        //public string Time { get; set; }
        [Required, StringLength(300)]
        public string? SourceClass { get; set; }
        [Required, StringLength(300)]
        public string? SourceMethod { get; set; }
        [Required, StringLength(100)]
        public string? ExceptionClass { get; set; }
        [Required]
        public string? Message { get; set; }
        [Required]
        public string? StackTrace { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
