using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Prekes
    {
        [Key]
        public Guid PrekesId { get; set; }
        public string Pavadinimas { get; set; }
        public string Aprasymas { get; set; }
        public double Kaina { get; set; }
        public int EsamasKiekis { get; set; }
        public int NupirktasKiekis { get; set; }
        public int KiekPerku { get; set; }
        public DateTime GaliojimoPabaiga { get; set; }
    }


}