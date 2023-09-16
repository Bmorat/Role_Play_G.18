
namespace Library
{
    public class Mago 
    {
        public int SaludDinamica {get; set;} = 50; 
        public int SaludBase {get;} = 50;
        public int AtaqueBase {get; set;} = 40; 
        public int ArmaduraBase {get; set;} = 30;
        public int ArmaduraDinamica {get; set;} = 30;
        public int AtaqueDinamico {get; set;} = 40;
        public string Nombre {get; set;}
        public Elementos Item_1 {get; set;}
        public Elementos Item_2 {get; set;}

        public Mago (string nombre, Elementos item1, Elementos item2)
        {
            this.Item_1 = item1;
            this.Item_2 = item2;
            this.Nombre = nombre;
            this.ArmaduraDinamica += item1.ArmaduraDinamicaItem;
            this.ArmaduraDinamica += item2.ArmaduraDinamicaItem;
            this.AtaqueDinamico += item1.AtaqueDinamicoItem;
            this.AtaqueDinamico += item2.AtaqueDinamicoItem;
        }

        public static string ObtenerAtaqueTotalEnano(Mago Mago_cuestion)
        {
            
            Mago_cuestion.AtaqueDinamico = 0;
            Mago_cuestion.AtaqueDinamico += (Mago_cuestion.Item_1.AtaqueDinamicoItem + Mago_cuestion.AtaqueBase + Mago_cuestion.Item_2.AtaqueDinamicoItem);
            return $"El ataque total de {Mago_cuestion.Nombre} (incluyendo items) es de {Mago_cuestion.AtaqueDinamico} puntos";
        }

        public static string ObtenerArmaduraMago(Mago Mago_cuestion)
        {
            
            Mago_cuestion.ArmaduraDinamica = 0;
            Mago_cuestion.ArmaduraDinamica += (Mago_cuestion.Item_1.ArmaduraDinamicaItem + Mago_cuestion.ArmaduraBase + Mago_cuestion.Item_2.ArmaduraDinamicaItem);
            return $"La armadura total de {Mago_cuestion.Nombre} (incluyendo items) es de {Mago_cuestion.ArmaduraDinamica} puntos";
        }

        public static string Curar_Mago(Mago Mago_cuestion)
        {
            if (Mago_cuestion.SaludDinamica < Mago_cuestion.SaludBase)
            {  
                Mago_cuestion.SaludDinamica = Mago_cuestion.SaludBase;
                return $"¡{Mago_cuestion.Nombre} ha sido curado y posee nuevamente {Mago_cuestion.SaludBase} puntos de vida!";
            }
            else
            {
                return $"¡{Mago_cuestion.Nombre} ya está full vida!";
            }
        }

        public static string Atacar_EnanotoEnano (Mago Mago_1, Mago Mago_2)
        {
            
            Mago_2.ArmaduraDinamica = 0;
            Mago_2.AtaqueDinamico = 0;
            Mago_2.ArmaduraDinamica += (Mago_2.Item_1.ArmaduraDinamicaItem + Mago_2.ArmaduraBase + Mago_2.Item_2.ArmaduraDinamicaItem);
            Mago_2.AtaqueDinamico += (Mago_2.Item_1.AtaqueDinamicoItem + Mago_2.AtaqueBase + Mago_2.Item_2.AtaqueDinamicoItem);
           
            Mago_1.ArmaduraDinamica = 0;
            Mago_1.AtaqueDinamico = 0;
            Mago_1.ArmaduraDinamica += (Mago_1.Item_1.ArmaduraDinamicaItem + Mago_1.ArmaduraBase + Mago_1.Item_2.ArmaduraDinamicaItem);
            Mago_1.AtaqueDinamico += (Mago_1.Item_1.AtaqueDinamicoItem + Mago_1.AtaqueBase + Mago_1.Item_2.AtaqueDinamicoItem);
            
            if (Mago_2.ArmaduraDinamica >= Mago_2.AtaqueDinamico) 
            {
                return $"{Mago_1.Nombre} no le ha sacado vida a {Mago_2.Nombre} por la fortaleza de su armadura";
                
            }
            else 
            {
                
                int vida_restante = (Mago_2.SaludBase + Mago_2.ArmaduraDinamica) - Mago_1.AtaqueDinamico;
                Mago_2.SaludDinamica = vida_restante;
                if (vida_restante <= 0) 
                {
                    return $"{Mago_2.Nombre} fue asesinado por {Mago_1.Nombre}";                   
                }
                else 
                {   
                    return $"{Mago_1.Nombre} le ha quitado {-(Mago_2.ArmaduraDinamica - Mago_1.AtaqueDinamico)} puntos de vida a {Mago_2.Nombre}";
                }
            }
        }

        /*public string Atacar_EnanotoMago (Mago Mago_1, Mago mago)
        {
            if 
            return "Ha atacado a tal";
        }

        public string Atacar_EnanotoElfo (Mago Mago_1, Elfos elfo)
        {
            if 
            return "Ha atacado a tal";
        }*/
    }
}