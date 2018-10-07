using System;
using System.Data;

namespace Proyecto.Web.Controllers
{
	public class RecuperarPasswordController
	{
		public DataSet getConsultaPasswordController(Logica.Models.clsUsuarios obclsUsuarios)
		{
			try
			{
				Logica.BL.ClsRecuperarPassword obclsRecuperarPassword = new Logica.BL.ClsRecuperarPassword();
				return obclsRecuperarPassword.getConsultaPassword(obclsUsuarios);
			}
			catch (Exception ex) { throw ex; }
		}
		public void setEmailController(Logica.Models.ClsCorreo obClsCorreo)
		{
			try
			{
				Logica.BL.ClsGeneral obClsGeneral = new Logica.BL.ClsGeneral();
				obClsGeneral.SetEmail(obClsCorreo);


			}
			catch (Exception ex) { throw ex; }
		}
	}
}