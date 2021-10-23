using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPassRing : MonoBehaviour
{
    // Start is called before the first frame update

    public delegate void destoryBall();
    public static event destoryBall destoryBallinfo;

    private void OnEnable() {
        

    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Ball")){
            scoreContoller.playerScore += 1;
            // Destroy(gameObject);
            destoryBallinfo();
        }
    }


}
