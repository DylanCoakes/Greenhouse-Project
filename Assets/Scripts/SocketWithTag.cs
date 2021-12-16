using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketWithTag : XRSocketInteractor
    
{
    public string targetTag = string.Empty;
    public AudioSource PlantAudio;

    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && MatchUsingTag(interactable);

    }

    public override bool CanSelect(XRBaseInteractable interactable)
    {
        return base.CanSelect(interactable);
    }
    private bool MatchUsingTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);

    }
    public void Playsound() { PlantAudio.Play(); }

    //public void OnTriggerEnter(Collider other)
    //  {
    // if (other.gameObject.CompareTag(targetTag))
    // {
    //     
    //  }
    // }
}