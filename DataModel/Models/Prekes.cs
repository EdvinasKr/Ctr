using System;
using System.ComponentModel.DataAnnotations;

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