using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class HandleUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject infoUI;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        infoUI.SetActive(true);
    }
    
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        infoUI.SetActive(false);
    }


}
