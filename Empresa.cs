using System;
using System.Collections;

namespace TP_FINAL_ALGORITMOS
{
	/// <summary>
	/// Description of Empresa.
	/// </summary>
	public class Empresa
	{
		//Propiedades de Empresa
		private ArrayList empleados;
		private ArrayList obras;
		private ArrayList gruposObreros;
		
		//Constructor de Empresa
		public Empresa()
		{
			this.empleados = new ArrayList();
			this.obras = new ArrayList();
			this.gruposObreros = new ArrayList();
		}
		
		//Get de propiedades de Empresa
		public ArrayList Empleados{ get{ return empleados; } }
		public ArrayList Obras{ get{ return obras; } }
		public ArrayList GruposObreros{ get{ return gruposObreros; } }
		
		/* METODOS DE EMPRESA */
		
		// Listado de Obras en curso
		public void ObrasEnCurso()
		{
			if(obras.Count == 0){
				Console.WriteLine("La empresa no realizó ninguna obra");
			}else{
				foreach (Obra o in obras)
				{
					if (o.EstadoAvance < 100)
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
					if (o.EstadoAvance == 100)
					{
						o.ImprimirPropiedades();
					}
				}
			}
			
		}
		
		//Porcentaje de obras en remodelacion
		public void PorcentajeObrasRemodelacion()
		{
			int totalObras = 0;
			int contadorObrasRemodelacion = 0;
			double porcentaje;
			
			foreach (Obra o in obras)
			{
				if (o.Tipo == "remodelacion")
				{
					contadorObrasRemodelacion++;
				}
				totalObras++;
			}
			porcentaje = (100 * contadorObrasRemodelacion) / totalObras;
			Console.WriteLine("Porcentaje de obras en remodelacion: " + porcentaje + "%");
		}
		
		// Modificar Porcentaje de Obra
		public void ModPorcentajeObra(int codigoObra, int porcentaje)
		{
			try {
				
				if(porcentaje > 100 || porcentaje < 0)
				{
					// Acá se lanza una excepción
					throw new ObrasException("El porcentaje debe ser un número entre 0 y 100");
				}
				
				//Busqueda de Obra
				foreach (Obra o in obras)
				{
					if (o.Codigo == codigoObra)
					{
						if(o.EstadoAvance == 100)
						{
							// Acá se lanza una excepción
							throw new ObrasException("No se puede modificar el estado de la obra por que se encuentra finalizada");
						}
						else
						{
							//Modificación del estado de avance de la Obra
							o.EstadoAvance = porcentaje;
							Console.WriteLine("Se modificó el estado de la obra correctamente");
						}
					}
				}
			} catch (ObrasException e) {
				Console.WriteLine(e.motivo);
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
		public void AgregarObrero(int nroGrupo, Obrero nuevoObrero)
		{
            //Se lo agrega a los empleados de la empresa
            empleados.Add(nuevoObrero);
            
            //Se lo agrega al grupo de obreros
            GrupoObrero grupo = (GrupoObrero)gruposObreros[nroGrupo - 1];
            grupo.AgregarObrero(nuevoObrero);
            Console.WriteLine("Se agrego al Obrero correctamente");
		}
		
		//Agregar un Jefe
		public void AgregarJefe(Obrero nuevoJefe)
		{
			try {
				//obraSinJefe indica que hay obras libres
				bool obraSinJefe = false;
				for(int i = 0; i < obras.Count; i++){
					Obra o = (Obra)obras[i];
					//Se asigna el nuevo Jefe a una obra sin Jefe
					if(o.DniJefe == 0)
					{
						obraSinJefe = true;
						o.DniJefe = nuevoJefe.Dni;
					}
				}
				
				//Si hay obras libres se contrata al Jefe
				if(obraSinJefe)
				{
					//Se agrega el nuevo Jefe a la Empresa
					empleados.Add(nuevoJefe);
					Console.WriteLine("Se contrato al Jefe correctamente");
				}else
				{
					throw new JefeException("No hay Obras disponibles para las cuales asignarle un nuevo Jefe");
				}
			} catch (JefeException e)
			{
				Console.WriteLine(e.motivo);
			}
			
		}
		
		//Eliminar un Obrero
		public void EliminarObrero(int dni)
		{
			try {
				bool obreroEliminadoDeEmpresa = false;
				bool obreroEliminadoDeGrupo = false;
				
				//Busqueda del obrero en empleados
				foreach(Obrero o in empleados)
				{
					if(o.Dni == dni)
					{
						//Se elimina al obrero de empleados
						empleados.Remove(o);
						obreroEliminadoDeEmpresa = true;
						break;
					}
				}
				
				//Busqueda del obrero en grupo de obreros
				foreach(GrupoObrero grupo in gruposObreros)
				{
					//Devuelve true si elimina al obrero del grupo
					obreroEliminadoDeGrupo = grupo.EliminarObrero(dni);
					if(obreroEliminadoDeGrupo)
					{
						break;
					}
				}
				
				//Respuesta al usuario
				if(obreroEliminadoDeEmpresa && obreroEliminadoDeGrupo)
				{
					Console.WriteLine("El Obrero ha sido eliminado correctamente");
				}else
				{
					throw new ObrerosException("No se encontro un obrero con el dni " + dni);
				}
			} catch (ObrerosException e) 
			{
				Console.WriteLine(e.motivo);
			}
		}
		
		//Eliminar un Jefe
		public void EliminarJefe(int dni)
		{
			try {
				
				bool jefeEliminadoDeEmpresa = false;
				bool jefeEliminadoDeObra = false;
				
				//Busqueda del Jefe en empleados
				foreach(Obrero o in empleados)
				{
					if(o.Dni == dni)
					{
						//Se elimina al Jefe de empleados
						empleados.Remove(o);
						jefeEliminadoDeEmpresa = true;
						break;
					}
				}
				
				//Busqueda del Jefe en las obras
				foreach(Obra o in obras)
				{
					if(o.DniJefe == dni)
					{
						//Se desvincula al Jefe de la Obra
						o.DniJefe = 0;
						jefeEliminadoDeObra = true;
						break;
					}
				}
				
				//Respuesta al usuario
				if(jefeEliminadoDeEmpresa && jefeEliminadoDeObra)
				{
					Console.WriteLine("El Jefe ha sido eliminado correctamente");
				}else
				{
					throw new JefeException("No se encontro un Jefe con el dni " + dni);
				}
			} catch (JefeException e) 
			{
				Console.WriteLine(e.motivo);
			}
		}
		
		//Agregar una Obra a empresa y Asignarle un Grupo de Obreros Libre
		public void AgregarObra(Obra nuevaObra){
			foreach(GrupoObrero g in gruposObreros){
				//Se busca un grupo libre
				if(g.Codigo == 0){
					//Se asigna el Grupo a la nueva Obra
					g.Codigo = nuevaObra.Codigo;
					//Se agrega a las Obras de la Empresa la nueva Obra
					obras.Add(nuevaObra);
					break;
				}
			}
		}
	}
}

