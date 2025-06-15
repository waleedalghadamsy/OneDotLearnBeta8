using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Logging
{
    public class RequestedPage : LogEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public long Id { get; set; }
        public int? UserId { get; set; }
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public string? RequestPath { get; set; }
        //[Required, StringLength(25)]
        //public string RequestTime { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
