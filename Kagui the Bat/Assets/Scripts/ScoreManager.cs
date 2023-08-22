using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text scoreText;
    float currentScore;
    public static int highScore;
    [SerializeField] static bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        // Assign the text component to a variable
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // Add a point for every second the player survives
        AddPoint();
    }

    void AddPoint()
    {
        // Keep adding points to the counter as long as the player is alive
        if (GameOverManager.isGameOver != true)
        {
            // Add point and convert int to string so that it can be displayed in a text object
            currentScore += 1 * Time.deltaTime;
            scoreText.text = ((int)currentScore).ToString();

            // Assign new highscore if old highscore is beaten
            if (highScore < (int)currentScore)
            {
                highScore = (int)currentScore;
            }
        }
    }
}
