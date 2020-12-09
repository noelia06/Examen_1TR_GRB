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
    int contador;

    void Start()
    {
        StartCoroutine("InstanciadorCoroutine");
        for (int n = 1; n <= 20; n++)
        {
            //Creamos cada columna, con la separación establecida
            CrearEsfera();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    
    private void CrearEsfera( )
    {
        float randomX = Random.Range(-198f, 198f);
        float randomZ = Random.Range(-94f, 94f);
        float randomY = Random.Range(130f, 8f);

        Vector3 RndmPos = new Vector3(randomX, randomY, randomZ);
        Instantiate(Obstaculo, RndmPos, Quaternion.identity);
    }

    IEnumerator InstanciadorCoroutine()
    {
        for (contador = 1; contador <= 5; contador++)
        {
            CrearEsfera();
            yield return new WaitForSeconds(2);
        }
        for (contador = 6; contador <= 10 && contador > 5; contador++)
        {
            CrearEsfera();
            yield return new WaitForSeconds(1);
        }
        for (contador = 11; contador > 10; contador++)
        {
            CrearEsfera();
            yield return new WaitForSeconds(0.5f);
        }
    }

    

    
}
