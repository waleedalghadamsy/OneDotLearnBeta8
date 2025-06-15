using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using OneDotLearnCore.Essential;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OneDotLearnCore.Financials;

namespace OneDotLearnCore.Training
{
    [Table("Enrolments", Schema = "Training")]
    public class Enrolment : BaseEntity
    {
        #region Constructors
        //public CycleEnrollment()
        //{
        //}
        #endregion

        #region Properties
        [Required]
        public int CourseId { get; set; }
        [NotMapped]
        public Cycle? Cycle { get; set; }
        [Required]
        public int CycleId { get; set; }
        [NotMapped]
        public Trainee? Trainee { get; set; }
        [Required]
        public int TraineeId { get; set; }
        [NotMapped]
        public Country? Country { get; set; }
        [Required]
        public int CountryId { get; set; }
        [NotMapped]
        public Currency? Currency { get; set; }
        [Required]
        public int CurrencyId { get; set; }
        [Required]
        public float Fees { get; set; }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
        public byte[]? CashPaymentQrCode { get; set; }
        public bool? IsCancelled { get; set; }
        public string? CancellationReason { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset? CancelledOn { get; set; }
        #endregion

        #region Methods
        //public void Method()
        //{
        //}
        #endregion
    }
}
