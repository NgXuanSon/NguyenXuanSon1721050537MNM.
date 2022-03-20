using System;
using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh1402.Models
{
    public class Customer : Person
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Thể loại không được để trống")]
        [MaxLength(30)]
        [MinLength(2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string  Gender { get; set; }
        public string Brithday { get; set; }
    }
}