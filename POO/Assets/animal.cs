using UnityEngine;

public class Animal : Personagem
{
    [SerializeField]
    private string tipoDeRabo;
    [SerializeField]
    private string tipoDeAsa;
    [SerializeField]
    private int numeroDeChifres;
    [SerializeField]
    private int numeroDeOlhos;

    public void AtribuirTipoDeRabo(string tipoDeRabo)
    {
        this.tipoDeRabo = tipoDeRabo;
    }

    public string TipoDeRabo()
    {
        return this.tipoDeRabo;
    }

    public void AtribuirTipoDeAsa(string tipoDeAsa)
    {
        this.tipoDeAsa = tipoDeAsa;
    }

    public string TipoDeAsa()
    {
        return this.tipoDeAsa;
    }
    public void AtribuirNumeroDeChifres(int numeroDeChifres)
    {
        this.numeroDeChifres = numeroDeChifres;
    }
    public int NumeroDeChifres()
    {
        return this.numeroDeChifres;
    }

    public void AtribuirNumeroDeOlhos(int numeroDeOlhos)
    {
        this.numeroDeOlhos = numeroDeOlhos;
    }

    public int NumeroDeOlhos()
    {
        return this.numeroDeOlhos;
    }

    public int AtaqueDoAnimal()
    {
        int dano = Forca_Ataque() + NumeroDeChifres() * 30; 
        return dano;
    }
    
    
}
