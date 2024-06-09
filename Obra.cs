using System;

namespace TP_FINAL_ALGORITMOS
{
	/// <summary>
	/// Description of Obra.
	/// </summary>
	public class Obra
	{
		//Propiedades de Obra
		public string nombre;
        public int dniPropietario;
        public int codigo;
        public string tipo;
        public int estadoAvance;
        public int dniJefe;
        public double costo;
        
		//Constructor de Obra
		public Obra(string nombre, int dniPropietario, int codigo, string tipo, int estadoAvance, double costo)
		{
			this.nombre = nombre;
			this.dniPropietario = dniPropietario;
			this.codigo = codigo;
			this.tipo = tipo;
			this.estadoAvance = estadoAvance;
			this.costo = costo;
			//Las obras se crean primeramente sin Jefe
			this.dniJefe = 0;
		}
		
		//Get y Set de las propiedades
		public string Nombre{ set{ nombre = value; } get{ return nombre; } }
		public int DniPropietario{ set{ dniPropietario = value; } get{ return dniPropietario; } }
		public int Codigo{ set{ codigo = value; } get{ return codigo; } }
		public string Tipo{ set{ tipo = value; } get{ return tipo; } }
		public int EstadoAvance{ set{ estadoAvance = value; } get{ return estadoAvance; } }
		public int DniJefe{ set{ dniJefe = value; } get{ return dniJefe; } }
		public double Costo{ set{ costo = value; } get{ return costo; } }
		
		/* METODOS DE OBRA */
		
		public void ImprimirPropiedades(){
			Console.WriteLine ("Nombre de Obra: " + nombre + " || Tipo de Obra: " + tipo + " || Estado de Avance: " + estadoAvance + " || Código de Obra: " + codigo);
		}
	}
}

