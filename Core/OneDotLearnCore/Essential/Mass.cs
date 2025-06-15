using System;
using System.Collections.Generic;
using System.Text;

namespace OneDotLearnCore.Essential
{
    public class Mass : MeasurementUnit
    {
        #region Data Members
        #endregion

        #region Constructors
        /// <summary>
        /// Default unit is kilogram
        /// </summary>
        /// <remarks>In order to specify other units, use the other constructor</remarks>
        public Mass() : this(MassUnit.Kilogram)
        {
        }
        public Mass(MassUnit theUnit)
        {
            Dimension = MeasurementDimension.Mass;
            Unit = theUnit;
        }
        #endregion

        #region Properties
        public MassUnit Unit { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Converts the first unit to the second unit
        /// </summary>
        /// <param name="unit1"></param>
        /// <param name="unit2"></param>
        /// <returns></returns>
        public static float ConversionFactor(Mass unit1, Mass unit2)
        {
            return (float)unit1.Unit / (float)unit2.Unit;
        }

        /// <summary>
        /// Converts "this" unit to the given unit
        /// </summary>
        /// <param name="anotherUnit"></param>
        /// <returns></returns>
        public float ConversionFactor(Mass anotherUnit)
        {
            return (float)Unit / (float)anotherUnit.Unit;
        }
        #endregion
    }
}
