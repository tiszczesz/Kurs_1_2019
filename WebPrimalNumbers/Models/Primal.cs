using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Kurs.Primary;

namespace WebPrimalNumbers.Models
{
    public class Primal
    {
       
        [Required(ErrorMessage = "Podaj liczbę")]
        [Range(minimum:2,maximum:20000)]
        public int Liczba { get; set; }
    
    }
}