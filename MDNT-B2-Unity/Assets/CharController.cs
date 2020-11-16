using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{

    public AudioSource[] drumsAudioObjects;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (drumsAudioObjects[0].mute == false || drumsAudioObjects[1].mute == false || drumsAudioObjects[2].mute == false || drumsAudioObjects[3].mute == false || drumsAudioObjects[4].mute == false)
        {
            anim.SetBool("drumsOn", true);
        }
        else
        {
            anim.SetBool("drumsOn", false);
        }
    }
}
