using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour{


    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col){
        Destroy(gameObject);
        print("Got a key");
    }
}
