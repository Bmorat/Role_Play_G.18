using System;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)  
        {                    
            Elfo pj2 = new Elfo("Enzo");// defino un personaje de tipo Elfo y le asigno un nombre
            Item mascara = new Item("Mascara", 0, 20,0 );
            Item arco = new Item("Arco Maestro", 30,10,10);
            Item flecha = new Item("Flecha roja", 5,0,0);
            pj2.AddMano1(arco);//llamo al pj2 y le agrego un item a la mano1
            pj2.AddMano2(flecha);// hago lo mismo con la mano2
            Console.WriteLine(pj1.Mano1.GetItem());
            pj2.AddCasco(mascara);
            pj2.AtacarMago(pj1);
            Console.WriteLine($"{pj1.Vida} puntos de vida");// imprimo la vida del pj1 que previamente lo calcule en la clase Elfo
            pj2.CurarMago(pj1);// lo mismo con la curacion
            Console.WriteLine(pj2.Ataque);
            Console.WriteLine(pj2.DefensaTotal() + " defensa total");// al finalizar el juego, se puede ver que la defensa total es la suma de la defensa de cada item
            Console.WriteLine(pj2.AtaqueTotal() + " ataque total");// idem 
            Console.WriteLine(pj2.Vida + " vida total");// idem
        }        /* La mayoria de las explicaciones de los razonamientos tomados por el equipo se encuentran en la clase Mago, las cuales son similares para el resto de razas.
        A su vez, el elfo que es el unico capaz de curar tiene un comentario en su clase respectiva.*/
    }
}

