using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Logging
{
    public class LogEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required, StringLength(10)]
        public string? Date { get; set; }
        [Required, StringLength(14)]
        public string? Time { get; set; }
        [Required]
        public LogType LogType { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
