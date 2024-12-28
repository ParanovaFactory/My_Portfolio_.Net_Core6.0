using System.ComponentModel.DataAnnotations;

namespace My_Portfolio_.Net_Core_6._0.DAL.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactTitle { get; set; }
        public string ContactDescription { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }
    }
}
