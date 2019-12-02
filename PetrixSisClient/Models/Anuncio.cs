using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetrixSisClient.Models
{
    public class Anuncio
    {
        public Anuncio()
        {
            //Imagem_Anuncio = new HashSet<Imagem_Anuncio>();
        }

        [StringLength(255)]
        public string email_anun { get; set; }

        [StringLength(500)]
        public string conteudo_anun { get; set; }

        [StringLength(255)]
        public string telefone_anun { get; set; }

        [StringLength(255)]
        public string titulo_anun { get; set; }

        [Key]
        public int id_anun { get; set; }

        public DateTime? data_anun { get; set; }

        public int? fk_Usuario_id_user { get; set; }

        public int? fk_Animal_id_animal { get; set; }

        public int? fk_Localidade_id_local { get; set; }

        public virtual Animal Animal { get; set; }

        //public virtual Usuario Usuario { get; set; }

        //public virtual Localidade Localidade { get; set; }

        //public virtual ICollection<Imagem_Anuncio> Imagem_Anuncio { get; set; }
    }
}
