using System.ComponentModel.DataAnnotations;

namespace My_Portfolio_.Net_Core_6._0.DAL.Entities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string MessageSender { get; set; }
        public string MessageSubject { get; set; }
        public string MessageEmail { get; set; }
        public string MessageDetail { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageIsRead { get; set; }
    }
}
