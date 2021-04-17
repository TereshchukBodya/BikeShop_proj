using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введіть ім'я")]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина імені повинна бути не менше 3 символів")]
        public string name { get; set; }
        [Display(Name = "Введіть прізвище")]
        [StringLength(25)]
        [Required(ErrorMessage = "Довжина прізвища повинна бути не менше 5 символів")]
        public string surname { get; set; }
        [Display(Name = "Введіть адресу")]
        [StringLength(50)]
        [Required(ErrorMessage = "Довжина адреси повинна бути не менше 10 символів")]
        public string adress { get; set; }
        [Display(Name = "Введіть номер телефону")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина номеру телефону повинна бути не менше 10 символів")]
        public string phone { get; set; }
        [Display(Name = "Введіть Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [Required(ErrorMessage = "Довжина поштової скриньки повинна бути не менше 11 символів")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
