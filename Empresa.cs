using System;
using System.Collections;

namespace TP_FINAL_ALGORITMOS
{
	/// <summary>
	/// Description of Empresa.
	/// </summary>
	public class Empresa
	{
		//Propiedades
		private ArrayList empleados { get; set; }
		private ArrayList obras { get; set; }
		
		public Empresa()
		{
			this.empleados = new ArrayList();
			this.obras = new ArrayList();
		}
		
		// Listado de Obras en curso
		public void ObrasEnCurso()
		{
			if(obras.Count == 0){
				Console.WriteLine("La empresa no realizó ninguna obra");
			}else{
				foreach (Obra o in obras)
				{
					if (o.estado_avance < 100)
					{
						o.ImprimirPropiedades();
					}
				}
			}
			
		}
		
		// Listado de Obras finalizadas
		public void ObrasFinalizadas()
		{
			if(obras.Count == 0){
				Console.WriteLine("La empresa no realizó ninguna obra");
			}else{
				foreach (Obra o in obras)
				{
					if (o.estado_avance == 100)
					{
						o.ImprimirPropiedades();
					}
				}
			}
			
		}
		
		// Porcentaje de obras en remodelacion
		public void PorcentajeObrasRemodelacion()
		{
			int sumatoria = 0;
			int contador=0;
			double porcentaje;
			foreach (Obra o in obras)
			{
				if (o.estado_avance < 100)
				{
					sumatoria +=o.estado_avance;
					contador++;
				}
			}
			porcentaje = sumatoria/contador;
			Console.WriteLine("Porcentaje de obras en remodelacion: " + porcentaje + "%");
		}
		
		// Modificar Porcentaje de Obra
		public void modPorcentajeobra(int cod_inter, int porcentaje)
		{
			/*if(porcentaje > 100)
			{
				// Acá se lanza una excepción
				Console.WriteLine("El porcentaje no debe ser mayor al 100%");
				break;
			}*/
			
			foreach (Obra o in obras)
			{
				if (o.cod_interno == cod_inter)
				{
					if(o.estado_avance == 100)  //????? CONSULTAR ????????
					{
						// Acá se lanza una excepción
						Console.WriteLine("No se puede modificar el estado de la obra por que se encuentra finalizada");
					}
					else
					{
						o.estado_avance = porcentaje;
						Console.WriteLine("Se modificó el estado de la obra correctamente");
					}
				}
			}
		
		}
		
		//Listado de Obreros
		public void ListaObreros()
		{
			foreach(Obrero o in empleados)
			{
				if (!o.TieneBonificacion())
				{
					o.ImprimirPropiedades();
				}
			
			}
		}
		
		//Listado de Jefes
		public void ListaJefes()
		{
			foreach(Obrero o in empleados)
			{
				if (o.TieneBonificacion())
				{
					o.ImprimirPropiedades();
				}
			
			}
		}
		
		//Agregar un Obrero
		public void agregarobrero()
		{
			Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingrese el DNI: ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de legajo: ");
            int legajo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cargo: ");
            string cargo = Console.ReadLine();

            Console.Write("Ingrese la bonificación: ");
            double bonificacion = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el código de la obra: ");
            int codigoObra = int.Parse(Console.ReadLine());
            Obrero nuevoObrero = new Obrero(nombre, apellido, dni, legajo, sueldo, cargo);
            empleados.Add(nuevoObrero);
			
		}
		
		/*public void agregarjefe()
		{
			Obrero nuevo_jefe = new jefe( //propiedades...);
			
			Console.Write("ingrese un nombre:");
			string a = Console.ReadLine();
			
			//crear uno para cada uno.
			empleados.add(nuevo_jefe);
			
		}*/
	}
}
