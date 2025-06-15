using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using OneDotLearnCore.Essential;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OneDotLearnCore.People;

namespace OneDotLearnCore.Training
{
    [Table("ProductsCycles", Schema = "Training")]
    public class Cycle : BaseEntity
    {
        #region Constructors
        //public Cycle(string name, string code, ITrainingProduct product, TimeSpan sessionDuration)
        //{
        //    Name = name; Code = code; TrainingProduct = product; SessionDuration = sessionDuration;
        //    Schedule = new List<TimeSlot>(); Sessions = new List<TrainingSession>();
        //}
        #endregion

        #region Properties
        [NotMapped]
        public string? ProductTitle { get; set; }
        [Required, StringLength(15)]
        public string? Code { get; set; }
        [NotMapped]
        public object? TrainingProduct { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public ProductType ProductType { get; set; }
        //[NotMapped]
        //public ProductLevel Level { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTimeOffset PlannedStartDate { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTimeOffset PlannedEndDate { get; set; }
        [Required]
        public CycleStartTime SessionStartTime { get; set; }
        [Required]
        public byte SessionEndTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset? ActualStartDateTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset? ActualEndDateTime { get; set; }
        [Required]
        public WeekDays WeekDays { get; set; }
        [Required]
        public byte NoOfDaysPerWeek { get; set; }
        [Required]
        public byte TotalNoOfDays { get; set; }
        [Required]
        public byte MaxNoOfTrainees { get; set; }
        //[NotMapped]
        //public List<CourseFees> CourseFees { get; set; }
        //[NotMapped]
        //public Classroom Classroom { get; set; }
        //public int? ClassroomId { get; set; }
        [NotMapped]
        public Instructor? Instructor { get; set; }
        [Required]
        public int InstructorId { get; set; }
        [Required]
        public CycleStatus Status { get; set; }
        //[NotMapped]
        //public List<TimeSlot> Schedule { get; set; }
        [NotMapped]
        public List<TimeSlot>? Sessions { get; set; }
        #endregion

        #region Methods
        //public void Start()
        //{
        //    ActualStartDateTime = DateTime.Now;
        //}

        //public void End()
        //{
        //    ActualEndDateTime = DateTime.Now;
        //}

        //public void StartSession()
        //{
        //}

        //public void EndSession()
        //{
        //}
        #endregion
    }
}
