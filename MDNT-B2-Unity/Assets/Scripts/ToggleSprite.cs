using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ToggleSprite : MonoBehaviour
{

    public Toggle targetToggle;
    public Sprite onSprite;
    public Sprite offSprite;
    public Image targetBackground;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (targetToggle.isOn == true)
        {
            targetBackground.sprite = offSprite;
        } else
        {
            targetBackground.sprite = onSprite;
        }
    }
}
