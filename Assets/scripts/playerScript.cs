using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{   

    [SerializeField]
    private GameObject[] ballSpawners;

    [SerializeField]
    private GameObject RingPrefab;

    private Vector3 newPos;
    void Update()
    {
        if(Input.touchCount > 0){

            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);


            if(touchPosition.x > -1f && touchPosition.x < 1){
                newPos = new Vector3(ballSpawners[1].transform.position.x,RingPrefab.transform.position.y,0f);
                RingPrefab.transform.position = newPos;
                
            } 
            else if(touchPosition.x < -1f){
                newPos = new Vector3(ballSpawners[0].transform.position.x,RingPrefab.transform.position.y,0f);
                RingPrefab.transform.position = newPos;
                
            } 
            else if(touchPosition.x > 1f){
                newPos = new Vector3(ballSpawners[2].transform.position.x,RingPrefab.transform.position.y,0f);
                RingPrefab.transform.position = newPos;
                
            } 
        }
        
    }
}
