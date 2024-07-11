using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPool
{
    private List<AudioSource> m_SourceList = new List<AudioSource>();
    
    public AudioSource GetAvailableSource()
    {
        foreach (AudioSource source in m_SourceList)
        {
            if (!source.isPlaying)
            {
                return source;
            }
        }
        AudioSource newSource = new AudioSource();
        m_SourceList.Add(newSource);
        return newSource;
    }
}
