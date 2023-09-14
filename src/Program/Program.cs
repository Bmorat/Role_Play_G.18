using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elementos Varita = new Elementos("Libro_encantado", 20, 0);
            Elementos  Libro_encantado = new Elementos("Escudo", 0, 20);
            //creo 2 items con sus stats correspondientes.
            Mago Gandalf = new Mago("Gandalf", Libro_encantado, Varita);
            Mago Celestial = new Mago("Celestial", Libro_encantado, Libro_encantado);
            //creo 2 Mago y los equipo con 2 items cada uno.
    
            Console.WriteLine(Elementos.Activable_Item_Ataque("Super Libro_encantado", Libro_encantado));
            //uso un activable especial de la Libro_encantado y le subo 10 puntos de ataque.
            
            Console.WriteLine(Mago.Curar_Mago(Gandalf));
            //curo a Gandalf que ya tiene toda la vida para ver el mensaje correspondiente.

            Console.WriteLine(Mago.ObtenerAtaqueTotalEnano(Celestial));
            //checkeo el valor de ataque actual del enano pedro (40 de base + 30 de Libro_encantado potenciada + 30 de Libro_encantado potenciada).

            Console.WriteLine(Mago.Atacar_EnanotoEnano (Celestial, Gandalf));
            //Celestial ataca a Gandalf y lo mata porque tiene pedro tiene 100 de ataque y juan tiene 50 de vida y 50 de armadura.

            Console.WriteLine(Gandalf.SaludDinamica);
            //compruebo la cantidad de vida actual que tiene Gandalf

            Console.WriteLine(Mago.Curar_Mago(Gandalf));
            //curo a Gandalf

            Console.WriteLine(Gandalf.SaludDinamica);
            //compruebo la cantidad de vida actual que tiene Gandalf
            
        }

        
    }
}
