using System;
using System.Collections;

namespace TP_FINAL_ALGORITMOS
{
	class Program
	{
		public static void Main()
		{
			//Se instancia la Empresa para realizar las operaciones
			Empresa emp = new Empresa();
			//Se crean 8 grupos por defecto
			CrearGrupos(emp);
			//Se crean 8 obras por defecto
			CrearObras(emp);
			//Se ejecuta el menú
            Menu(emp);
		}
		
		//Función que ejecuta el menú y verifica que la opcion ingresada por el usuario es correcta
		public static void Menu(Empresa emp)
		{
			//Limpiar Consola
			Console.Clear();
			
			//continuar indica que el usuario quiere seguir utilizando el programa, osea la opcion es != 0.
			bool continuar = true;
			while(continuar)
			{
				//opcionCorrecta indica que la opcion se encuentra entre las opciones posibles (0 a 6)
				bool opcionCorrecta = false;
				while(!opcionCorrecta)
				{
					Console.WriteLine("Menú Principal");
				    Console.WriteLine("1. Contratar un nuevo obrero");
				    Console.WriteLine("2. Eliminar a un obrero");
				    Console.WriteLine("3. Contratar a un jefe de obra");
				    Console.WriteLine("4. Modificar el estado de avance de una obra");
				    Console.WriteLine("5. Dar de baja a un jefe");
				    Console.WriteLine("6. Submenú de listados");
				    Console.WriteLine("0. Salir");
				    Console.WriteLine("");
				    
				    int opcion;
		            Console.WriteLine("Ingrese una opción: ");
		            opcion = int.Parse(Console.ReadLine());
		            
		            if(opcion < 0 || opcion > 6)
		            {
		            	//Si la opción excede los limites de opciones (de 0 a 6), se solicita ingresar la opción nuevamente
		            	Console.WriteLine("Opción no válida, ingrese nuevamente una opción");
		            	
		            	Console.Write("Presiona cualquier tecla para continuar . . .");
						Console.ReadKey(true);
						Console.Clear();
						
		            } else if(opcion == 0)
		            {
		            	//Si la opción es igual a cero se finaliza el programa
		            	continuar = false;
		            	break;
					}
		            else
		            {
		            	//Si la opción es correcta(de 1 a 6) se ejecuta esa opcion
		            	opcionCorrecta = true;
		            	EjecutarOpcionMenuPrincipal(emp, opcion);
		            }
				}
            }
		}
		
		//Función que ejecuta la opción enviada por parámetro
		public static void EjecutarOpcionMenuPrincipal(Empresa emp, int opcion)
		{	
			string nombre, apellido, cargo;
			int dni, legajo, codigoObra, porcentaje, nroGrupo;
			double sueldo, bonificacion;
			
			switch(opcion)
			{
				//Agregar Obrero
        		case 1:
					//Se solicitan los datos que forman a un obrero
					Console.Write("Ingrese el nombre: ");
		            nombre = Console.ReadLine();
		
		            Console.Write("Ingrese el apellido: ");
		            apellido = Console.ReadLine();
		
		            Console.Write("Ingrese el DNI: ");
		            dni = int.Parse(Console.ReadLine());
		
		            Console.Write("Ingrese el número de legajo: ");
		            legajo = int.Parse(Console.ReadLine());
		
		            Console.Write("Ingrese el sueldo: ");
		            sueldo = double.Parse(Console.ReadLine());
		
		            Console.Write("Ingrese el cargo: ");
		            cargo = Console.ReadLine();
		            
		            //Se solicita además el grupo al que se desea agregarlo
		            Console.Write("Ingrese el número de grupo al que desea agregarlo: ");
		            nroGrupo = int.Parse(Console.ReadLine());
		            
		            //Se crea el nuevo obrero
		            Obrero nuevoObrero = new Obrero(nombre, apellido, dni, legajo, sueldo, cargo);
		            
		            //Se agrega al obrero a la empresa y al numero de grupo enviado por parametro
					emp.AgregarObrero(nroGrupo, nuevoObrero);
					
					Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
					Console.Clear();
        			break;
        		
        		//Eliminar Obrero
        		case 2:
	        		//Se solicita el dni del obrero a eliminar
					Console.WriteLine("Ingrese el dni del obrero a eliminar: ");
					dni = int.Parse(Console.ReadLine());
					
        			//Se elimina al Obrero de la empresa y de su grupo
        			emp.EliminarObrero(dni);
        			
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        		
        		//Contratar Jefe de Obra
        		case 3:
        			//Se solicitan los datos que forman a un jefe
				    Console.Write("Ingrese el nombre: ");
		            nombre = Console.ReadLine();
		
		            Console.Write("Ingrese el apellido: ");
		            apellido = Console.ReadLine();
		
		            Console.Write("Ingrese el DNI: ");
		            dni = int.Parse(Console.ReadLine());
		
		            Console.Write("Ingrese el número de legajo: ");
		            legajo = int.Parse(Console.ReadLine());
		
		            Console.Write("Ingrese el sueldo: ");
		            sueldo = double.Parse(Console.ReadLine());
		
		            Console.Write("Ingrese la bonificación: ");
		            bonificacion = double.Parse(Console.ReadLine());
					
		            //Se crea al nuevo jefe
					Obrero nuevoJefe = new Jefe(nombre, apellido, dni, legajo, sueldo, bonificacion);
					
					//Se agrega al jefe a la empresa y se lo agrega a una obra libre
        			emp.AgregarJefe(nuevoJefe);
        			
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        		
        		//Modificar el estado de avance de una Obra
        		case 4:
        			
        			//Se solicita el código de la Obra y el porcentaje que se desea modificar
        			Console.WriteLine("Ingrese el código de Obra a modificar: ");
        			codigoObra = int.Parse(Console.ReadLine());

        			Console.WriteLine("Ingrese el porcentaje: ");
        			porcentaje = int.Parse(Console.ReadLine());
        			
        			//Se modifica el estado de avance de la Obra
        			emp.ModPorcentajeObra(codigoObra, porcentaje);
        			
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        		
        		//Dar de baja a un Jefe
        		case 5:
	        		//Se solicita el dni del Jefe a eliminar
					Console.WriteLine("Ingrese el dni del jefe a eliminar: ");
					dni = int.Parse(Console.ReadLine());
					
        			//Se elimina al jefe de la Empresa y se lo desvincula de la Obra
        			emp.EliminarJefe(dni);
        			
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        			
        		//Submenú de listados
        		case 6:
        			SubmenuDeListados(emp);
        			break;
        		
			}
		}
		
