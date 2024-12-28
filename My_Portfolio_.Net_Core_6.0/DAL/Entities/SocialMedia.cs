using System.ComponentModel.DataAnnotations;

namespace My_Portfolio_.Net_Core_6._0.DAL.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaId { get; set; }
        public string SocialMediaTitle { get; set; }
        public string SocialMediaIcon { get; set; }
        public string SocialMediaLink { get; set; }
    }
}
