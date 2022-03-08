using System;
using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh1402.Models
{
    public class Person
    {
      [Key]
      [Display(Name ="Mã Người")]
      public string PersonID { get; set; }
      [MaxLength(40)]
      [MinLength(10)]
      [Display(Name ="Tên Người")]
      public string PersonName { get; set; }
      public string Address { get; set; }
    }
}