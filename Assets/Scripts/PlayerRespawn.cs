using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    public Vector3 respawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        respawnPosition = transform.position;
    }

    // Update is called once per frame


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            transform.position = respawnPosition;
        }

        if (other.gameObject.tag == "Checkpoint")
        {
            respawnPosition = transform.position;
        }
    }

}

