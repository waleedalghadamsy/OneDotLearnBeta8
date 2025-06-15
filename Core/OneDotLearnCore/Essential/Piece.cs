using System;
using System.Collections.Generic;
using System.Text;

namespace OneDotLearnCore.Essential
{
    public class Piece : MeasurementUnit
    {
        #region Data Members
        #endregion

        #region Constructors
        public Piece()
        {
            Dimension = MeasurementDimension.Piece;
            Unit = PieceUnit.Onepiece;
        }
        #endregion

        #region Properties
        public PieceUnit Unit { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
