using System;

namespace TP_FINAL_ALGORITMOS
{
	class Program
	{
		public static void Main()
		{
            Menu();
		}
		
		//Función que ejecuta el menú y verifica que la opcion ingresada por el usuario es correcta
		public static void Menu()
		{
			Console.Clear();
			
			bool continuar = true;
			while(continuar)
			{
				bool opcion_correcta = false;
				while(!opcion_correcta)
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
		            	opcion_correcta = true;
		            	EjecutarOpcionMenuPrincipal(opcion);
		            }
				}
            }
		}
		
		//Función que ejecuta la opción enviada por parámetro
		public static void EjecutarOpcionMenuPrincipal(int opcion)
		{
			
			//Instancio la empresa para realizar las operaciones
			Empresa emp = new Empresa();
			
			switch(opcion)
			{
				//Agregar Obrero
        		case 1:
					Console.WriteLine("Se agregó al obrero correctamente");
					Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
					Console.Clear();
        			break;
        		//Eliminar Obrero
        		case 2:
        			Console.WriteLine("Se eliminó al obrero correctamente");
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        		//Contratar Jefe de Obra
        		case 3:
        			Console.WriteLine("Se contrató al jefe de obra correctamente");
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        		//Modificar el estado de avance de una obra
        		case 4:
        			Console.WriteLine("Se modificó el estado de la obra correctamente");
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        		//Dar de baja a un jefe
        		case 5:
        			Console.WriteLine("Se dió de baja al jefe correctamente");
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
        		//Submenú de listados
        		case 6:
        			SubmenuDeListados();
        			break;
        		
			}
		}
		
		public static void SubmenuDeListados()
		{
			Console.Clear();
			
			bool continuar = true;
			while(continuar)
			{
				bool opcion_correcta = false;
				while(!opcion_correcta)
				{
					Console.WriteLine("Menú de Listados");
				    Console.WriteLine("1. Listar Obreros");
				    Console.WriteLine("2. Listar Jefes");
				    Console.WriteLine("3. Listar Obras en ejecución");
				    Console.WriteLine("4. Listar Obras finalizadas");
				    Console.WriteLine("5. Porcentaje de obras de remodelación sin finalizar");
				    Console.WriteLine("0. Salir");
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
		            	opcion_correcta = true;
		            	EjecutarOpcionSubmenu(opcion);
		            }
				}
            }
		}
		
		//Función que ejecuta la opción enviada por parámetro del Submenú
		public static void EjecutarOpcionSubmenu(int opcion)
		{
			
			//Instancio la empresa para realizar las operaciones
			Empresa emp = new Empresa();
			
			switch(opcion)
			{
				//Listar Obreros
        		case 1:
					Console.WriteLine("Lista de obreros");
					Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
					Console.Clear();
        			break;
        		//Listar Jefes
        		case 2:
        			Console.WriteLine("Lista de Jefes");
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
        		//Porcentaje de obras de remodelación sin finalizar
        		case 5:
        			Console.WriteLine("Porcentaje de obras de remodelacion sin finalizar");
        			Console.Write("Presiona cualquier tecla para continuar . . .");
					Console.ReadKey(true);
        			Console.Clear();
        			break;
			}
		}
		
		public static void CrearGrupos()
		{
			//Crear los 8 grupos con el codigo de las distintas obras4
			Console.Write("Se crearon los 8 grupos correctamente");
		}
	}
}
