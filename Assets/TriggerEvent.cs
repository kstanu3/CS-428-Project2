using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TriggerEvent : MonoBehaviour
{
    public GameObject button;
    Animator animation;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        button = GameObject.Find("Button");
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");

        animation.SetBool("TriggerEvent", true);
        if (!audio.isPlaying)
        {
            audio.Play();
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");

        animation.SetBool("TriggerEvent", false);
    }
    

}
