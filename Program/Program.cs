using System;

namespace Role_Playgame
{   
    
    class Program
    {
        static void Main(string[] args)
        {
            Mago Mago_Celestial = new Mago("Mago Celestial", 120, 40, 10);
            Mago magon = new Mago("Gandalf", 100, 10, 20);
            Mago_Celestial.Situacion();
            Mago_Celestial.Atacar(magon);
            Mago_Celestial.Situacion();
            magon.Atacar(Mago_Celestial);
            magon.Atacar(Mago_Celestial);
            Mago_Celestial.Situacion();
            Mago_Celestial.Curar();
            Mago_Celestial.Situacion();

        }
    }
}
