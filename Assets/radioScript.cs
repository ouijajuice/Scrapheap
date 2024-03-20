using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioScript : MonoBehaviour
{
    public AudioClip[] songs;
    public AudioSource source;
    public int songIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (songIndex > 3)
        {
            songIndex = 0;
        }
        source.clip = songs[songIndex];
        
        if (!source.isPlaying || source.clip != songs[songIndex])
        {
            source.Play();
        }
        
    }
}
