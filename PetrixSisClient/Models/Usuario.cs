using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetrixSisClient.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Anuncio = new HashSet<Anuncio>();
        }

        [Key]
        public int id_user { get; set; }

        [StringLength(255)]
        public string email_user { get; set; }

        [StringLength(255)]
        public string endereco_user { get; set; }

        [StringLength(255)]
        public string nome_user { get; set; }

        [StringLength(255)]
        public string cfp_user { get; set; }

        [StringLength(255)]
        public string cnpj_user { get; set; }

        [StringLength(255)]
        public string site_user { get; set; }

        public int? fk_Tipo_id_tipo { get; set; }

        public virtual ICollection<Anuncio> Anuncio { get; set; }

        public virtual Tipo Tipo { get; set; }
    }
}