using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private GameObject player;
    [SerializeField] GameOverManager gameOverManager;

    // Start is called before the first frame update
    void Start()
    {
        // Assign the player sprite to a variable
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Tag "Border" is assigned to an area off screen
        if(collision.tag == "Border")
        {
            // Destroy the traps after they leave the screen to reduce amount of loaded assets ingame
            Destroy(this.gameObject);
        }

        // When the player collides with a trap
        else if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy the player sprite and load the Game Over screen
            Destroy(player);
            GameOverManager.isGameOver = true;
        }
    }
}
