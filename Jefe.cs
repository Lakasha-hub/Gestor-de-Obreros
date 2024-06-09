using System;

namespace TP_FINAL_ALGORITMOS
{
	/// <summary>
	/// Description of Jefe.
	/// </summary>
	
	//Herencia de la clase padre Obrero
	public class Jefe : Obrero
	{
		//Propiedades de Jefe
		private double bonificacion;
		
		//Constructor de Jefe, la propiedad cargo de Jefe siempre será "Jefe de Obra" por lo cual se lo envía directamente al constructor de Obrero
		public Jefe(string nombre, string apellido, int dni, int legajo, double sueldo, double bonificacion): base (nombre, apellido, dni, legajo, sueldo, "Jefe de Obra")
		{
           this.bonificacion = bonificacion;
		}
		
		//Get y Set de las propiedades
		public double Bonificacion{ set{ bonificacion = value; } get{ return bonificacion; } }
		
		/* METODOS DE JEFE */
		
		//Metodo que indica si tiene bonificación, en caso de los jefes si.
		public override bool TieneBonificacion(){
			return true;
		}
		
		public override void ImprimirPropiedades(){
			Console.WriteLine("Nombre: " + nombre + " " + apellido + " || Dni: " + dni + " || Legajo: " + legajo + " || Bonificación: " + bonificacion );
		}
	}
}

