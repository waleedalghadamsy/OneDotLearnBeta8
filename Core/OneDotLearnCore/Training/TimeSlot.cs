using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using OneDotLearnCore.Essential;

namespace OneDotLearnCore.Training
{
    public class TimeSlot
    {
        #region Constructors
        //public TimeSlot(DayOfWeek day, DateTime startTime, DateTime endTime)
        //{
        //    try
        //    {
        //        TimePeriod = new TimePeriod(startTime, endTime);
        //        Day = day;
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion

        #region Properties
        public DayOfWeek Day { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset From { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset To { get; set; }
        #endregion
    }
}
