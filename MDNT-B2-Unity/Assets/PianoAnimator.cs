using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PianoAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        anim.SetBool("isOver", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        anim.SetBool("isOver", false);
    }
}
