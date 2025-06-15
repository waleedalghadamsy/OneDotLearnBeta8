using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using OneDotLearnCore.Essential;

namespace OneDotLearnCore.Training
{
    public class Classroom : BaseEntity
    {
        #region Constructors
        //public Classroom(string code, byte nSeats)
        //{
        //    Code = code; NoOfSeats = nSeats;
        //}
        #endregion

        #region Properties
        public string Code { get; set; }
        public byte NoOfSeats { get; set; }
        #endregion

        #region Methods
        //public void Load<T>(T dbEntity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Save()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Load()
        //{
        //    throw new NotImplementedException();
        //}
        #endregion
    }
}
