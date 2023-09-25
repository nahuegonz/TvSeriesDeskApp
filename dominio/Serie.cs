using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Serie
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string ImagenUrl { get; set; }
        [DisplayName("Fecha de Estreno")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaDeEstreno { get; set; }
        [DisplayName("Género")]
        public Genero Genero { get; set; }
        //[DisplayName("Temporadas")]
        //public Temporada Temporada { get; set; }

    }
}
