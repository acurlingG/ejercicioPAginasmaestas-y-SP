using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using quiz.CapaModelo;

namespace quiz.CapaLogica
{
    public class Business_Class
    {

        #region AgregarClases
        public static int AgregarClass(string nombre)
        {
            int retorno = 0;
        ;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Agregar", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@Nombre", nombre));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        #endregion

        #region Listado de Clases


        public static List<Cls_Class> ObtenerClases()
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            List<Cls_Class> clases = new List<Cls_Class>();  // definiendo el nombre de la lista
            try
            {

                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("consultar", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    
                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cls_Class clase = new Cls_Class();
                            clase.id = reader.GetInt32(0);
                            clase.nombre = reader.GetString(1);
                            clases.Add(clase);  // agregar en la lista los elementos encontrados
                        }

                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return clases;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return clases;
        }
        #endregion

        #region Listado con Filtro
        public static List<Cls_Class> ObtenerClasesFiltro(int codigo)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            List<Cls_Class> clases = new List<Cls_Class>();
            try
            {

                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("consultarfiltro", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", codigo));
                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cls_Class clase = new Cls_Class();
                            clase.id = reader.GetInt32(0);
                            clase.nombre = reader.GetString(1);
                            clases.Add(clase);
                        }

                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return clases;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return clases;
        }

        #endregion

        #region AgregarClases
        //

        ///
        #endregion

    }
}