using System;

namespace Library
{
    public class Elementos
    {
       public string NombreItem {get; set;}
        public int AtaqueItem {get; set;}
        public int ArmaduraItem {get; set;}
        public Elementos (string nombreItem, int ataqueItem, int armaduraItem)
        {
            this.NombreItem = nombreItem;
            this.AtaqueItem = ataqueItem;
            this.ArmaduraItem = armaduraItem;
        }
    }
}