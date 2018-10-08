using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Models
{
	public class clsTareas
	{
		public int inCodigo { get; set; }
		public string stTitular { get; set; }
		public string stAsunto { get; set; }
		public string stFechaVencimiento { get; set; }
		public string stContacto { get; set; }
		public string stCuenta { get; set; }
		public clsEstadoTareas clsEstadoTareas { get; set; }
		public clsPrioridad clsPrioridad { get; set; }
		public Char chEnviarMensaje { get; set; }
		public char chRepetir { get; set; }
		public string stDescripcion { get; set; }
	}
}
