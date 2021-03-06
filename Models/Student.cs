using System;
using System.ComponentModel.DataAnnotations;

namespace BaiThucHanh1402.Models
{
  
    public class Student
    {
        [Key]
        [Display(Name ="Mã học sinh")]
        public int StudentID { get; set; }
        [MaxLength(40)]
        public string StudentName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Address { get; set; }
    }
}