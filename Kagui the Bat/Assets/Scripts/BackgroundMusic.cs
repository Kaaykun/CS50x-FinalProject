using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;

    // Awake is called to initialize variable before the game starts
    void Awake()
    {
        // If / Else statement to make sure background music is not loaded multiple times
        if (backgroundMusic == null)
        {
            // Assign audio to the gameobject and make sure it is not turned off between different screens (main menu, game, game over screens)
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
