using OneDotLearnCore.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    [Table("NotificationsReceivers", Schema = "General")]
    public class NotificationReceiver : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int NotificationId { get; set; }
        public UserRole? ReceiverRole { get; set; }
        [Required]
        public int ReceiverId { get; set; }
        [Required]
        public NotificationStatus Status { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTimeOffset DateTime { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
