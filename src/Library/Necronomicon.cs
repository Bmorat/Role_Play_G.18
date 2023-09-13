namespace Items;

public class Necronomicon
{
    public int Valor_de_ataque {get; set;}

    public int Valor_de_defensa {get; set;}

   public Necronomicon (int ataque, int defensa)
    {
        this.Valor_de_ataque = ataque;
        this.Valor_de_defensa = defensa;
    }


}