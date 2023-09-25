using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Temporada
    {
        public int Id {  get; set; }
        public int IdSerie { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string Nombre { get; set; }
        [DisplayName("Estreno de Temporada")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EstrenoDeTemporada { get; set; }
        [DisplayName("Capítulos")]
        public int Capitulos {  get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
