using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    Light flashlight;
    AudioSource audioSource;
    [SerializeField] AudioClip flashlightClick;
    // Start is called before the first frame update
    void Start()
    {
        flashlight = GetComponent<Light>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
		{
            
            audioSource.PlayOneShot(flashlightClick);
            if(flashlight.enabled)
			{
				flashlight.enabled = false;
			}
			else
			{
				flashlight.enabled = true;
			}
        }
    }
}
