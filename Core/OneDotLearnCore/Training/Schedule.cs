using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace OneDotLearnCore.Training
{
    public class Schedule
    {
        //TODO: Should specify training sessions over the day. This depends on:
        //- Day training start
        //- Day training end
        //- Session duration
        //A schedule in fact is a sequence of training sessions, intermittent with breaks.
        #region Constructors
        //public Schedule(DateTime day)
        //{
        //    ScheduleDay = day; ScheduledCycles = new List<Cycle>();
        //}
        #endregion

        #region Properties
        [DataType(DataType.Date)]
        public DateOnly ScheduleDay { get; set; }
        public List<Cycle>? ScheduledCycles { get; set; }
        #endregion

        #region Methods
        //public void Method()
        //{
        //}
        #endregion
    }
}
