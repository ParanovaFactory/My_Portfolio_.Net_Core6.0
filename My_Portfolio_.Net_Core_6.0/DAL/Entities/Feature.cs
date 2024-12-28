using System.ComponentModel.DataAnnotations;

namespace My_Portfolio_.Net_Core_6._0.DAL.Entities
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureDescription { get; set; }
    }
}
