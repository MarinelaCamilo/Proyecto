using System;

namespace Proyecto.Web.Views.Login
{
	public partial class Login : System.Web.UI.Page
	{
		

		protected void Page_Load(object sender, EventArgs e)
		{
		//ctrl + k +c comentar
		// ctrl + k + u comentar
		//if(!IsPostBack)
		//ClientScript.RegisterStartupScript(this.GetType(),"mensaje", "<script>swal('Buen trabajo!', 'Se realizó proceso con éxito!', 'success')</script>");
		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		protected void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				string stMensaje = string.Empty;
				if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje +="Ingrese email, ";
				if (string.IsNullOrEmpty(TxePassword.Text)) stMensaje +="Ingrese password,";

				if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

				//Se define objeto con propiedades 
				Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
				{
					stLogin = txtEmail.Text,
					stPassword = TxePassword.Text,

				};

				//Instanciamos controlador 
				Controllers.LoginController obLoginController = new Controllers.LoginController();
				bool blBandera = obLoginController.getValidarUsuarioControllers(obclsUsuarios);

				if (blBandera)
					Response.Redirect("../Index/Index.aspx"); //Redireccionamos

				else
					throw new Exception("Usuario o password incorrectos");
			}
			catch(Exception ex)
			{
			 ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!', '"+ex.Message+"!', 'error')</script>");
			}
		}
	}
}