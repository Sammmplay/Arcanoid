using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MovimientoPelota : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeLabel;
    [SerializeField]
    float tiempoPartida;

    bool pelotaMoviendose = false;

    // Update is called once per frame
    void Update()
    {
        //float minutos = tiempoPartida / 60f;
        //float segundos = tiempoPartida % 60f;
        //float milesimas = ((tiempoPartida - tiempoPartida) * 1000f);

        //return minutos.ToString("00") + ":" + segundos.ToString("00") + ":" + milesimas.ToString("00");

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            pelotaMoviendose = true;
            gameObject.transform.position = Vector3.one;
        }


        float minutos = Mathf.FloorToInt(tiempoPartida  / 60F);
        float segundos = Mathf.FloorToInt(tiempoPartida % 60F);
        float milesimas = Mathf.FloorToInt((tiempoPartida *60) %60F);
        
        

        if (pelotaMoviendose==true)
        {    
            tiempoPartida += Time.deltaTime;
            timeLabel.text = tiempoPartida.ToString();
            timeLabel.text = string.Format("{0:00}:{1:00}:{2:00}", minutos, segundos, milesimas);
        }

    }
}
