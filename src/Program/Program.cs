using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elementos Daga = new Elementos("Daga", 20, 0);
            Elementos Escudo = new Elementos("Escudo", 0, 20);
            //creo 2 items con sus stats correspondientes.
            Enanos Enano_Juan = new Enanos("Enano_Juan", Daga, Escudo);
            Enanos Enano_Pedro = new Enanos("Enano_Pedro", Daga, Daga);
            //creo 2 enanos y los equipo con 2 items cada uno.
    
            Console.WriteLine(Elementos.Activable_Item_Ataque("Super Daga", Daga));
            //uso un activable especial de la daga y le subo 10 puntos de ataque.
            
            Console.WriteLine(Enanos.CurarEnano(Enano_Juan));
            //curo a enano_juan que ya tiene toda la vida para ver el mensaje correspondiente.

            Console.WriteLine(Enanos.ObtenerAtaqueTotalEnano(Enano_Pedro));
            //checkeo el valor de ataque actual del enano pedro (40 de base + 30 de daga potenciada + 30 de daga potenciada).

            Console.WriteLine(Enanos.Atacar_EnanotoEnano (Enano_Pedro, Enano_Juan));
            //enano_pedro ataca a enano_juan y lo mata porque tiene pedro tiene 100 de ataque y juan tiene 50 de vida y 50 de armadura.

            Console.WriteLine(Enano_Juan.SaludDinamica);
            //compruebo la cantidad de vida actual que tiene enano_juan

            Console.WriteLine(Enanos.CurarEnano(Enano_Juan));
            //curo a enano_juan

            Console.WriteLine(Enano_Juan.SaludDinamica);
            //compruebo la cantidad de vida actual que tiene enano_juan
            
        }

        
    }
}
