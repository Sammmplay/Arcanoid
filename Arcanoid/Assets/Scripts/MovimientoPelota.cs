using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using TMPro.EditorUtilities;
using UnityEditor;

public class MovimientoPelota : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeLabel;
    [SerializeField]
    float tiempoPartida;

    bool pelotaMoviendose = false;

    [SerializeField]
    Rigidbody pelotaRb;

    [SerializeField]
    public Vector3 velPelota;

    bool juegoEmpezo;

    [SerializeField]
    GameObject pantallaP;

    void Start()
    {
        pelotaRb= GetComponent<Rigidbody>();

    }
    void Update()
    {
        float minutos = Mathf.FloorToInt(tiempoPartida / 60F);
        float segundos = Mathf.FloorToInt(tiempoPartida % 60F);
        float milesimas = Mathf.FloorToInt((tiempoPartida * 60) % 60F);

        if (juegoEmpezo)
        {
            //gameObject.transform.position = new Vector3(0f, 2.25f, 3.8f);
            tiempoPartida += Time.deltaTime;
            timeLabel.text = tiempoPartida.ToString();
            timeLabel.text = string.Format("{0:00}:{1:00}:{2:00}", minutos, segundos, milesimas);
        }
        else
        { 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                juegoEmpezo = true;
                transform.parent = null;
                pelotaRb.velocity = velPelota;
                //gameObject.transform.position = ;
            }
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Muro"))
        {
            pantallaP.SetActive(true);
            juegoEmpezo = false;
        }
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        pelotaRb.velocity *= velPelota * Time.deltaTime;
    }

    public void ResetPelota()
    {
        pelotaRb.velocity = Vector3.zero;
        transform.position = new Vector3(0, 2.25f, 3.8f);
        juegoEmpezo = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pelota"))
        {
            ResetPelota();
        }
    }*/
}
