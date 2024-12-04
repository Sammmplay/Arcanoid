using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquesRomper : MonoBehaviour
{
    
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
            Destroy(gameObject);
        }
    }
}
