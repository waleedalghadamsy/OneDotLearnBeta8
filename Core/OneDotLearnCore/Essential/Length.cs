using System;
using System.Collections.Generic;
using System.Text;

namespace OneDotLearnCore.Essential
{
    public class Length : MeasurementUnit
    {
        #region Data Members
        #endregion

        #region Constructors
        public Length()
        {
            Dimension = MeasurementDimension.Length;
            Unit = LengthUnit.Centimeter;
        }
        #endregion

        #region Properties
        public LengthUnit Unit { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Converts the first unit to the second unit
        /// </summary>
        /// <param name="unit1"></param>
        /// <param name="unit2"></param>
        /// <returns></returns>
        public static float ConversionFactor(Length unit1, Length unit2)
        {
            return (float)unit1.Unit / (float)unit2.Unit;
        }

        /// <summary>
        /// Converts "this" unit to the given unit
        /// </summary>
        /// <param name="anotherUnit"></param>
        /// <returns></returns>
        public float ConversionFactor(Length anotherUnit)
        {
            return (float)Unit / (float)anotherUnit.Unit;
        }
        #endregion
    }
}
