using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    public int keysNeeded = 3;

    private GameObject curObj;
    public Material highlightMaterial;
    private Material savedMaterial;

    public float rayLength;
    private RaycastHit hitInfo;
    public LayerMask layerMask;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * rayLength, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, rayLength, layerMask))
        {

            //ObjInteraction(curObj);

            if (curObj == null)
            {
                curObj = hitInfo.transform.gameObject;

                savedMaterial = curObj.GetComponent<Renderer>().material;

                curObj.GetComponent<Renderer>().material = highlightMaterial;
            }

            else if (curObj != hitInfo.transform.gameObject)
            {
                NullifyCurObj();
            }
        }

        else
        {
            if (curObj != null)
            {
                NullifyCurObj();
            }
        }
    }

    void NullifyCurObj()
    {
        curObj.GetComponent<Renderer>().material = savedMaterial;
        curObj = null;

    }
    //void ObjInteraction(GameObject objFromRaycast)
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //
    //        if (objFromRaycast.tag == "Door")
    //        {
    //            if (PlayerInventory.keyCount >= keysNeeded)
    //            {
    //                PlayerInventory.keyCount = 0;
    //                SceneManager.LoadScene("Nature_Level");
    //            }
    //            else
    //            {
    //                print("You need " + keysNeeded + " keys to open this door. Yet, you only have " + PlayerInventory.keyCount + " key(s). Find more!");
    //            }
    //        }
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal3")
        {
            if (PlayerInventory.keyCount >= keysNeeded)
            {
                PlayerInventory.keyCount = 0;
                SceneManager.LoadScene("Nature_Level");
            }
            else
            {
                print("You need " + keysNeeded + " keys to open this door. Yet, you only have " + PlayerInventory.keyCount + " key(s). Find more!");
            }
        }
    }
}