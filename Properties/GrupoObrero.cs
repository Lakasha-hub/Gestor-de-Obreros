using System;
using System.Collections;

namespace TP_FINAL_ALGORITMOS.Properties
{
	/// <summary>
	/// Description of GrupoObrero.
	/// </summary>
	public class GrupoObrero
	{
		private string codigo { get; set; }
		private int nrogrupo { get; set; }
		private ArrayList obreros { get; set; }
		
	    //constructor
		public GrupoObrero(string codigo, int nrogrupo)
		{
			this.nrogrupo = nrogrupo;
			this.codigo = codigo;
			this.obreros = new ArrayList();
		}
	}
}
