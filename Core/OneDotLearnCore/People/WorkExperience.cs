using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace OneDotLearnCore.People
{
    [Table("Experiences", Schema = "People")]
    public class WorkExperience : BaseEntity
    {
        #region Properties
        [NotMapped]
        public WorkPlace? WorkPlace { get; set; }
        [NotMapped]
        public Job? Job { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        public int? JobId { get; set; }
        public int? WorkPlaceId { get; set; }
        public int? CategoryId { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTimeOffset FromDate { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTimeOffset ToDate { get; set; }
        [StringLength(150)]
        public string? Achievement { get; set; }
        public string? Notes { get; set; }
        #endregion
    }
}
