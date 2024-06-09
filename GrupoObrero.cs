using System;
using System.Collections;

namespace TP_FINAL_ALGORITMOS
{
	/// <summary>
	/// Description of GrupoObrero.
	/// </summary>
	public class GrupoObrero
	{
		//Propiedades de GrupoObrero
		private int codigo;
		private int nroGrupo;
		private ArrayList obreros;
		
	    //Constructor de GrupoObrero
		public GrupoObrero(int codigo, int nroGrupo)
		{
			this.nroGrupo = nroGrupo;
			this.codigo = codigo;
			this.obreros = new ArrayList();
		}
		
		//Get y Set de las propiedades
		public int Codigo{ set{ codigo = value; } get{ return codigo; } }
		public int NroGrupo{ set{ nroGrupo = value; } get{ return nroGrupo; } }
		public ArrayList Obreros{ get{ return obreros; } }
		
		
		/* METODOS DE GRUPO OBRERO */
		
		public void imprimirObreros(){
			foreach(Obrero o in obreros){
				o.ImprimirPropiedades();
			}
		}
		
		public void AgregarObrero(Obrero o)
		{
			obreros.Add(o);
		}
		
		public bool EliminarObrero(int dni){
			//Busqueda del obrero
			bool obreroEliminado = false;
			foreach(Obrero o in obreros)
			{
				if(o.Dni == dni)
				{
					//Se elimina al obrero del grupo de obreros
					obreros.Remove(o);
					obreroEliminado = true;
					return obreroEliminado;
				}
			}
			return obreroEliminado;
		}
	}
}
