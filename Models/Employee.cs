using System;
using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh1402.Models
{
    public class Employee
    {
        [Key]
        [Display(Name ="Mã nhân viên")]
        public int EmployeeID { get; set; }
        [Display(Name ="Tên nhân viên")]
        [MaxLength(40)]
        [MinLength(10)]
        public string EmployeeName { get; set; }
        public string Address { get; set; }
    }
}