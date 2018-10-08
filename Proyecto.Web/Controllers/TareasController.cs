using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Proyecto.Web.Controllers
{
	public class TareasController
	{
		/// <summary>
		/// Obtiene Registros estado tareas
		/// </summary>
		/// <returns>Data Estado Tareas</returns>
		public DataSet getConsultarEstadoTareasController()
		{

			try
			{
				Logica.BL.clsEstadoTarea obclsEstadoTarea = new Logica.BL.clsEstadoTarea();
				return obclsEstadoTarea.getConsultarEstadoTareas();

			}
			catch (Exception ex) { throw ex; }
		}

		/// <summary>
		/// Obtiene Registros Prioridad
		/// </summary>
		/// <returns>Data Prioridad</returns>
		public DataSet getConsultarPrioridadController()
		{

			try
			{
				Logica.BL.clsPrioridad obclsPrioridad = new Logica.BL.clsPrioridad();
				return obclsPrioridad.getConsultarPrioridad();

			}
			catch (Exception ex) { throw ex; }
		}
	}
}