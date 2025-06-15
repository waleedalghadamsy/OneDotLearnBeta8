using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace OneDotLearnCore.Training
{
    [Table("Packages", Schema = "Training")]
    public class Package : BaseEntity
    {
        #region Data Members
        #endregion
        
        #region Constructors
        public Package()
        {
            Code = ""; Prerequisites = null;
            Courses = new List<Course>();
        }
        #endregion

        #region Properties
        [NotMapped]
        public ProductCategory Category { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required, StringLength(250)]
        public string? Title { get; set; }
        [Required, StringLength(10)]
        public string Code { get; set; }
        [NotMapped]
        public List<string>? Prerequisites { get; set; }
        public string? Description { get; set; }
        [NotMapped]
        public List<Course>? Courses { get; set; }
        public short? Duration { get; set; }
        [Required]
        public ProductLevel Level { get; set; }
        [NotMapped]
        public List<ProductFees>? Fees { get; set; }
        [Required]
        public ProductStatus Status { get; set; }
        #endregion

        #region Methods
        //public void Method()
        //{
        //}
        #endregion
    }
}
