﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider objectCollided)
        {
            if (objectCollided.gameObject.tag == "Goal4")
                SceneManager.LoadScene("Win");
        }

    }