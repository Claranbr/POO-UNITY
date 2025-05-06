using UnityEngine;

public class Play : MonoBehaviour
{
    private Rigidbory rigididbory;

    public float velocidade = 10;
        
    void Start()
    {
        rigididbory = GetComponent<Rigidbory>();
        
    }
    
    void Update()
    {
        Vector3 posicao = transform.position;
        
        
        
        //Esquerda x-
        if (Input.GetKeyDown(KeyCode.A))
        {
            posicao.x = transform.position.x - velocidade * Time.deltaTime;
        }
        
        //Direita x-
        if (Input.GetKeyDown(KeyCode.D))
        {
            posicao.x = transform.position.x + velocidade * Time.deltaTime;
        }
        
        //Cima z+
        if (Input.GetKeyDown(KeyCode.W))
        {
            posicao.z = transform.position.z + velocidade * Time.deltaTime;
        }
        
        //Baixo Z-
        if (Input.GetKeyDown(KeyCode.S))
        {
            posicao.z = transform.position.z - velocidade * Time.deltaTime;
        }
        
        transform.position = posicao;
        
        
    }
    
}

internal class Rigidbory
{
}

internal class Rigibori
{
}
