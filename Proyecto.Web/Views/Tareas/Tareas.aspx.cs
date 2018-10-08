using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Proyecto.Web.Views.Tareas
{
	public partial class Tareas : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				Controllers.TareasController obtareasController = new Controllers.TareasController();
				DataSet dsConsultaEstadoTareas = obtareasController.getConsultarEstadoTareasController();
				DataSet dsConsultarPrioridad = obtareasController.getConsultarPrioridadController();
				//Asigno Origen de Datos
				ddlEstado.DataSource = dsConsultaEstadoTareas;
				ddlEstado.DataTextField = "estaDescripcion";//Lo que se muestra
				ddlEstado.DataValueField = "estaCodigo";//Lo que equivale
				ddlEstado.DataBind();//Acepte los cambios

				//Asigno Origen de Datos
				ddlPrioridad.DataSource = dsConsultarPrioridad;
				ddlPrioridad.DataTextField = "prioDescripcion";//Lo que se muestra
				ddlPrioridad.DataValueField = "prioCodigo";//Lo que equivale
				ddlPrioridad.DataBind();//Acepte los cambios


			}
		}
	}
}