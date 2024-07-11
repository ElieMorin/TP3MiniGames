using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ESoundKeys
{
    Drive,
    Idle,
    PourCoffee,
    punchDonut,
    runStadium
}

[Serializable]
public class SoundConfig
{
    public ESoundKeys Key;
    public AudioClip Clip;
}

public class AudioManager : MonoBehaviour
{
    #region singleton
    private static AudioManager m_Instance;

    private void Awake()
    {
        if(m_Instance == null)
        {
            m_Instance = this;

            m_AudioClips = new Dictionary<ESoundKeys, AudioClip>();
            SetupClipsInDictionnary();
            m_AudioPool = new AudioPool();
        }

    }

    public static AudioManager GetInstance()
    {
        return m_Instance;
    }

    #endregion

    private AudioPool m_AudioPool;
    [SerializeField] private List<SoundConfig> m_Clips;

    private Dictionary<ESoundKeys, AudioClip> m_AudioClips;

    public void PlaySound(ESoundKeys keyToPlay)
    {
        AudioSource availableSource = m_AudioPool.GetAvailableSource();

        availableSource.clip = m_AudioClips[keyToPlay];

        availableSource.Play();
    }

    private void SetupClipsInDictionnary()
    {
        foreach(SoundConfig clip in m_Clips)
        {
            m_AudioClips.Add(clip.Key,clip.Clip);
        }
    }
}
