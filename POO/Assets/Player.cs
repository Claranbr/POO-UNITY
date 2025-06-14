using UnityEngine;

public class Play : MonoBehaviour
{


    private float velocidade;
        
    void Start()
    {
        velocidade = gameObject.GetComponent<Personagem>().velocidade;
     
        
    }
    
    void Update()
    {
        Vector3 posicao = transform.position;
        
        
        
        //Esquerda x-
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = transform.position.x - velocidade * Time.deltaTime;
        }
        
        //Direita x-
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = transform.position.x + velocidade * Time.deltaTime;
        }
        
        //Cima z+
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = transform.position.z + velocidade * Time.deltaTime;
        }
        
        //Baixo Z-
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = transform.position.z - velocidade * Time.deltaTime;
        }
        
        transform.position = posicao;
        
        
    }
    
}
