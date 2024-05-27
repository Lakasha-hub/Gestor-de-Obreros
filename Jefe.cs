using System;

namespace TP_FINAL_ALGORITMOS
{
	/// <summary>
	/// Description of Jefe.
	/// </summary>
	
	//Herencia de la clase padre Obrero
	public class Jefe : Obrero
	{
		//Propiedades
		private double bonificacion { get; set; }
		
		//Constructor
		public Jefe(string nombre, string apellido, int dni, int legajo, double sueldo, string cargo, double bonificacion): base (nombre, apellido, dni, legajo, sueldo, cargo)
		{
           this.bonificacion = bonificacion;
		}
		
		public override bool TieneBonificacion(){
			return true;
		}
		
		public override void ImprimirPropiedades(){
			Console.WriteLine("Nombre: " + nombre + " " + apellido + " || Dni: " + dni + " || Legajo: " + legajo + " || Bonificación: " + bonificacion );
		}
	}
}
