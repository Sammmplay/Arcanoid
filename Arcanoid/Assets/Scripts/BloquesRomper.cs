using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquesRomper : MonoBehaviour
{
    
   public int numeroBloques = 4;

    [SerializeField]
    GameObject pantallaG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


 


    }

    void OnCollisionEnter(Collision collision)
    {
        // Destruye el bloque al colisionar con la pelota
        if (collision.gameObject.CompareTag("Pelota"))
        {
            numeroBloques = numeroBloques - 1; 
            Destroy(gameObject);
            Debug.Log("luciaesbobax2");





        }

        if (numeroBloques == 2)
        {

            Debug.Log("luciaesboba");
            pantallaG.SetActive(true);
        }


          

    }


   


}
