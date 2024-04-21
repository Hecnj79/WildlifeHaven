using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    [SerializeField] Animator anim;

    private bool isCollectionOpen = false;

    private AudioManager audioManager;

    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void ToggleCollection()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        isCollectionOpen = !isCollectionOpen;
        anim.SetBool("CollectionOpen", isCollectionOpen);
    }
}
