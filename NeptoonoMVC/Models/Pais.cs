using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeptoonoMVC.Models
{

    [Table("Paises")]
    public class Pais
    {
      
        public int PaisId { get; set; }
        [Display(Name = "Pais")]
        public string NombrePais { get; set; }
    }
}