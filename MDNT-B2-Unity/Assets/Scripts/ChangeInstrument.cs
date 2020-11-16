using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeInstrument : MonoBehaviour
{
    public GameObject[] Instrument;
    private int selectedInstrument;

    
    
    // Start is called before the first frame update
    void Start()
    {
        Instrument[0].SetActive(true);
        Instrument[1].SetActive(false);
        Instrument[2].SetActive(false);
        Instrument[3].SetActive(false);
        Instrument[4].SetActive(false);
        Instrument[5].SetActive(false);

    }

    public void SelectGuitar()
    {
        Instrument[0].SetActive(false);
        Instrument[1].SetActive(true);
        Instrument[2].SetActive(false);
        Instrument[3].SetActive(false);
        Instrument[4].SetActive(false);
        Instrument[5].SetActive(true);
    }

    public void SelectDrum()
    {
        Instrument[0].SetActive(false);
        Instrument[1].SetActive(false);
        Instrument[2].SetActive(true);
        Instrument[3].SetActive(false);
        Instrument[4].SetActive(false);
        Instrument[5].SetActive(false);
    }

    public void SelectPiano()
    {
        Instrument[0].SetActive(false);
        Instrument[1].SetActive(false);
        Instrument[2].SetActive(false);
        Instrument[3].SetActive(true);
        Instrument[4].SetActive(true);
        Instrument[5].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
