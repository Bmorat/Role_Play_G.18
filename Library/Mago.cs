using System;
using System.Collections.Generic;

namespace Role_Playgame
{
    public class Mago
    {
              
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Defensa {get ; set ;}
        public int Ataque {get ; set ;}
        public int Resistencia {get ; set ;}
        public int Magia {get ; set ;}
        private int VidaOriginal { get; set; }
        


        // Constructor
        public Mago(string nombre, int vida, int defensa, int ataque, int resistencia, int magia)
        {
            Nombre = nombre;
            Vida = vida;
            VidaOriginal = vida;
            Defensa = defensa;
            Ataque = ataque;
            Resistencia = resistencia;
            Magia = magia;
         }   
    

        public void Atacar(Mago NombreEnemigo)
        {
            Console.WriteLine($"{Nombre} esta atacando a {NombreEnemigo.Nombre}");
            NombreEnemigo.Vida -= Ataque; 
        }

         public void Defensas()
        {
            Console.WriteLine($"{Nombre} esta usando Defensa");
            Vida += (int)Defensa; 
        }

        public void Baston_magico()
        {
            Ataque *= 2 ;
            Defensa*= 2 ;
            Resistencia*=2;
            Magia *=2;
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
            //List hechizos = new List();
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
            Console.WriteLine($"El mago {Nombre} tiene de vida {Vida} ");
        }
        public void Curar()
        {
            Vida = VidaOriginal;
            Console.WriteLine("Recupero toda su vida");
        }

    }   
}
