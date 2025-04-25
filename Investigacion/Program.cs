using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigacion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var empleado1 = Empleado.Crear()
				.ConNombre("Ana López")
				.ConEdad(30)
				.ConPuesto("Desarrollador")
				.ConSalario(45000)
				.Construir();

			var empleado2 = Empleado.Crear()
				.ConNombre("Carlos Ruiz")
				.ConEdad(25)
				.ConPuesto("Diseñador")
				.ConSalario(38000)
				.Construir();

			empleado1.MostrarInformacion();
			empleado2.MostrarInformacion();
		}
	}
}
