namespace Library
{
    public class Elfos //creo la clase elfos para que al generar objetos se trate de un elfo mas.
    {
        public int SaludDinamica {get; set;} = 50; 
        public int SaludBase {get;} = 50;//valor predeterminado de cada elfo.
        public int AtaqueBase {get; set;} = 40; //valor predeterminado de cada elfo.
        public int ArmaduraBase {get; set;} = 30; //valor predeterminado de cada elfo.
        public int ArmaduraDinamica {get; set;} = 30;
        public int AtaqueDinamico {get; set;} = 40;
        public string Nombre {get; set;}
        public Elementos Item_1 {get; set;}
        public Elementos Item_2 {get; set;}

        public Elfos (string nombre, Elementos item1, Elementos item2)
        {
            this.Item_1 = item1;
            this.Item_2 = item2;
            this.Nombre = nombre;
            this.ArmaduraDinamica += item1.ArmaduraDinamicaItem;
            this.ArmaduraDinamica += item2.ArmaduraDinamicaItem;
            this.AtaqueDinamico += item1.AtaqueDinamicoItem;
            this.AtaqueDinamico += item2.AtaqueDinamicoItem;
        }
    }
}