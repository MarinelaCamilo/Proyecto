using System.Configuration;
namespace Proyecto.Logica.BL
{
	public class clsConexion
	{
	/// <summary>
	/// Conexion a Base de datos
	/// </summary>
	/// <returns>Retorna cadena de conexion</returns>
	 public string getConexion()
		{
			return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
		}
	}
}
