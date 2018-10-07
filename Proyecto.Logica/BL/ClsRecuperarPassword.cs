using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace Proyecto.Logica.BL
{
	public class ClsRecuperarPassword
	{
		SqlConnection _SqlConnection = null; //Permite Establecer Conexion con BBDD
		SqlCommand _SqlCommand = null;//Pertmite Ejecutar Comandos SQL Server
		SqlDataAdapter SqlDataAdapter = null;// Permite Adaptar Conjunto de Datos SQL Server
		string stConexion = string.Empty;//Cadena De Conexion

		SqlParameter SqlParameter = null;

		public ClsRecuperarPassword()
		{
			clsConexion obclsConexion = new clsConexion();
			stConexion = obclsConexion.getConexion();
		}

		public SqlDataAdapter _SqlDataAdapter { get; private set; }

		/// <summary>
		/// Consulta Password
		/// </summary>
		/// <returns>Registros Usuarios</returns>
		public DataSet getConsultaPassword(Models.clsUsuarios obclsUsuarios)
		{
			try
			{

				DataSet dsConsulta = new DataSet();

				_SqlConnection = new SqlConnection(stConexion);
				_SqlConnection.Open();

				_SqlCommand = new SqlCommand("spConsultarPassword", _SqlConnection);
				_SqlCommand.CommandType = CommandType.StoredProcedure;

				_SqlCommand.Parameters.Add(new SqlParameter("@CLogin", obclsUsuarios.stLogin));

				_SqlCommand.ExecuteNonQuery();
				_SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
				_SqlDataAdapter.Fill(dsConsulta);

				return dsConsulta;



			}
			catch (Exception ex) { throw ex; }
			finally { _SqlConnection.Close(); }
			}
		}
	}

	