namespace Library
{
    public class ObtenerPoints
    {
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

        public static string ObtenerAtaqueTotalMago(Magos Mago_en_cuestion)
        {
            //bloque de actualizacion de ataque en caso de que se hayan usado activables en items.
            Mago_en_cuestion.AtaqueDinamico = 0;
            Mago_en_cuestion.AtaqueDinamico += (Mago_en_cuestion.Item_1.AtaqueDinamicoItem + Mago_en_cuestion.AtaqueBase + Mago_en_cuestion.Item_2.AtaqueDinamicoItem);
            return $"El ataque total de {Mago_en_cuestion.Nombre} (incluyendo items) es de {Mago_en_cuestion.AtaqueDinamico} puntos";
        }

        public static string ObtenerArmaduraMago(Magos Mago_en_cuestion)
        {
            //bloque de actualizacion de armadura en caso de que se hayan usado activables en items.
            Mago_en_cuestion.ArmaduraDinamica = 0;
            Mago_en_cuestion.ArmaduraDinamica += (Mago_en_cuestion.Item_1.ArmaduraDinamicaItem + Mago_en_cuestion.ArmaduraBase + Mago_en_cuestion.Item_2.ArmaduraDinamicaItem);
            return $"La armadura total de {Mago_en_cuestion.Nombre} (incluyendo items) es de {Mago_en_cuestion.ArmaduraDinamica} puntos";
        }

        public static string ObtenerAtaqueTotalElfo(Elfos elfo_en_cuestion)
        {
            //bloque de actualizacion de ataque en caso de que se hayan usado activables en items.
            elfo_en_cuestion.AtaqueDinamico = 0;
            elfo_en_cuestion.AtaqueDinamico += (elfo_en_cuestion.Item_1.AtaqueDinamicoItem + elfo_en_cuestion.AtaqueBase + elfo_en_cuestion.Item_2.AtaqueDinamicoItem);
            return $"El ataque total de {elfo_en_cuestion.Nombre} (incluyendo items) es de {elfo_en_cuestion.AtaqueDinamico} puntos";
        }

        public static string ObtenerArmaduraTotalElfo(Elfos elfo_en_cuestion)
        {
            //bloque de actualizacion de armadura en caso de que se hayan usado activables en items.
            elfo_en_cuestion.ArmaduraDinamica = 0;
            elfo_en_cuestion.ArmaduraDinamica += (elfo_en_cuestion.Item_1.ArmaduraDinamicaItem + elfo_en_cuestion.ArmaduraBase + elfo_en_cuestion.Item_2.ArmaduraDinamicaItem);
            return $"La armadura total de {elfo_en_cuestion.Nombre} (incluyendo items) es de {elfo_en_cuestion.ArmaduraDinamica} puntos";
        }
    }
}