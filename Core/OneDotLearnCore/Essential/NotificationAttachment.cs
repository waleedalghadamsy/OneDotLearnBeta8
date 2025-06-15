using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    [Table("NotificationsAttachments", Schema = "General")]
    public class NotificationAttachment : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int NotificationId { get; set; }
        [Required]
        public NotificationAttachmentType AttachmentType { get; set; }
        [Required, StringLength(250)]
        public string? FullFileName { get; set; }
        [Required]
        public byte[]? Content { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
