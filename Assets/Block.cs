using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
   
    private void OnTriggerEnter2D(Collider2D colider)
    {
       

        if (colider.gameObject.tag == "ball") {
            Destroy(gameObject);
        }
    }  
}