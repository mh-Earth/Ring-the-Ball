using UnityEngine.UI;
using UnityEngine;

public class setGameoverScore : MonoBehaviour
{

    [SerializeField]
    private Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score:"+ scoreContoller.playerScore.ToString();
    }

}
