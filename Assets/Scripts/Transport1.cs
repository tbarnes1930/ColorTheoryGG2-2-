using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     private void OnTriggerEnter(Collider objectCollided)
    {
           GetComponent<Transform>().position = new Vector3(-0.0323f, 0.1037f);
    }
}
