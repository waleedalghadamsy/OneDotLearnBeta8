using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    public class UserSession
    {
        #region Data Members
        #endregion

        #region Constructors
        public UserSession(string userAgent, string ip)
        {
            UserAgent = userAgent; IP = ip;
            Id = Guid.NewGuid().ToString(); LastActionTime = DateTime.Now;
            Data = new List<SessionData>(); //BrowserWindows = new Stack<string>();
        }
        #endregion

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Serial { get; set; }
        [Required]
        public string Id { get; set; }
        [Required]
        public string UserAgent { get; set; }
        [Required]
        public string IP { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTimeOffset LastActionTime { get; set; }
        //[NotMapped]
        //public Stack<string> BrowserWindows { get; set; }
        [NotMapped]
        public List<SessionData> Data { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
