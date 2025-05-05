using System;
using UnityEngine;

public class testededano : MonoBehaviour
{
    private Personagem personagem;
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.tag == "Inimigo")
        {
            
            Debug.Log(colisao.gameObject.name);

            int energia = personagem.Energia();
            int dano = colisao.gameObject.GetComponent<Inimigo>().DanoDoInimigo();
            
            personagem.AtribuirEnergia( energia - dano);
            
            Debug.Log("O personagem " + personagem.getNome() + " recebeu dano de " + dano);
            Debug.Log(" a vida do personagem e de " + personagem.Energia());

        }

        if (colisao.gameObject.tag == "Animal")
        {
            int energia = personagem.Energia();
            int dano = colisao.gameObject.GetComponent<Animal>().AtaqueDoAnimal();
            
            personagem.AtribuirEnergia( energia - dano);
            
            Debug.Log("O personagem " + personagem.getNome() + " recebeu dano de " + dano + " do animal " + colisao.gameObject.GetComponent<Animal>().getNome());
            Debug.Log(" a vida do personagem e de " + personagem.Energia());



        }
        
        
    }


    void Start()
    {
        personagem = gameObject.GetComponent<Personagem>();
    }

    
    void Update()
    {
        
    }
}
