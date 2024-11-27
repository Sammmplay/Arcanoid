using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField]
    float movimientoEjeX;
    [SerializeField]
    float movimientoEjeY;
    [SerializeField]
    float movimientoEjeZ;
    [SerializeField]
    float velocidadMovimiento = 1f;
    [SerializeField]
    private float minX = 1.42f;
    [SerializeField]
    private float maxX = 48.8f;
    [SerializeField]
    private float minZ = -48.5f;
    [SerializeField]
    private float maxZ = -29.2f;
    //[SerializeField]
    //Rigidbody rb;

    void Start()
    {


        //rb = GetComponent<Rigidbody>();


    }
        void Update()
        {
         movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
         movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
         transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);

         //float movimientorecto = Input.GetAxis("Horizontal");
         //float newPosX = transform.position.x * movimientorecto * velocidadMovimiento * Time.deltaTime;
         //float newPosZ = transform.position.y * velocidadMovimiento * Time.deltaTime;

         //newPosX = Mathf.Clamp(newPosX, minX, maxX);
         //newPosZ = Mathf.Clamp(newPosZ, minZ, maxZ);
        

        }





}
