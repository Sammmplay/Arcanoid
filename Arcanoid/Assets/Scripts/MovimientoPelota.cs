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

<<<<<<< Updated upstream
    public bool juegoEmpezo;
=======
    [SerializeField] public bool juegoEmpezo;
>>>>>>> Stashed changes

    [SerializeField]
    GameObject pantallaP;

    [SerializeField]
    float vidas = 3;
    [SerializeField]
    TextMeshProUGUI vidaLabel;

    [SerializeField]
    Vector3 posInicial;

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
            //transform.position = new Vector3(0, 2.25f, 3.8f);
        }
        else
        {
<<<<<<< Updated upstream
            transform.position = posInicial;
=======
            //transform.position = posInicial;
            //transform.parent = ;
>>>>>>> Stashed changes

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
            
            if (vidas > 0)
            {
                vidas--;
                vidaLabel.text = vidas.ToString();
                juegoEmpezo = false;
<<<<<<< Updated upstream
                FindObjectOfType<MovimientoJugador>().ResetPlayer();
                transform.parent = FindObjectOfType<MovimientoJugador>().transform;
=======
                transform.position = posInicial;
               // FindObjectOfType<MovimientoJugador>.ResetPlayer();
>>>>>>> Stashed changes
            }
            else if (vidas == 0)
            {
                pantallaP.SetActive(true);
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
