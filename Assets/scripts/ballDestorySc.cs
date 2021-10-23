using UnityEngine;
using UnityEngine.SceneManagement;
public class ballDestorySc : MonoBehaviour
{

    private void OnEnable() {
        
        // destoryCollidball  += destoryBallinfo();

        ballPassRing.destoryBallinfo += destoryCollidball;

    }


    private void OnDisable() {
        
        ballPassRing.destoryBallinfo -= destoryCollidball;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Collector")){
            // Destroy(gameObject,.1f);
            SceneManager.LoadScene("game over");

        }
    }

    public void destoryCollidball(){

        Destroy(gameObject,.1f);


    }

}
