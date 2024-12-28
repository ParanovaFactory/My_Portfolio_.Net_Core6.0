using System.ComponentModel.DataAnnotations;

namespace My_Portfolio_.Net_Core_6._0.DAL.Entities
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }
        public string TestimonialTitle { get; set; }
        public string TestimonialDescription { get; set; }
        public string TestimonialImage { get; set; }
    }
}
