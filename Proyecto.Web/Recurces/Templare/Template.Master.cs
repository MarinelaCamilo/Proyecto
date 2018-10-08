using System;

namespace Proyecto.Web.Recurces.Templare
{
	public partial class Template : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string[] stEmail = null;

				if (Session["sessionEmail"] != null)
				{
					stEmail = Session["sessionEmail"].ToString().Split('@');
					lblUsuario.Text = stEmail[0];
				}
				else
					Response.Redirect("../../Views/Login/Login.aspx");
			}
		}
		protected void btnSalir_Click(object sender, EventArgs e)
		{
			//Session.Remove("sessionEmail");//Elimina variable de sesión en específico
			Session.RemoveAll();//Borra todas la variables de sesión del aplicativo. La variables de sesión perteneces al usuario que acaba de loguearse
			Response.Redirect("../../Views/Login/Login.aspx");
		}
	}
}