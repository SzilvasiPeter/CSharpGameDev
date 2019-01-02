using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicControll : MonoBehaviour {

    public AudioMixerSnapshot dead;
    public AudioClip[] stings;
    public AudioSource stingSource;
    public float bpm = 128;

    private float m_TransitionIn;
    private float m_QuarterNote;

    // Use this for initialization
    void Start()
    {
        m_QuarterNote = 60 / bpm;
        m_TransitionIn = m_QuarterNote;

    }

     void OnCollisionEnter2D(Collision2D collision)
    {
    	if(collision.gameObject.tag == "Danger")
        {
            dead.TransitionTo(m_TransitionIn);
            PlaySting();
        }
    }

    void PlaySting()
    {
        int randClip = Random.Range(0, stings.Length);
        stingSource.clip = stings[randClip];
        stingSource.Play();
    }

}
