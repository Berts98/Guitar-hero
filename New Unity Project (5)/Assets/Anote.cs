using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anote : MonoBehaviour {

   
    public Rigidbody rb;
    public bool isGrounded;

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
   
    {
        PlayerScore player = other.gameObject.GetComponent<PlayerScore>();
        if (Input.GetKey(KeyCode.A) == true && other.tag == "NoteTrigger" && player != null) 
        {
            player.score(100);
            Destroy(other.gameObject);
            Debug.Log("punto");
        }

    }
}
