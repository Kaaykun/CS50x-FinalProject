using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    public static bool isGameOver;
    [SerializeField] Text currentScore;
    [SerializeField] Text finalScore;

    // Awake is called to initialize variable before the game starts
    private void Awake()
    {
        // Create variable to track if the game is ongoing or over
        isGameOver = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true)
        {
            // If the player dies, launch the Game Over screen and pass score information it
            gameOverScreen.SetActive(true);
            finalScore.text = currentScore.text;
            currentScore.gameObject.SetActive(false);
            
        }
    }

    // Function to restart the game from the Game Over screen on button click
    public void Restart()
    {
        isGameOver = false;
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
