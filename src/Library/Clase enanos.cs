namespace Library
{
    public class Enanos //creo la clase enanos para que al generar objetos se trate de un enano mas
    {
        public int Salud {get;} = 50; //valor predeterminado de cada enano. defino solo como get para que no se pueda modificar
        public int Ataque {get;} = 40; //valor predeterminado de cada enano
        public int Armadura {get;} = 30;
        public Elementos Item_1 {get; set;}
        public Elementos Item_2 {get; set;}

        public Enanos (Elementos item1, Elementos item2)
        {
            this.Item_1 = item1;
            this.Item_2 = item2;
        }
    }
}