using UnityEngine;
using UnityEngine.SceneManagement;

public class gamePlayController : MonoBehaviour
{

    public void Exit(){
        Application.Quit();
    }

    public void reload(){
        SceneManager.LoadScene("gameplay");
        scoreContoller.playerScore = 0;
    }


}
