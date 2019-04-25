using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSFX : MonoBehaviour
{
    public AudioSource SpikeSource;
    
    void Start()
    {
        InvokeRepeating("RedRubyNoise", 0.001f, 3.1f);
        //SpikeSource = GetComponent<AudioSource>();
    }

    void RedRubyNoise()
    {
        SpikeSource.Play();
    }
}
