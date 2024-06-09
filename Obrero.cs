using System;

namespace TP_FINAL_ALGORITMOS
{
	/// <summary>
	/// Description of Obrero.
	/// </summary>
	public class Obrero
	{
		//Propiedades de Obrero
		protected string nombre;
		protected string apellido;
		protected int dni;
		protected int legajo;
		protected double sueldo;
		protected string cargo;
		
		//Constructor de Obrero
		public Obrero(string nombre, string apellido, int dni, int legajo, double sueldo, string cargo)
		{
			this.nombre = nombre;
			this.apellido = apellido;
            this.dni = dni;
            this.legajo = legajo;
            this.sueldo = sueldo;
            this.cargo = cargo;
		}
		
		//Get y Set de las propiedades
		public string Nombre{ set{ nombre = value; } get{ return nombre; } }
		public string Apellido{ set{ apellido = value; } get{ return apellido; } }
		public int Dni{ set{ dni = value; } get{ return dni; } }
		public int Legajo{ set{ legajo = value; } get{ return legajo; } }
		public double Sueldo{ set{ sueldo = value; } get{ return sueldo; } }
		public string Cargo{ set{ cargo = value; } get{ return cargo; } }
		
		/* METODOS DE OBRERO */
		
		//Metodo que indica si tiene bonificación, en caso de los obreros no.
		public virtual bool TieneBonificacion()
		{
			return false;
		}
		
		public virtual void ImprimirPropiedades(){
			Console.WriteLine("Nombre: " + nombre + " " + apellido + " || Dni: " + dni + " || Legajo: " + legajo );
		}
	}
}

