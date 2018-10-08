using System;
using System.Net;
using System.Web;

namespace Proyecto.Web.Views.Login
{
	public partial class Login : System.Web.UI.Page
	{
		

		protected void Page_Load(object sender, EventArgs e)
		{
			//La primera vez que carga la página
			if (!IsPostBack)
			{
			 if (Request.Cookies["cookieEmail"] != null)
				txtEmail.Text = Request.Cookies["cookieEmail"].Value.ToString();
			}
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

				//Instancio controlador 
				Controllers.LoginController obLoginController = new Controllers.LoginController();
				bool blBandera = obLoginController.getValidarUsuarioControllers(obclsUsuarios);

				if (blBandera)
				{
					Session["sessionEmail"] = txtEmail.Text;
					if (chkRecordar.Checked)



						if (chkRecordar.Checked)
					{
						//Creo un objeto Cookie
						HttpCookie cookie = new HttpCookie("cookieEmail", txtEmail.Text);
						//Agrego el tiempo de vida de la Cookie
						cookie.Expires = DateTime.Now.AddDays(2);
						//Agrego a la coleccion de Cookies
						Response.Cookies.Add(cookie);
					}
					else
					{
						HttpCookie cookie = new HttpCookie("cookieEmail", txtEmail.Text);
						//Expira el dia de anterior
						cookie.Expires = DateTime.Now.AddDays(-1);
						Response.Cookies.Add(cookie);
					}
					//Antaes del signo de pregunta es la ruta a la cual debe dirigierse, luego del signo pregunta qué es lo que voy a enviar a través de la URL
					Response.Redirect("../Index/Index.aspx?stEmail=" + txtEmail.Text);//Redireccionamos
				}
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