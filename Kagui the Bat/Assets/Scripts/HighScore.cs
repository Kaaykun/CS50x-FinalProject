using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField] Text highScore;

    // Update is called once per frame
    void Update()
    {
        // Take highscore value and convert int to string so that it can be displayed in a text object
        highScore.text = ((int)ScoreManager.highScore).ToString();
    }

    // Function to reset highscore to 0 on button click
    public void ResetHighScore()
    {
        ScoreManager.highScore = 0;
    }
}
