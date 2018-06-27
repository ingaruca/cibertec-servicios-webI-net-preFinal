using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;

namespace WebAPI.Models
{
    public class Herramienta
    {
        [DisplayName("Código")]
        public string idHer { get; set; }

        [DisplayName("Descripción")]
        public string desHer { get; set; }

        [DisplayName("Característica")]
        public string idCar { get; set; }

        [DisplayName("Precio S/")]
        public decimal preUni { get; set; }

        [DisplayName("Stock")]
        public int stock { get; set; }
    }
}