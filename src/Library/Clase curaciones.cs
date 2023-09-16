namespace Library
{
    public class Curaciones
    {
        public static string Curar_Enano(Enanos enano_en_cuestion)
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

        public static string Curar_Mago(Magos Mago_en_cuestion)
        {
            if (Mago_en_cuestion.SaludDinamica < Mago_en_cuestion.SaludBase)
            {  
                Mago_en_cuestion.SaludDinamica = Mago_en_cuestion.SaludBase;
                return $"¡{Mago_en_cuestion.Nombre} ha sido curado y posee nuevamente {Mago_en_cuestion.SaludBase} puntos de vida!";
            }
            else
            {
                return $"¡{Mago_en_cuestion.Nombre} ya está full vida!";
            }
        }
        public static string Curar_Elfo(Elfos Elfo_en_cuestion)
        {
            if (Elfo_en_cuestion.SaludDinamica < Elfo_en_cuestion.SaludBase)
            {  
                Elfo_en_cuestion.SaludDinamica = Elfo_en_cuestion.SaludBase;
                return $"¡{Elfo_en_cuestion.Nombre} ha sido curado y posee nuevamente {Elfo_en_cuestion.SaludBase} puntos de vida!";
            }
            else
            {
                return $"¡{Elfo_en_cuestion.Nombre} ya está full vida!";
            }
        }
    }
}