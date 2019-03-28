using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public GameObject objToTrack;
    public Vector3 offset;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - objToTrack.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, objToTrack.transform.position + offset, Time.deltaTime * speed);
    }
}
