using System;

namespace TP_FINAL_ALGORITMOS
{
	/// <summary>
	/// Desctiption of Exception.
	/// </summary>
	public class ObrasException : Exception
	{
		public string motivo;
		
	 	public ObrasException(string msj)
		{
	 		this.motivo = "Hubo un error al operar sobre Obras: " + msj;
		}
	}
	
	public class ObrerosException : Exception
	{
		public string motivo;
		
	 	public ObrerosException(string msj)
		{
	 		this.motivo = "Hubo un error al operar sobre Obreros: " + msj;
		}
	}
	
	public class JefeException : Exception
	{
		public string motivo;
		
	 	public JefeException(string msj)
		{
	 		this.motivo = "Hubo un error al operar sobre Jefe: " + msj;
		}
	}
	
	public class GrupoObreroException : Exception
	{
		public string motivo;
		
	 	public GrupoObreroException(string msj)
		{
	 		this.motivo = "Hubo un error al operar sobre Grupo de Obreros: " + msj;
		}
	}
}