using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] GameObject Obstaculo;

    //Variable que tiene la posición del objeto de referencia
    [SerializeField] Transform InitPos;

    //Variables para generar columnas de forma random
    private float randomNumber;
    Vector3 RandomPos;
    // Start is called before the first frame update
    float distanciaSep = 6f;
    
    
    void Start()
    {
        IniciarEsfera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    
    void CrearEsfera(float posZ)
    {
        randomNumber = Random.Range(0f, 14f);
        RandomPos = new Vector3(randomNumber, 0, posZ);
        //print(RandomPos);
        Vector3 FinalPos = InitPos.position + RandomPos;
        Instantiate(Obstaculo, FinalPos, Quaternion.identity);
    }

    IEnumerator InstanciadorColumnas()
    {
        //Bucle infinito (poner esto es lo mismo que while(true){}
        for (; ; )
        {
            CrearEsfera(0);
            yield return new WaitForSeconds(1f);
        }

    }


    void IniciarEsfera()
    {
        for (int n = 1; n <= 20; n++)
        {
            //Creamos cada columna, con la separación establecida
            CrearEsfera(-n * distanciaSep);
        }
    }
}
