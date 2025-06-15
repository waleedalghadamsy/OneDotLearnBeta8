using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    public class SessionData
    {
        #region Data Members
        #endregion

        #region Constructors
        public SessionData(string sessionId, string key, string data)
        {
            SessionId = sessionId; Key = key; Data = data;
        }
        #endregion

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string SessionId { get; set; }
        [Required]
        public string Key { get; set; }
        [Required]
        public string Data { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
