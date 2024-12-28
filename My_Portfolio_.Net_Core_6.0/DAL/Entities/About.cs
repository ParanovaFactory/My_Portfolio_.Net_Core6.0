using System.ComponentModel.DataAnnotations;

namespace My_Portfolio_.Net_Core_6._0.DAL.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutSubDescription { get; set; }
        public string AboutDetails { get; set; }
    }
}
