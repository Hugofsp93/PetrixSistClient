using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetrixSisClient.Models
{
    public class Tipo
    {
        public Tipo()
        {
         //   Usuario = new HashSet<Usuario>();
        }

        [Key]
        public int id_tipo { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "informe o tipo")]
        public string ds_tipo { get; set; }

    //    public virtual ICollection<Usuario> Usuario { get; set; }
    }
}