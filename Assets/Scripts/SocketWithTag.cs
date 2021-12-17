using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketWithTag : XRSocketInteractor

{
    public string targetTag = string.Empty;
    public AudioSource PlantAudio;
    public GameObject Sign;
    //when hovering over the area with an object with tag, compare the tags
    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && MatchUsingTag(interactable);

    }

    public override bool CanSelect(XRBaseInteractable interactable)
    {
        return base.CanSelect(interactable);
    }
    //if tags match, snap ojbect to socket
    private bool MatchUsingTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);

    }//plays sounds when the object snaped in place
    public void Playsound() { PlantAudio.Play();
       
        //turn on canvas when sound plays
           Sign.SetActive(true);
            
        

        }
   
    


    

    //public void OnTriggerEnter(Collider other)
    //  {
    // if (other.gameObject.CompareTag(targetTag))
    // {
    //     
    //  }
    // }
}