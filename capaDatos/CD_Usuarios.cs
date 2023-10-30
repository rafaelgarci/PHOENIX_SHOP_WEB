using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using System.Data.SqlClient;
using System.Data;



namespace capaDatos
{
    public class CD_Usuarios
    {
        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "select id_usuario,nombres,apellidos,correo,clave,reestablecer,activo from USUARIO";
                    
                    SqlCommand cmd = new SqlCommand(query , oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader() ){
                        while (dr.Read())
                        {
                            lista.Add(
                                new Usuario()
                                {
                                    Id_usuario = Convert.ToInt32(dr["Id_usuario"]),
                                    Nombres = dr["nombres"].ToString(),
                                    Apellidos = dr["apellidos"].ToString(),
                                    Correo = dr["correo"].ToString(),
                                    Clave = dr["clave"].ToString(),
                                    Reestablecer = Convert.ToBoolean(dr["reestablecer"]),
                                    Activo = Convert.ToBoolean(dr["activo"])

                                }
                                );
                        }
                    }
                }
            }
            catch
            {
                lista = new List<Usuario>();

            }

            return lista;

        }            

    }
}
