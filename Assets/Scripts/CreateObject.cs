using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Spawnpoint;
    public Transform Spawnpoint2;
    public Transform Spawnpoint3;


    void OnTriggerEnter()
        {
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
			
        Instantiate(Prefab, Spawnpoint2.position, Spawnpoint2.rotation);
		
		if (Spawnpoint2 == null)
		{
			Destroy(gameObject);
		}
		
        Instantiate(Prefab, Spawnpoint3.position, Spawnpoint3.rotation);
		
		if (Spawnpoint3 == null)
		{
			Destroy(gameObject);
		}
		
        Destroy(gameObject);
		
		
		
        }

}

    /*if (switchCheck == true)
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
}

*/