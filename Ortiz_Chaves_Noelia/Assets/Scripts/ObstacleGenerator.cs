﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] GameObject Obstaculo;
    [SerializeField] Transform InitPos;
    [SerializeField] Text Tiempo;
    [SerializeField] Text ContadorEsferas;
   
    public int nEsferas;
    private float tiempo = 0;
    private float segundos = 0;

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
        UIText();
    }

    
    
    private void CrearEsfera( )
    {
        float randomX = Random.Range(-198f, 198f);
        float randomZ = Random.Range(-94f, 94f);
        float randomY = Random.Range(28f, 8f);

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

    void UIText()
    {
        nEsferas = contador;

        tiempo += Time.deltaTime;
        segundos = tiempo % 60;
        ContadorEsferas.text = "Nº de esferas: " + nEsferas;
        Tiempo.text = "Tiempo jugado: " + segundos.ToString("f1") + " segs";
    }


}
