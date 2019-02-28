using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLight : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Spawnpoint;


    void OnTriggerEnter()
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);

        Destroy(gameObject);

    }

}