using Library;
namespace LibraryTests;

public class Tests
{
    [Test]
    public void TestItems()//vamos a testear que los items se creen correctamente y funcionen los activables
    {
        Elementos testdaga = new Elementos("Daga", 30, 0);
        Elementos testescudo = new Elementos("Escudo", 5, 20);

        Assert.That(testdaga.NombreItem, Is.EqualTo("Daga"));
        Assert.That(testdaga.AtaqueBaseItem, Is.EqualTo(30));


        Elementos.Activable_Item_Ataque("Super Daga", testdaga);//ataque +=10
        Assert.That(testdaga.AtaqueDinamicoItem, Is.EqualTo(40));

        Elementos.Activable_Item_Armadura("Super Escudo", testescudo);//armadura +=10
        Assert.That(testescudo.ArmaduraDinamicaItem, Is.EqualTo(30));
    }
    
    [Test]
    public void Test_PJ() //aca vamos a testear que los PJs se creen correctamente
    {
            Elementos testdaga = new Elementos("Daga", 30, 0);
            Elementos testescudo = new Elementos("Escudo", 5, 20);
            Enanos Enano_tester = new Enanos("Enano_Juan", testdaga, testescudo);
            Enanos Enano_testeador = new Enanos("Enano_Pedro", testdaga, testdaga);

            Elementos testlibroDeHechizos = new Elementos("LibroDeHechizos", 25, 0);
            Elementos testbaculoMagico = new Elementos("BaculoMagico", 10, 10);
            Magos Mago_tester = new Magos("Mago_Alfonso", testlibroDeHechizos, testbaculoMagico);
            Magos Maga_testeador = new Magos("Maga_Maca", testbaculoMagico, testbaculoMagico);


            Elementos testpolvoMagico = new Elementos("PolvoMagico", 20, 10);
            Elementos testbotasMisticas = new Elementos("BotasMisticas", 5, 30);
            Elfos Elfo_tester = new Elfos("Elfo_Brian", testpolvoMagico, testbotasMisticas);
            Elfos Elfo_Testeador  = new Elfos("Elfa_Jime", testbotasMisticas, testbotasMisticas);

            Assert.That(Enano_tester.Nombre, Is.EqualTo("Enano_Juan"));
            Assert.That(Enano_testeador.Nombre, Is.EqualTo("Enano_Pedro"));

            Assert.That(Mago_tester.Nombre, Is.EqualTo("Mago_Alfonso"));
            Assert.That(Maga_testeador.Nombre, Is.EqualTo("Maga_Maca"));

            Assert.That(Elfo_tester.Nombre, Is.EqualTo("Elfo_Brian"));
            Assert.That(Elfo_Testeador.Nombre, Is.EqualTo("Elfa_Jime"));
            
            

    }

    [Test]
    public void TestAtaque() //Aca vamos a testear la funcion para que los PJs se ataquen entre si, dada por la clase ataque.cs
    {
            Elementos testdaga = new Elementos("Daga", 30, 0);
            Elementos testescudo = new Elementos("Escudo", 5, 20);
            Enanos Enano_tester = new Enanos("Enano_Juan", testdaga, testescudo);
            Enanos Enano_testeador = new Enanos("Enano_Pedro", testdaga, testdaga);

            Elementos testlibroDeHechizos = new Elementos("LibroDeHechizos", 25, 0);
            Elementos testbaculoMagico = new Elementos("BaculoMagico", 10, 10);
            Magos Mago_tester = new Magos("Mago_Alfonso", testlibroDeHechizos, testbaculoMagico);
            Magos Maga_testeador = new Magos("Maga_Maca", testbaculoMagico, testbaculoMagico);


            Elementos testpolvoMagico = new Elementos("PolvoMagico", 20, 10);
            Elementos testbotasMisticas = new Elementos("BotasMisticas", 5, 30);
            Elfos Elfo_tester = new Elfos("Elfo_Brian", testpolvoMagico, testbotasMisticas);
            Elfos Elfo_Testeador  = new Elfos("Elfa_Jime", testbotasMisticas, testbotasMisticas);



            Assert.That(Ataques.Atacar_EnanotoEnano(Enano_tester, Enano_testeador), Is.EqualTo("Enano_Juan le ha quitado 45 puntos de vida a Enano_Pedro"));
            Assert.That(Ataques.Atacar_MagotoMago(Mago_tester, Maga_testeador), Is.EqualTo("Mago_Alfonso le ha quitado 25 puntos de vida a Maga_Maca"));
            Assert.That(Ataques.Atacar_ElfotoElfo(Elfo_tester, Elfo_Testeador), Is.EqualTo("Elfo_Brian no le ha sacado vida a Elfa_Jime por la fortaleza de su armadura"));
            Assert.That(Ataques.Atacar_EnanotoMago(Enano_tester, Mago_tester), Is.EqualTo("Enano_Juan le ha quitado 35 puntos de vida a Mago_Alfonso"));


            Elementos capafuerte = new Elementos("capafuerte", 0, 100);
            Enanos Enano_tank = new Enanos("Enano_tank", testdaga, capafuerte);

            Assert.That(Ataques.Atacar_EnanotoEnano(Enano_tester, Enano_tank), Is.EqualTo($"{Enano_tester.Nombre} no le ha sacado vida a {Enano_tank.Nombre} por la fortaleza de su armadura"));


    }





     [Test]
    public void TestCurar()//se testea la funcion de curar de la clase curaciones.cs
    {
            Elementos testdaga = new Elementos("Daga", 30, 0);
            Elementos testescudo = new Elementos("Escudo", 5, 20);
            Enanos Enano_tester = new Enanos("Enano_Juan", testdaga, testescudo);
            Enanos Enano_testeador = new Enanos("Enano_Pedro", testdaga, testdaga);

            Ataques.Atacar_EnanotoEnano(Enano_tester, Enano_testeador);


            Assert.That(Curaciones.Curar_Enano(Enano_tester), Is.EqualTo("¡Enano_Juan ya está full vida!"));
            Assert.That(Curaciones.Curar_Enano(Enano_testeador), Is.EqualTo("¡Enano_Pedro ha sido curado y posee nuevamente 50 puntos de vida!"));

    }

}