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
        StartCoroutine(GrowPlant());
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        //raycast from position forward
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        
          if (Physics.Raycast(transform.position, fwd, out hit, 10))
            {//if raycast hits gameobject with platerbox tag, compare tag
            if(hit.collider.gameObject.CompareTag("PlanterBox"))
            {//set srpout prefab to active
                SproutPrefab.SetActive(true);
            }
                

            
            }

    }
    IEnumerator GrowPlant()
    {//couroutine waits 3 seconds before setting sprout model as false and rose as active
       yield return new WaitForSeconds(3);
        SproutPrefab.SetActive(false);
        TulipPrefab.SetActive(true);
    }
}

