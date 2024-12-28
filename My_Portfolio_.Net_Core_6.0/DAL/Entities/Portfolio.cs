using System.ComponentModel.DataAnnotations;

namespace My_Portfolio_.Net_Core_6._0.DAL.Entities
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string PortfolioTitle { get; set; }
        public string PortfolioSubTitle { get; set; }
        public string PortfolioImage { get; set; }
        public string PortfolioUrl { get; set; }
        public string PortfolioDescription { get; set; }
    }
}
