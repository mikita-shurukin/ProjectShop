using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name ="Wpisz Imię")]
        [StringLength(30)]
        [Required(ErrorMessage = "Długość nazwy nie może być większa niż 30 znaków")]
        public string name { get; set; }
        [Display(Name = "Wpisz Nazwisko")]
        [StringLength(30)]
        [Required(ErrorMessage = "Długość nazwy nie może być większa niż 30 znaków")]
        public string surname { get; set; }
        [Display(Name = "Wpisz Swój Adres")]
        [StringLength(50)]
        [Required(ErrorMessage = "Długość nazwy nie może być większa niż 50 znaków")]
        public string adress { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Długość nazwy nie może być większa niż 30 znaków")]
        public string email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(30)]
        [Required(ErrorMessage = "Długość nazwy nie może być większa niż 30 znaków")]
        public string phone { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetail { get; set; }
    }
}
