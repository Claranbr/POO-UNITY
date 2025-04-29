using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class inimigo: personagem
{
    private string armadura;
    private string arma;

    public enum ArmaDoInimgio
    {
        ESPADA, MACHADO, ADAGA
    }

    public enum ArmaduraDoInimigo
    {
        MADEIRA, COURO, BRONZE, AÇO
    }

    [SerializeField]
    private ArmaduraDoInimigo armadura;
    [SerializeField]
    private ArmaDoInimigo arma;
    private int dano;

    public void atribuirArmadura(ArmaduraDoInimigo armadura)

    {
        this.armadura = armadura;
    }

    public void AtribuirArma(ArmaDoInimigo arma)
    {
        this.arma = arma;
    }
    
    public void DanoDoInimigo()

    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case ArmaDoInimigo.ESPADA:
                dano = forca_ataque() + 10;
        }
    }
    
    
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

internal class ArmaDoInimigo
{
}
