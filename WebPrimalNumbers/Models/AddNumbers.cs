using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPrimalNumbers.Models
{
    public class AddNumbers
    {
        [Display(Name="Podaj A")]
        [Required(ErrorMessage = "Podaj liczbę całkowitą")]
        public int A { get; set; }

        [Display(Name = "Podaj B")]
        [Required(ErrorMessage = "Podaj liczbę całkowitą")]
        public int B { get; set; }

        public int GetSum()
        {
            return A + B;
        }
    }
}