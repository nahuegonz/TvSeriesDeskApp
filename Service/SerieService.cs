using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace Service
{
    public class SerieService
    {
        public List<Serie> listar()
        {
            List<Serie> lista = new List<Serie>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=SERIES_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select S.Id SerieId, S.Nombre SerieNombre, S.Descripcion SerieDescripcion, ImagenUrl, S.FechaEstreno FechaDeEstreno, G.Nombre Genero, G.Id GeneroId from SERIES S, GENEROS G where IdGenero = G.Id And S.Activo = 1";
                comando.Connection = conexion;
                
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Serie aux = new Serie();
                    aux.Id = (int)lector["SerieId"];
                    aux.Nombre = (string)lector["SerieNombre"];                   
                    aux.Descripcion = (string)lector["SerieDescripcion"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.FechaDeEstreno = (DateTime)lector["FechaDeEstreno"];
                    aux.Genero = new Genero();
                    aux.Genero.Nombre = (string)lector["Genero"];
                    aux.Genero.Id = (int)lector["GeneroId"];
                    //aux.Temporada = new Temporada();
                    //aux.Temporada.Id = (int)lector["TemporadaId"];
                    //aux.Temporada.IdSerie = (int)lector["TemporadaIdSerie"];
                    //aux.Temporada.Nombre = (string)lector["TemporadaNombre"];
                    //aux.Temporada.EstrenoDeTemporada = (DateTime)lector["TemporadaFecha"];
                    //aux.Temporada.Capitulos = (int)lector["TemporadaCantidadCapitulos"];

                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
         
                
       
        }

        public void agregar(Serie nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into SERIES (Nombre, Descripcion, FechaEstreno, IdGenero, ImagenUrl, Activo) values (@nombre, @descripcion, @FechaEstreno, @idGenero, @imagen, 1)");                               
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@FechaEstreno", nuevo.FechaDeEstreno);
                datos.setearParametro("@idGenero", nuevo.Genero.Id);
                datos.setearParametro("@imagen", nuevo.ImagenUrl);
                datos.ejecutarAccion();
                //datos.setearConsulta("Insert into TEMPORADA (Nombre, Fecha, IdSerie, CantidadCapitulos) values (@nombre, @fecha, @idSerie, @CantidadCapitulos)");
                //datos.setearParametro("@nombre", nuevo.Temporada.Nombre);
                //datos.setearParametro("@fecha", nuevo.Temporada.EstrenoDeTemporada);
                //datos.setearParametro("@idSerie", nuevo.Id);
                //datos.setearParametro("@CantidadCapitulos", nuevo.Temporada.Capitulos);
                //datos.ejecutarAccion();
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

        public void modificar(Serie serie)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update SERIES set Nombre = @nombre, Descripcion = @descripcion, ImagenUrl = @imagen, FechaEstreno = @fecha, IdGenero = @idGenero where Id = @id");
                datos.setearParametro("@nombre", serie.Nombre);
                datos.setearParametro("@descripcion", serie.Descripcion);
                datos.setearParametro("@imagen", serie.ImagenUrl);
                datos.setearParametro("@fecha", serie.FechaDeEstreno);
                datos.setearParametro("@idGenero", serie.Genero.Id);
                datos.setearParametro("@id", serie.Id);

                datos.ejecutarAccion();

                //datos.setearConsulta("update TEMPORADA set Nombre = @nombre, Fecha = @fecha, IdSerie = @idSerie, CantidadCapitulos = @CantidadCapitulos where Id = @id");
                //datos.setearParametro("@nombre", serie.Temporada.Nombre);
                //datos.setearParametro("@fecha", nuevo.Temporada.EstrenoDeTemporada);
                //datos.setearParametro("@idSerie", serie.Id);
                //datos.setearParametro("@CantidadCapitulos", serie.Temporada.Capitulos);
                //datos.ejecutarAccion();
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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from SERIES where Id = @id");
                //datos.setearConsulta("delete from TEMPORADA where IdSerie = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarLogico (int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update SERIES set Activo = 0 Where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Serie> filtrar(string campo, string criterio, string filtro)
        {   
            List<Serie> lista = new List<Serie>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select S.Id SerieId, S.Nombre SerieNombre, S.Descripcion SerieDescripcion, ImagenUrl, S.FechaEstreno FechaDeEstreno, G.Nombre Genero, G.Id GeneroId from SERIES S, GENEROS G where IdGenero = G.Id And S.Activo = 1 And ";
                switch (campo)
                {
                    case "Año":
                        switch (criterio)
                        {
                            case "Despues del":
                                consulta += "S.FechaEstreno > '" + filtro + "'";
                                break;
                            case "Antes del":
                                if (filtro == "")
                                {
                                    consulta += "S.FechaEstreno > '" + filtro + "'";
                                }
                                else
                                {
                                    consulta += "S.FechaEstreno < '" + filtro + "'";
                                }                                                          
                                break;
                            default:
                                if (int.TryParse(filtro, out int año))
                                {
                                    consulta += $"YEAR(S.FechaEstreno) = {año}";
                                }
                                if (filtro == "")
                                {
                                    consulta += "S.FechaEstreno > '" + filtro + "'";
                                }
                                break;
                        }
                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "S.Nombre like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "S.Nombre like '%" + filtro + "' ";
                                break;
                            default:
                                consulta += "S.Nombre like '%" + filtro + "%' ";
                                break;
                        }
                        break;

                    case "Género":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "G.Nombre like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "G.Nombre like '%" + filtro + "' ";
                                break;
                            default:
                                consulta += "G.Nombre like '%" + filtro + "%' ";
                                break;
                        }
                        break;
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Serie aux = new Serie();
                    aux.Id = (int)datos.Lector["SerieId"];
                    aux.Nombre = (string)datos.Lector["SerieNombre"];
                    aux.Descripcion = (string)datos.Lector["SerieDescripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.FechaDeEstreno = (DateTime)datos.Lector["FechaDeEstreno"];
                    aux.Genero = new Genero();
                    aux.Genero.Nombre = (string)datos.Lector["Genero"];
                    aux.Genero.Id = (int)datos.Lector["GeneroId"];
                    
                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    

    
}
