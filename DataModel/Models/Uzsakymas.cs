using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eshop.Models
{
    public class Krepselis
    {
        [Key]
        public Guid KrepselisId { get; set; }
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }
        public int Kiekis { get; set; }
    }

    public class Uzsakymas
    {
        public Uzsakymas()
        {
            Krepselis = new List<Krepselis>();
        }
        [Key]
        public Guid UzsakymoId { get; set; }
        public virtual List<Krepselis> Krepselis { get; set; }
    }


}
