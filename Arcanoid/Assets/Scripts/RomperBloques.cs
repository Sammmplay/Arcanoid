using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BloquesRomper : MonoBehaviour
{
    public int vidaBloq = 2;
    public int totalBloq = 16;
    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalBloq <= 0)
        {
            Debug.Log("tpm");
            FindObjectOfType<ScreenScript>().pantallaG.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        vidaBloq--;

        if (vidaBloq == 0)
        {
            Destroy(gameObject);
            FindObjectOfType<ScreenScript>().canvasPowerUp.SetActive(true);
            totalBloq--;
            if (totalBloq <= 0)
            {
                FindObjectOfType<ScreenScript>().pantallaG.SetActive(true);
            }
        }
            
   }
}




    






