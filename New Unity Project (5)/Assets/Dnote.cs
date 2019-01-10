using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dnote : MonoBehaviour {

  
    public Rigidbody rb;
    public bool isGrounded;

    private void OnTriggerStay(Collider other)
   
    {
        PlayerScore player = other.gameObject.GetComponent<PlayerScore>();
        if (Input.GetKey(KeyCode.D) == true && other.tag == "NoteTrigger" && player != null)
        {
            player.score(100);
            Destroy(other.gameObject);
        }
    }
}
