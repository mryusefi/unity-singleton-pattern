using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayers : MonoBehaviour
{
    // you can implement like this 
    public static AudioPlayers instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    /*
    ++ Or if you want dont destroy when change scene use this 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != null)
        {
            Destroy(this);
        }
    }

    ++ also you can implement like this :

    public static AudioPlayers _instance()
    {
        if (instance == null)
        {
            instance = new AudioPlayers();
        }
        return instance;
    }
    */

    // function or variable you want to use another script must be public
    [SerializeField] private AudioClip Click;

    public void PlayClickSound()
    {
        GetComponent<AudioSource>().PlayOneShot(Click);
    }
}
