using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class MovimientoJugador : MonoBehaviour
{
    /*[SerializeField]
    float movimientoEjeX;
    [SerializeField]
    float movimientoEjeZ;
    [SerializeField]
    float velocidadMovimiento = 144.6f;
    [SerializeField]
    private float minX = -21.52f;  // Límite mínimo en el eje X (por ejemplo, la pared izquierda)
    [SerializeField]
    private float maxX = 25.81f; // Límite máximo en el eje X (por ejemplo, la pared derecha)
    [SerializeField]
    private float minZ = -1.3f;
    [SerializeField]
    private float maxZ = 18f;

    [SerializeField]
    Rigidbody jugadorRb;

    void Start()
    {
        jugadorRb =GetComponent<Rigidbody>();
    }

    void Update()
    {
        /*movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
        movimientoEjeX = Input.GetAxis("Horizontal");
        movimientoEjeZ = Input.GetAxis("Vertical");
        
        jugadorRb.velocity = new Vector3(movimientoEjeX * velocidadMovimiento * Time.deltaTime, 0, movimientoEjeZ * velocidadMovimiento * Time.deltaTime);*/

    [SerializeField]
    private float speed = 7f;
    [SerializeField]
    private float minX = 132f;  // Límite mínimo en el eje X (por ejemplo, la pared izquierda)
    [SerializeField]
    private float maxX = 980f;   // Límite máximo en el eje X (por ejemplo, la pared derecha)

    private Rigidbody2D paloRb;

    [SerializeField]
    private float minZ = -1.3f;
    [SerializeField]
    private float maxZ = 7.7f;

    bool juegoEmpezo;


    private void Start()
    {

    }

    void Update()
    {
        //if (juegoEmpezo)
        //{
            float movement = Input.GetAxisRaw("Horizontal");
            float partida = Input.GetAxisRaw("Vertical");

            float newPosX = transform.position.x + movement * speed * Time.deltaTime;
            float newPosZ = transform.position.z + partida * speed * Time.deltaTime;

            newPosX = Mathf.Clamp(newPosX, minX, maxX);
            newPosZ = Mathf.Clamp(newPosZ, minZ, maxZ);

            transform.position = new Vector3(newPosX, transform.position.y, newPosZ);
        //}
        /*else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                juegoEmpezo = true;
                //gameObject.transform.position = ;
            }
        }

        /*[SerializeField]
        float velocidadMov;
        [SerializeField]
        float maxX = 0f;
        [SerializeField]
        float minX = 0f;
        [SerializeField]
        float maxZ = 0f;
        [SerializeField]
        float minZ = 0f;

        void Update()
        {
            float movX = Input.GetAxis("Horizontal");
            float movZ = Input.GetAxis("Vertical");

            Vector3 posicion= transform.position;
            posicion.x = Mathf.Clamp(posicion.x*movX*velocidadMov *Time.deltaTime, maxX, minX);
            posicion.z= Mathf.Clamp(posicion.z*movZ*velocidadMov * Time.deltaTime, maxZ, minZ);*/
    }

}

