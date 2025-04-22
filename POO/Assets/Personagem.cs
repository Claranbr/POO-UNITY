using System;
using UnityEngine;

public class ladybug : MonoBehaviour
{
    public string nome;
    public int energia;
    public int forca_ataque;
    public int forca_do_pulo;
    public int velocidade;
    public int numero_de_pes;
    public int numero_de_maos;

    public ladybug(string nome, int energia, int forca_ataque, int forca_do_pulo, int velocidade, int numero_de_pes,
        int numero_de_maos)

    {
        nome = nome;
        energia = energia;
        forca_ataque = forca_ataque;
        forca_do_pulo = forca_do_pulo;
        velocidade = velocidade;
        numero_de_pes = numero_de_pes;
        numero_de_maos = numero_de_maos;
        
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"==ladybug: {nome} ===");
        
        
        
        
        
        
        
        
        
        
    }


}
