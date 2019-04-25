using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSFX : MonoBehaviour
{
    public AudioSource SpikeSource;
    
    void Start()
    {
        InvokeRepeating("RedRubyNoise", 0.01f, 3.0f);
        //SpikeSource = GetComponent<AudioSource>();
    }

    void RedRubyNoise()
    {
        SpikeSource.Play();
    }
}
