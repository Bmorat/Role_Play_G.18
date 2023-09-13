using System;

namespace Role_Playgame
{   
    
    class Program
    {
        static void Main(string[] args)
        {
            Mago Mago_Celestial = new Mago("Mago Celestial", 120, 40, 10, 60, 100);
            Mago magon = new Mago("Gandalf", 100, 10, 20, 15, 30);
            Mago_Celestial.Situacion();
            Mago_Celestial.Atacar(magon);
            magon.Atacar(Mago_Celestial);
            Mago_Celestial.Situacion();

        }
    }
}
