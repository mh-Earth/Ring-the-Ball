using UnityEngine;
using System.Collections;
public class BalllSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject originalBallperfab;
    // Start is called before the first frame update
    [SerializeField]
    private GameObject[] spanwerPoints;
    private GameObject CloneBall;

    private int ranndomX;
    private float ballVelocityY = 1f;

    private Rigidbody2D rb;
    private void Start() {
        StartCoroutine(spawnBall());
    }
    IEnumerator spawnBall(){

        while(true){

            yield return new WaitForSeconds(.8f);
            ranndomX = Random.Range(0,spanwerPoints.Length);

            CloneBall = Instantiate(originalBallperfab);
            CloneBall.transform.position = spanwerPoints[ranndomX].transform.position;
            rb = CloneBall.GetComponent<Rigidbody2D>();
            // rb.gravityScale = ballGravety;
            rb.velocity = new Vector2(0f,ballVelocityY);

            if(scoreContoller.playerScore > 100 && ballVelocityY < 3f){
                ballVelocityY += .01f;

            }
                

        }




    }
}
