using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetrixSisClient.Models
{
    public class Animal
    {
        public Animal()
        {
           // Anuncio = new HashSet<Anuncio>();
        }

        [Key]
        public int id_animal { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage ="informe o nome do animal")]
        public string ds_animal { get; set; }

       // public virtual ICollection<Anuncio> Anuncio { get; set; }
    }
}