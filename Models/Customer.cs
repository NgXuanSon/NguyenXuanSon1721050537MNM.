using System;
using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh1402.Models
{
    public class Customer : Person
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public string  Gender { get; set; }
        public string Brithday { get; set; }
    }
}