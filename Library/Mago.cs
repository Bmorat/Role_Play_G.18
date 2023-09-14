using System;
using System.Collections.Generic;

namespace Role_Playgame
{
    public class Mago
    {
              
        public string Nombre { get; set; }
        public int Salud { get; set; }
        public int Armadura {get ; set ;}
        public int Ataque {get ; set ;}
        private int SaludOriginal { get; set; }
        


        // Constructor
        public Mago(string nombre, int salud, int armadura, int ataque)
        {
            Nombre = nombre;
            Salud = salud;
            SaludOriginal = Salud;
            Armadura = armadura;
            Ataque = ataque;
            
            
         }   
    

        public void Atacar(Mago NombreEnemigo)
        {
            Console.WriteLine($"{Nombre} esta atacando a {NombreEnemigo.Nombre}");
            NombreEnemigo.Salud -= Ataque; 
        }

         public void Armaduras()
        {
            Console.WriteLine($"{Nombre} esta usando Armadura");
            Salud += (int)Armadura; 
            if (Ataque < Armadura)
            {
                Salud = Salud;
            }
            else
            {
                Salud += (int)Armadura ;
            }
        }

        public void Baston_magico()
        {
            Ataque *= 2 ;
            Armadura*= 2 ;
            Console.WriteLine("Usando el Baston Magico,\n Poderes incrementados al doble ! ");
            
        }
        public void Varita_magica()
        {
            Console.WriteLine("Arma de la Varita Magica, poder de ataque aumentado en 10 puntos ");
            Ataque += 10 ;
        }

        public void Libro_hechizos()
        {
            //Lista de hechizos
            //
            List<string> miLista = new List<string>();
            miLista.Add("Nebulosa");
            miLista.Add("Encantos");
            miLista.Add("Fantastic");
            Console.WriteLine("Desea ver el libro de hechizos ? ");
            string respuesta = Console.ReadLine();
            if (respuesta == "Si" || respuesta == "si" || respuesta == "SI" )
            {
                foreach (string hechizoo in miLista)
                {
                    Console.WriteLine(hechizoo);
                }
            }
        }
        public void Situacion()
        {
            Console.WriteLine($"El mago {Nombre} tiene de Salud {Salud} ");
        }
        public void Curar()
        {
            Salud = SaludOriginal;
            Console.WriteLine("Recupero toda su Salud");
        }

    }   
}
