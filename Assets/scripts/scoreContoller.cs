using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreContoller : MonoBehaviour
{   

    public static int playerScore = 0;
    [SerializeField]
    private Text playerScoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate() {
        playerScoreText.text = playerScore.ToString();
    }
}
