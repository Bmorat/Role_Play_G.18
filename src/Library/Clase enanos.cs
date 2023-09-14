
namespace Library
{
    public class Enanos //creo la clase enanos para que al generar objetos se trate de un enano mas
    {
        public int SaludDinamica {get; set;} = 50; //valor predeterminado de cada enano.
        public int SaludBase {get;} = 50;
        public int AtaqueBase {get; set;} = 40; //valor predeterminado de cada enano.
        public int ArmaduraBase {get; set;} = 30;
        public int ArmaduraDinamica {get; set;} = 30;
        public int AtaqueDinamico {get; set;} = 40;
        public string Nombre {get; set;}
        public Elementos Item_1 {get; set;}
        public Elementos Item_2 {get; set;}

        public Enanos (string nombre, Elementos item1, Elementos item2)
        {
            this.Item_1 = item1;
            this.Item_2 = item2;
            this.Nombre = nombre;
            this.ArmaduraDinamica += item1.ArmaduraDinamicaItem;
            this.ArmaduraDinamica += item2.ArmaduraDinamicaItem;
            this.AtaqueDinamico += item1.AtaqueDinamicoItem;
            this.AtaqueDinamico += item2.AtaqueDinamicoItem;
        }

        public static string ObtenerAtaqueTotalEnano(Enanos enano_en_cuestion)
        {
            //bloque de actualizacion de ataque en caso de que se hayan usado activables en items.
            enano_en_cuestion.AtaqueDinamico = 0;
            enano_en_cuestion.AtaqueDinamico += (enano_en_cuestion.Item_1.AtaqueDinamicoItem + enano_en_cuestion.AtaqueBase + enano_en_cuestion.Item_2.AtaqueDinamicoItem);
            return $"El ataque total de {enano_en_cuestion.Nombre} (incluyendo items) es de {enano_en_cuestion.AtaqueDinamico} puntos";
        }

        public static string ObtenerArmaduraTotalEnano(Enanos enano_en_cuestion)
        {
            //bloque de actualizacion de armadura en caso de que se hayan usado activables en items.
            enano_en_cuestion.ArmaduraDinamica = 0;
            enano_en_cuestion.ArmaduraDinamica += (enano_en_cuestion.Item_1.ArmaduraDinamicaItem + enano_en_cuestion.ArmaduraBase + enano_en_cuestion.Item_2.ArmaduraDinamicaItem);
            return $"La armadura total de {enano_en_cuestion.Nombre} (incluyendo items) es de {enano_en_cuestion.ArmaduraDinamica} puntos";
        }

        public static string CurarEnano(Enanos enano_en_cuestion)
        {
            if (enano_en_cuestion.SaludDinamica < enano_en_cuestion.SaludBase)
            {  
                enano_en_cuestion.SaludDinamica = enano_en_cuestion.SaludBase;
                return $"¡{enano_en_cuestion.Nombre} ha sido curado y posee nuevamente {enano_en_cuestion.SaludBase} puntos de vida!";
            }
            else
            {
                return $"¡{enano_en_cuestion.Nombre} ya está full vida!";
            }
        }

        public static string Atacar_EnanotoEnano (Enanos enano1, Enanos enano2)
        {
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            enano2.ArmaduraDinamica = 0;
            enano2.AtaqueDinamico = 0;
            enano2.ArmaduraDinamica += (enano2.Item_1.ArmaduraDinamicaItem + enano2.ArmaduraBase + enano2.Item_2.ArmaduraDinamicaItem);
            enano2.AtaqueDinamico += (enano2.Item_1.AtaqueDinamicoItem + enano2.AtaqueBase + enano2.Item_2.AtaqueDinamicoItem);
           
            //mismo bloque de actualizacion para el enano 1.
            enano1.ArmaduraDinamica = 0;
            enano1.AtaqueDinamico = 0;
            enano1.ArmaduraDinamica += (enano1.Item_1.ArmaduraDinamicaItem + enano1.ArmaduraBase + enano1.Item_2.ArmaduraDinamicaItem);
            enano1.AtaqueDinamico += (enano1.Item_1.AtaqueDinamicoItem + enano1.AtaqueBase + enano1.Item_2.AtaqueDinamicoItem);
            
            if (enano2.ArmaduraDinamica >= enano2.AtaqueDinamico) //checkeo si la armadura del enano acatado es mayor o igual que el ataque del enano atacante.
            {
                return $"{enano1.Nombre} no le ha sacado vida a {enano2.Nombre} por la fortaleza de su armadura";
                //si es mayor o igual imprimo en consola que el atacante no le saca vida al atacado por su armadura.
            }
            else 
            {
                //de lo contrario, cubro la vida base del enano atacado con la armadura y le resto la vida que no cubra la armadura.
                int vida_restante = (enano2.SaludBase + enano2.ArmaduraDinamica) - enano1.AtaqueDinamico;
                enano2.SaludDinamica = vida_restante; //actualizo la salud del enano atacado.
                if (vida_restante <= 0) //checkeo si la vida es 0 o menos.
                {
                    return $"{enano2.Nombre} fue asesinado por {enano1.Nombre}";
                    //si es 0 o menos imprimo el mensaje de que el atacado fue asesinado.
                }
                else 
                {   
                    //de lo contrario imprimo en consola la cantidad de vida que le quito el enano atacante calculando el resto de la armadura menos el ataque.
                    return $"{enano1.Nombre} le ha quitado {-(enano2.ArmaduraDinamica - enano1.AtaqueDinamico)} puntos de vida a {enano2.Nombre}";
                }
            }
        }

        /*public string Atacar_EnanotoMago (Enanos enano1, Mago mago)
        {
            if 
            return "Ha atacado a tal";
        }

        public string Atacar_EnanotoElfo (Enanos enano1, Elfos elfo)
        {
            if 
            return "Ha atacado a tal";
        }*/
    }
}