		public static void SubmenuDeListados(Empresa emp)
		{
			//Limpiar Consola
			Console.Clear();
			
			//continuar indica que el usuario quiere seguir utilizando el programa, osea la opcion es != 0.
			bool continuar = true;
			while(continuar)
			{
				//opcionCorrecta indica que la opcion se encuentra entre las opciones posibles (0 a 5)
				bool opcionCorrecta = false;
				while(!opcionCorrecta)
				{
					Console.WriteLine("Menú de Listados");
				    Console.WriteLine("1. Listar Obreros");
				    Console.WriteLine("2. Listar Jefes");
				    Console.WriteLine("3. Listar Obras en ejecución");
				    Console.WriteLine("4. Listar Obras finalizadas");
				    Console.WriteLine("5. Porcentaje de obras de remodelación");
				    Console.WriteLine("0. Volver al menú principal");
				    Console.WriteLine("");
				    
				    int opcion;
		            Console.WriteLine("Ingrese una opción: ");
		            opcion = int.Parse(Console.ReadLine());
		            
		            if(opcion < 0 || opcion > 5)
		            {
		            	//Si la opción excede los limites de opciones (de 0 a 5), se solicita ingresar la opción nuevamente
		            	Console.WriteLine("Opción no válida, ingrese nuevamente una opción");
		            	
		            	Console.Write("Presiona cualquier tecla para continuar . . .");
						Console.ReadKey(true);
						Console.Clear();
						
		            } else if(opcion == 0)
		            {
		            	//Si la opción es igual a cero se vuelve al menú original
		            	continuar = false;
        				Console.Clear();
		            	break;
					}
		            else
		            {
		            	//Si la opción es correcta(de 1 a 5) se ejecuta esa opcion
		            	opcionCorrecta = true;
		            	EjecutarOpcionSubmenu(emp, opcion);
		            }
				}
            }
		}
		
		//Función que ejecuta la opción enviada por parámetro del Submenú
		public static void EjecutarOpcionSubmenu(Empresa emp, int opcion)
		{
			
			switch(opcion)
			{
				//Listar Obreros
        		case 1:
					emp.ListaObreros();
					Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
					Console.Clear();
        			break;
        			
        		//Listar Jefes
        		case 2:
        			emp.ListaJefes();
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        			
        		//Listar Obras en ejecución
        		case 3:
        			emp.ObrasEnCurso();
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        			
        		//Listar Obras finalizadas
        		case 4:
        			emp.ObrasFinalizadas();
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        			
        		//Porcentaje de obras de remodelación
        		case 5:
        			emp.PorcentajeObrasRemodelacion();
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
			}
		}
		
		//Crea los grupos y los agrega a empresa
		public static void CrearGrupos(Empresa emp)
		{
			for(int i = 0; i < 8; i++)
			{
				//Se crean 8 grupos por defecto sin ninguna Obra asignada
				GrupoObrero nuevoGrupo = new GrupoObrero(0, i + 1);
				emp.GruposObreros.Add(nuevoGrupo);
			}
		}
		
		//Crea las obras y las agrega a Empresa
		public static void CrearObras(Empresa emp)
		{
			//Cuando se crean las obras se les asigna un grupo disponible automaticamente
			Obra obra1 = new Obra("Farmacia", 7777789, 200, "construccion", 0, 10000000);
			emp.AgregarObra(obra1);
			
			Obra obra2 = new Obra("Gimnasio", 45845300, 250, "ampliacion", 50, 15000000);
			emp.AgregarObra(obra2);
			
			Obra obra3 = new Obra("Hotel", 55647890, 230, "remodelacion", 0, 20000000);
			emp.AgregarObra(obra3);
			
			Obra obra4 = new Obra("Edificio", 78040033, 220, "construccion", 20, 25000000);
			emp.AgregarObra(obra4);
			
			Obra obra5 = new Obra("Estadio", 23456777, 210, "remodelacion",70, 30000000);
			emp.AgregarObra(obra5);
			
			Obra obra6 = new Obra("Taller mecanico", 98732542, 206, "ampliacion", 65, 2000000);
			emp.AgregarObra(obra6);
			
			Obra obra7 = new Obra("Parrilla", 23456123, 232, "remodelacion", 35, 1504500);
			emp.AgregarObra(obra7);
			
			Obra obra8 = new Obra("Hospital", 9121831, 209, "construccion", 0, 23450234);
			emp.AgregarObra(obra8);
		}
		
		
	}
}
