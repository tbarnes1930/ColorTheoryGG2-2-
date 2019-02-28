using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMoreObjects : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Spawnpoint;
    public Transform Spawnpoint2;
    public Transform Spawnpoint3;
    public Transform Spawnpoint4;
    public Transform Spawnpoint5;
    public Transform Spawnpoint6;
   

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

            Instantiate(Prefab, Spawnpoint4.position, Spawnpoint4.rotation);

            Instantiate(Prefab, Spawnpoint5.position, Spawnpoint5.rotation);

            if (Spawnpoint5 == null)
            {
                Destroy(gameObject);
            }

            Instantiate(Prefab, Spawnpoint6.position, Spawnpoint6.rotation);

            if (Spawnpoint6 == null)
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