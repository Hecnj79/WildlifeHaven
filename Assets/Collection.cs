using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    [SerializeField] Animator anim;

    private bool isCollectionOpen = false;

    public void ToggleCollection()
    {
        isCollectionOpen = !isCollectionOpen;
        anim.SetBool("CollectionOpen", isCollectionOpen);
    }
}
