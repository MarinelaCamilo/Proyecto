using System;

using System.Data;
namespace Proyecto.Web.Controllers
{
	public class PosiblesClientesController
	{
		/// <summary>
		/// Obtiene Registros Posibles Clientes
		/// </summary>
		/// <returns>Data Posibles Clientes</returns>
		public DataSet getConsultarPosiblesClientesController()
		{

			try
			{
				Logica.BL.ClsPosiblesClientes obclsPosiblesClientes = new Logica.BL.ClsPosiblesClientes();
				return obclsPosiblesClientes.getConsultarPosiblesClientes();

			}
			catch (Exception ex) { throw ex; }
		}
		/// <summary>
		/// Administra Posibles Clients
		/// </summary>
		/// <param name="obClsPosiblesClientesModels">Objeto</param>
		/// <param name="inOpcion">Opción de Ejecución</param>
		/// <returns>Mensaje de Proceso</returns>
		public string setAdministrarPosiblesClientesControllers(Logica.Models.ClsPosiblesClientes obClsPosiblesClientesModels,
			int inOpcion)
		{
			{
				try
				{
					Logica.BL.ClsPosiblesClientes obclsPosiblesClientes = new Logica.BL.ClsPosiblesClientes();
					
					return obclsPosiblesClientes.SetAdministrarPosiblesClientes(obClsPosiblesClientesModels, inOpcion);
				}
				catch (Exception ex) { throw ex; }

			}
		}
	}
}