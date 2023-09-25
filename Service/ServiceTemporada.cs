using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace Service
{
    public class ServiceTemporada
    {  
        public List<Temporada> listar()
        {
            List<Temporada> lista = new List<Temporada>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Nombre, Descripcion, Fecha, IdSerie, CantidadCapitulos from TEMPORADA");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Temporada aux = new Temporada();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.EstrenoDeTemporada = (DateTime)datos.Lector["Fecha"];
                    aux.IdSerie = (int)datos.Lector["IdSerie"];
                    aux.Capitulos = (int)datos.Lector["CantidadCapitulos"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }           
        }
    }
}
