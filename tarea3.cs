using System; 
using System.Collections;

namespace Tarea3 { 
	class Principal {

		public Principal(){
			
		}
		
		
		public static void Main (string[] args)
		{
			Persona agenda= new Persona();    
			Persona persona = new Persona();
			persona.ingresarDatos(persona);
			agenda.ingresarCodigo();
			agenda.imprimeTodos();
			agenda.crearMyhashtable(persona);

		}
	}
}
