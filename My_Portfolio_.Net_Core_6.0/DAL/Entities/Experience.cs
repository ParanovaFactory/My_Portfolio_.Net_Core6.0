using System.ComponentModel.DataAnnotations;

namespace My_Portfolio_.Net_Core_6._0.DAL.Entities
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string ExperienceHead { get; set; }
        public string ExperienceTitle { get; set; }
        public string ExperienceDate { get; set; }
        public string ExperienceDescription { get; set; }
    }
}
