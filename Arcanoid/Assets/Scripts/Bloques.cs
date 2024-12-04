using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour
{
    
  //  public int vidaBloq;
   // public static MapaAleatorio instance;
    public GameObject[] prefabs; // Array para almacenar los diferentes prefabs (por ejemplo, suelos, paredes, etc.)
    public int anchoMapaMin = -20; // Ancho del mapa
    public int anchoMapaMax = 25; // Ancho del mapa
    public int altoMapaMin = 86; // Alto del mapa
    public int altoMapaMax = 56; // Alto del mapa

    public float distanciaEntreObjetosX = 10f; // Distancia entre cada prefab en el mapa
    public float distanciaEntreObjetosY = 10f; // Distancia entre cada prefab en el mapa
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
                float posicionX = anchoMapaMin + columna * distanciaEntreObjetosX;
                float posicionY = altoMapaMin + fila * distanciaEntreObjetosY;

                // Generar una posici�n aleatoria para el prefab
                Vector3 posicion = new Vector3(posicionX, 2.25f, posicionY);

                // Elegir un prefab aleatorio del array de prefabs
                GameObject prefabAleatorio = prefabs[Random.Range(0, prefabs.Length)];

                // Instanciar el prefab en la posici�n calculada
                Instantiate(prefabAleatorio, posicion, Quaternion.identity);
            }

        }

    }





}
