using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigacion
{
	public class Empleado
	{
		private string nombre;
		private int edad;
		private string puesto;
		private decimal salario;

		public void MostrarInformacion()
		{
			Console.WriteLine($"\nNombre: {nombre}");
			Console.WriteLine($"Edad: {edad}");
			Console.WriteLine($"Puesto: {puesto}");
			Console.WriteLine($"Salario: {salario:C}");
		}

		private Empleado() { }

		public static EmpleadoBuilder Crear() => new EmpleadoBuilder();

		public class EmpleadoBuilder
		{
			private readonly Empleado empleado = new Empleado();

			public EmpleadoBuilder ConNombre(string nombre)
			{
				if (string.IsNullOrWhiteSpace(nombre))
					throw new ArgumentException("El nombre no puede estar vacío");

				empleado.nombre = nombre.Trim();
				return this;
			}

			public EmpleadoBuilder ConEdad(int edad)
			{
				if (edad < 18 || edad > 70)
					throw new ArgumentException("La edad debe estar entre 18 y 70 años");

				empleado.edad = edad;
				return this;
			}

			public EmpleadoBuilder ConPuesto(string puesto)
			{
				empleado.puesto = puesto ?? "Sin especificar";
				return this;
			}

			public EmpleadoBuilder ConSalario(decimal salario)
			{
				if (salario < 0)
					throw new ArgumentException("El salario no puede ser negativo");

				empleado.salario = salario;
				return this;
			}

			public Empleado Construir()
			{
				// Validación final antes de crear el objeto
				if (string.IsNullOrEmpty(empleado.puesto))
					empleado.puesto = "Sin especificar";

				return empleado;
			}
		}
	}
}
