using System;
using System.Collections;

namespace TP_FINAL_ALGORITMOS
{
	/// <summary>
	/// Description of Obrero.
	/// </summary>
	public class Obrero
	{
		//Propiedades
		protected string nombre { get; set; }
		protected string apellido { get; set; }
		protected int dni { get; set; }
		protected int legajo { get; set; }
		protected double sueldo { get; set; }
		protected string cargo { get; set; }
		
		//Constructor
		public Obrero(string nombre, string apellido, int dni, int legajo, double sueldo, string cargo)
		{
			this.nombre = nombre;
			this.apellido = apellido;
            this.dni = dni;
            this.legajo = legajo;
            this.sueldo = sueldo;
            this.cargo = cargo;
			
		}
		
		//Metodo que indica si tiene bonificación, en caso de los obreros no.
		public virtual bool TieneBonificacion()
		{
			return false;
		}
		
		public virtual void ImprimirPropiedades(){
			Console.WriteLine("Nombre: " + nombre + " " + apellido + " || Dni: " + dni + " || legajo: " + legajo );
		}
	}
}

