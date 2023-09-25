using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace Service
{
    public class ServiceGenero
    {   
        public List<Genero> listar()
        {	
			List<Genero> lista = new List<Genero>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("Select Id, Nombre from GENEROS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Genero aux = new Genero();
					aux.Id = (int)datos.Lector["Id"];
					aux.Nombre = (string)datos.Lector["Nombre"];

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
