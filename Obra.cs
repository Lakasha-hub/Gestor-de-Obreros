using System;

namespace TP_FINAL_ALGORITMOS
{
	/// <summary>
	/// Description of Obra.
	/// </summary>
	public class Obra
	{
		//Propiedades
        public string nombre { get; set; }
        public int dni { get; set; }
        public int cod_interno { get; set; }
        public string tipo_obra { get; set; }
        public int estado_avance { get; set; }
        public string jefe_obra { get; set; }
        public double costo { get; set; }
        
		//Constructor
		public Obra(string nombre, int dni, int cod_interno, string tipo_obra, int estado_avance, string jefe_obra, double costo)
		{
			this.nombre=nombre;
			this.dni=dni;
			this.cod_interno=cod_interno;
			this.estado_avance=estado_avance;
			this.costo=costo;
		}
		
		public void ImprimirPropiedades(){
			Console.WriteLine ("Obra: " + nombre + " avance: " + estado_avance + " código: " + cod_interno);
		}
	}
}
