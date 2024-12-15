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
    public float tiempoPartida;

    bool pelotaMoviendose = false;

    [SerializeField]
    public Rigidbody pelotaRb;

    [SerializeField]
    public Vector3 velPelota;
    

    public bool juegoEmpezo;

    [SerializeField]
    GameObject pantallaP;

    [SerializeField]
    float vidas = 3;
    [SerializeField]
    TextMeshProUGUI vidaLabel;

    [SerializeField]
    Vector3 posInicial;

    [SerializeField]
    GameObject canvasJuego;

    void Start()
    {
        pelotaRb= GetComponent<Rigidbody>();
        posInicial = transform.position;
        transform.parent = FindObjectOfType<MovimientoJugador>().transform;
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
            transform.parent = null;
            //transform.position = new Vector3(0, 2.25f, 3.8f);
        }
        else
        {
            //transform.position = posInicial;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                juegoEmpezo = true;
                
                pelotaRb.velocity = velPelota;
                
                //gameObject.transform.position = ;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Muro"))
        {
            
            if (vidas > 0)
            {
                vidas--;
                vidaLabel.text = vidas.ToString();
                juegoEmpezo = false;
                FindObjectOfType<MovimientoJugador>().ResetPlayer();
                gameObject.transform.parent = FindObjectOfType<MovimientoJugador>().transform;
                transform.position = posInicial;
                juegoEmpezo = false;
                pelotaRb.velocity=Vector3.zero;
            }
            else if (vidas == 0)
            {
                pantallaP.SetActive(true);
                canvasJuego.SetActive(false);
                juegoEmpezo = false;
            }
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
