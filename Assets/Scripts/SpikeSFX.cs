using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSFX : MonoBehaviour
{
    public AudioSource SpikeSource;
    
    void Start()
    {
        SpikeSource = GetComponent<AudioSource>();
        SpikeSource.PlayDelayed(2.1f);
    }


}
