using System;

namespace Library
{
    public class Elementos
    {
       public string NombreItem {get; set;}
        public int AtaqueBaseItem {get; set;} 
        public int ArmaduraBaseItem {get; set;}
        public int AtaqueDinamicoItem {get; set;} 
        public int ArmaduraDinamicaItem {get; set;}
        public Elementos (string nombreItem, int ataqueItem, int armaduraItem)
        {
            this.NombreItem = nombreItem;
            this.AtaqueBaseItem = ataqueItem;
            this.ArmaduraBaseItem = armaduraItem;
            this.AtaqueDinamicoItem = AtaqueBaseItem;
            this.ArmaduraDinamicaItem = ArmaduraBaseItem;
        }

        public static string Activable_Item_Ataque(string nombre_habilidad, Elementos item)
        {
            item.AtaqueDinamicoItem += 10;
            return $"El ataque del item {item.NombreItem} ha aumentado por 10 puntos gracias a la habilidad {nombre_habilidad}!";
        }
        public static string Activable_Item_Armadura(string nombre_habilidad, Elementos item)
        {
            item.ArmaduraDinamicaItem += 10;
            return $"La armadura del item {item.NombreItem} ha aumentado por 10 puntos gracias a la habilidad {nombre_habilidad}!";
        }
    }
}