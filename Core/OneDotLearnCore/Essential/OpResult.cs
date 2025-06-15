using System;
using System.Collections.Generic;
using System.Text;

namespace OneDotLearnCore.Essential
{
    public class OpResult //: IEquatable<OpResult>
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        public int AddedEntityId { get; set; }
        public static OpResult Succeeded => new OpResult() 
                                { IsSuccessful = true, Error = null };
        public static OpResult Failed => new OpResult() 
                                { IsSuccessful = false, Error = "There is an error!" };
        public bool IsSuccessful { get; set; }
        public string? Error { get; set; }
        #endregion

        #region Methods
        //public bool Equals(OpResult other)
        //{
        //    return IsSuccessful == other.IsSuccessful;
        //}
        #endregion
    }
}
