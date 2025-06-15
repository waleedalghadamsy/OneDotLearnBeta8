using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

//using UsageLogging;

namespace OneDotLearnCore.Essential
{
    public class Quantity
    {
        #region Data Members
        #endregion

        #region Constructors
        public Quantity():this(new Piece(), 0)
        {
        }

        public Quantity(MeasurementUnit unit):this(unit, 0)
        {
        }

        public Quantity(MeasurementUnit unit, float val)
        {
            UnitBase = unit; QuantityValue = val;
        }
        #endregion

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotMapped]
        public MeasurementUnit UnitBase { get; set; }
        [Required]
        public float QuantityValue { get; set; }
        [Required]
        public short? UnitBaseId { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Converts the first quantity to the second quantity
        /// </summary>
        /// <param name="qty1"></param>
        /// <param name="qty2"></param>
        /// <returns></returns>
        public static Quantity Convert(Quantity qty1, Quantity qty2)
        {
            float factor = 0.0f;
            
            if (qty1.UnitBase.Dimension != qty2.UnitBase.Dimension)
            {
                //ErrorLogger.ErrorTracer(this,
                //    string.Format("Incompatible quantity units: {0} and {1}",
                //    qty1.unitBase.GetType().Name, qty2.unitBase.GetType().Name));
                return null;
            }

            switch (qty1.UnitBase.Dimension)
            {
                case MeasurementDimension.Piece:
                    break;
                case MeasurementDimension.Length:
                    factor = Length.ConversionFactor(qty1.UnitBase as Length, qty2.UnitBase as Length);
                    break;
                case MeasurementDimension.Mass:
                    factor = Mass.ConversionFactor(qty1.UnitBase as Mass, qty2.UnitBase as Mass);
                    break;
                case MeasurementDimension.Volume:
                    factor = Volume.ConversionFactor(qty1.UnitBase as Volume, qty2.UnitBase as Volume);
                    break;
            }

            return new Quantity(qty1.UnitBase, factor * qty1.QuantityValue);
        }

        /// <summary>
        /// Converts this quantity to the given quantity
        /// </summary>
        /// <param name="anotherQuantity"></param>
        /// <returns></returns>
        //public Quantity ConvertTo(Quantity anotherQuantity)
        //{
        //}

        public static Quantity operator +(Quantity qty1, Quantity qty2)
        {
            return new Quantity(qty1.UnitBase, qty1.QuantityValue + Convert(qty2, qty1).QuantityValue);
        }
        #endregion
    }
}
