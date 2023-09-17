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
            
            Console.WriteLine(Curaciones.Curar_Enano(Enano_Juan));
            //curo a enano_juan que ya tiene toda la vida para ver el mensaje correspondiente.

            Console.WriteLine(ObtenerPoints.ObtenerAtaqueTotalEnano(Enano_Pedro));
            //checkeo el valor de ataque actual del enano pedro (40 de base + 30 de daga potenciada + 30 de daga potenciada).

            Console.WriteLine(Ataques.Atacar_EnanotoEnano (Enano_Pedro, Enano_Juan));
            //enano_pedro ataca a enano_juan y lo mata porque tiene pedro tiene 100 de ataque y juan tiene 50 de vida y 50 de armadura.

            Console.WriteLine(Enano_Juan.SaludDinamica);
            //compruebo la cantidad de vida actual que tiene enano_juan

            Console.WriteLine(Curaciones.Curar_Enano(Enano_Juan));
            //curo a enano_juan

            Console.WriteLine(Enano_Juan.SaludDinamica);
            //compruebo la cantidad de vida actual que tiene enano_juan
            

            Elementos LibroDeHechizos = new Elementos("LibroDeHechizos", 25, 0);
            Elementos BaculoMagico = new Elementos("BaculoMagico", 10, 10);
            //creo 2 items para los magos

            Elementos PolvoMagico = new Elementos("PolvoMagico", 15, 10);
            Elementos BotasMisticas = new Elementos("BotasMisticas", 0, 30);
            //creo 2 items para los elfos

            Magos Mago_Alfonso = new Magos("Mago_Alfonso", LibroDeHechizos, BaculoMagico);
            Magos Maga_Maca = new Magos("Maga_Maca", BaculoMagico, BaculoMagico);
            //creo 2 magos y le asigno los items que les corresponden

            Elfos Elfo_Brian = new Elfos("Elfo_Brian", PolvoMagico, BotasMisticas);
            Elfos Elfa_Jime = new Elfos("Elfa_Jime", BotasMisticas, BotasMisticas);
            //creo 2 elfos y le asigno los items que les corresponden

            Console.WriteLine(Elementos.Activable_Item_Armadura("Armadurus espeliatus", LibroDeHechizos));
            //uso el activable para aumentarle la armadura al libro de hechizos por 10 puntos.
            Console.WriteLine(ObtenerPoints.ObtenerArmaduraMago(Mago_Alfonso));
            //uso el metodo para obtener la armadura total de Mago_Alfonso y suma la base (30) + el activable del armadura (10) + la armadura del baculo (10).

            Console.WriteLine(Ataques.Atacar_MagotoMago(Maga_Maca, Mago_Alfonso));
            //maga maca tiene 40 de ataque de base + 20 de items (2 baculos magicos)
            //mago alfonso tiene 50 total de armadura (lo vimos con la funcion) y 50 de vida.
        }
    }
}
