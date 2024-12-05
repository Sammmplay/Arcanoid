using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour
{
    
  //  public int vidaBloq;
   // public static MapaAleatorio instance;
    public GameObject[] prefabs; 
    public int anchoMapaMin = -20;
    public int anchoMapaMax = 25; 
    public int altoMapaMin = 86; 
    public int altoMapaMax = 56; 

    public float distanciaObjX = 10f;
    public float distanciaObjY = 10f;
    public int filas = 2;
    public int columnas = 3;



    void Start()
    {

        GenerarMapa();

    }

    // M�todo para generar el mapa aleatorio
    public void GenerarMapa()
    {
        for (int fila = 0; fila < filas; fila++)
        {
            for (int columna = 0; columna < columnas; columna++)
            {
                float posicionX = anchoMapaMin + columna * distanciaObjX;
                float posicionY = altoMapaMin + fila * distanciaObjY;

                Vector3 posicion = new Vector3(posicionX, 2.25f, posicionY);

                GameObject prefabAleatorio = prefabs[Random.Range(0, prefabs.Length)];

                Instantiate(prefabAleatorio, posicion, Quaternion.identity);
            }

        }

    }





}
