using UnityEngine;

public class inimigo:  ladybug 
{
    private string armadura;
    private string arma;

    public inimigo(string nome, int energia, int forca_ataque, int forca_do_pulo, int velocidade, int numero_de_pes, int numero_de_maos, string armadura, string arma) : base(nome, energia, forca_ataque, forca_do_pulo, velocidade, numero_de_pes, numero_de_maos)
    {
        this.armadura = armadura;
        this.arma = arma;
    }

    public void AtribuirArmadura(string armadura)
    {
        
        this.armadura = armadura;
    }

    public string Armadura()
    {
        return this.armadura;
    }

    public void AtribuirArma(string arma)

    {
        this.arma = arma;
    }


    public int DanoDoInimigo()
    {
        int dano = 0;
        switch (arma)
        {
            case "ESPADA":
                dano = forca_ataque() + 10;
                break;
            case "MACHADO":
                dano = dano = forca_ataque() + 18;
                break;
           case "ADAGA":
                dano = forca_ataque() + 5;
               break;
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
