using System.ComponentModel.DataAnnotations;

namespace My_Portfolio_.Net_Core_6._0.DAL.Entities
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillTitle { get; set; }
        public string SkillValue { get; set; }
    }
}
