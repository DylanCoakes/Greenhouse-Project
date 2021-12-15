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
    
   
    // Start is called before the first frame update
    void Start()
    {//start coroutine
        
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        //raycast from position forward
        Vector3 fwd = transform.TransformDirection(Vector3.forward) * 5;

        
          if (Physics.Raycast(transform.position, fwd, out hit ))
            {//if raycast hits gameobject with platerbox tag, compare tag
            if(hit.collider.gameObject.CompareTag("PlanterBox"))
            {//set srpout prefab to active
                SproutPrefab.SetActive(true);
                StartCoroutine(GrowPlant());
            }
                

            
            }

    }
    IEnumerator GrowPlant()
    {//couroutine waits 3 seconds before setting sprout model as false and rose as active
       yield return new WaitForSeconds(3);
        Destroy(gameObject, SproutPrefab,.5f);
        TulipPrefab.SetActive(true);
    }
    // does this work?
    private void Destroy(GameObject gameObject, GameObject sproutPrefab, float v)
    {
        throw new NotImplementedException();
    }
}

