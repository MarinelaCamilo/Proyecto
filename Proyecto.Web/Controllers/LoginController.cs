using System;

namespace Proyecto.Web.Controllers
{
	public class LoginController
	{
		/// <summary>
		/// Valida usuario
		/// </summary>
		/// <param name="obclsUsuarios">Objeto Ususario</param>
		/// <returns>Confirmación</returns>
		public bool getValidarUsuarioControllers(Logica.Models.clsUsuarios obclsUsuarios) {
			try
			{
				Logica.BL.clsUsuarios obclsUsuario = new Logica.BL.clsUsuarios();

				return obclsUsuario.getValidarUsuario(obclsUsuarios);
			}
			catch(Exception ex) { throw ex; }
		}
	}
}