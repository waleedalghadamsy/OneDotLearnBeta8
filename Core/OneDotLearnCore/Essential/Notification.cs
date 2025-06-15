using OneDotLearnCore.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    [Table("Notifications", Schema = "General")]
    public class Notification : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required, StringLength(500)]
        public string? Text { get; set; }
        [NotMapped]
        public List<NotificationReceiver>? Receivers { get; set; }
        [NotMapped]
        public List<NotificationAttachment>? Attachments { get; set; }
        [Required]
        public bool IsReceived { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
