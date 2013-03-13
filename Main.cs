using System;
using System.Collections;

namespace Tarea3 { 
	public class Persona { 
		public String codigo; 
		public String nombre; 
		public String domicilio; 
		public String telefono; 
		public String face;
		
		public Persona(){
			this.codigo = "";
			this.nombre = "";
			this.domicilio = "";
			this.telefono = "";
			this.face = "";
		}
		
		Hashtable myhashtable = new Hashtable ();
		
		public void ingresarDatos(Persona persona){

			for (int i=0; i<=1; i++) {
				Console.WriteLine ("Ingresa los datos siguientes\n " );
				Console.WriteLine ("Ingresa el codigo");
				persona.codigo = Console.ReadLine ();
				Console.WriteLine ("Ingresa tu nombre:");
				persona.nombre = Console.ReadLine ();
				Console.WriteLine ("Ingresa tu domicilio:");
				persona.domicilio = Console.ReadLine ();
				Console.WriteLine ("Ingresa tu telefono:");
				persona.telefono = Console.ReadLine ();
				Console.WriteLine ("Ingresa tu facebook:");
				persona.face = Console.ReadLine ();
				Console.WriteLine (); 

				Console.WriteLine();
				Console.WriteLine("codigo: "+persona.codigo);
				Console.WriteLine();
				Console.WriteLine("nombre: "+persona.nombre);
				Console.WriteLine();
				Console.WriteLine("face: "+persona.face);
				Console.WriteLine();
				Console.WriteLine("domicilio: "+persona.domicilio);
				Console.WriteLine();
				Console.WriteLine("telefono: "+persona.telefono);
				Console.WriteLine();

				Console.Clear();
			}
		}
		
		public void crearMyhashtable(Persona persona){  
			myhashtable.Add(persona.codigo,persona);
			
		}
		
		
		public void ingresarCodigo(){
			Console.WriteLine("Introduce el codigo a buscar");
			string codig = Console.ReadLine();
			if(myhashtable.ContainsKey(codig) == true){         
				Persona persona = (Persona)this.myhashtable[codig];      
				Console.WriteLine("El codigo fue encontrado"); 
				persona.mostrarDatos(persona);    
				Console.ReadKey();  
				Console.Clear();
				Console.WriteLine("Quiere Eliminar este codigo? 0 = no,y, 1 = si");
				string opc = Console.ReadLine();
				if(opc != "0"){
					persona.editarDatos(persona);       
				}
				else{
					Console.Clear();
				}
				
			}
			else{
				Console.WriteLine("No a sido encontrado");
			}
		}
		
		
		
		
		public void editarDatos(Persona persona){

			myhashtable.Remove(persona);
			persona.ingresarDatos(persona);
			myhashtable.Add(persona.codigo,persona);
		}
		

		
		
		
		public void mostrarDatos(Persona persona){
			Console.WriteLine();
			Console.WriteLine("codigo: "+persona.codigo);
			Console.WriteLine();
			Console.WriteLine("nombre: "+persona.nombre);
			Console.WriteLine();
			Console.WriteLine("face: "+persona.face);
			Console.WriteLine();
			Console.WriteLine("domicilio: "+persona.domicilio);
			Console.WriteLine();
			Console.WriteLine("telefono: "+persona.telefono);
			Console.WriteLine();

			
		}
		
		
		
		public void imprimeTodos(){
			ICollection personas = this.myhashtable.Values;
			Console.WriteLine("Imprimiendo todo");
			foreach( object objeto in personas )
			{
				Persona persona = (Persona) objeto;
				this.mostrarDatos(persona);
			}   
		}
		
	}
}
