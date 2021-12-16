using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastWater : MonoBehaviour
{
    [SerializeField]
    GameObject SproutPrefab;
    [SerializeField]
    GameObject TulipPrefab;
    private bool watering = false;
    public AudioSource Wand;
    // Start is called before the first frame update
    void Start()
    {//start coroutine
        
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        //raycast from position forward
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        
          if (Physics.Raycast(transform.position, fwd, out hit, 2f)&& !watering)
            {//if raycast hits gameobject with platerbox tag, compare tag
           
            if(hit.collider.gameObject.CompareTag("PlanterBox"))
            {//set sprout prefab to active
                SproutPrefab.SetActive(true);
                watering = true;
                StartCoroutine(GrowPlant());
            }
                

            
            }

    }
    IEnumerator GrowPlant()
    {//couroutine waits 5 seconds before setting sprout model as false and tulip as active
       yield return new WaitForSeconds(5);

        TulipPrefab.SetActive(true);
        Wand.Play();
        Destroy(SproutPrefab);
    }

}
   

    

