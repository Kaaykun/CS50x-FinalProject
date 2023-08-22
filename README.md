# Kagui the Bat
#### Video Demo:  <https://www.youtube.com/watch?v=u05R-xR_e2w>
#### Game Demo: <https://play.unity.com/mg/other/kagui-the-bat>
#### Description:

For my final project of the CS50x course, I created an endless runner type Game using Unity. 
All scripts within the project were written in C# using Virtual Studio.

For better understanding of my code, I added comments within each script, but I will go into further detail below. In my game, the player and trap sprites never actually move in horizontal direction, instead I simulate movement by looping the background and terrain as well as the main camera. 

Some reoccuring elements are the "Start()", "Update()" and "Awake()" method. These are Unity default methods and each has a specific role.
____________________________________________________________________________________________________________________________________________
Start is called exactly once in the lifetime of the script and always before the very first update method is called.
Update is called on every game frame and therefore used for any kind of game behavior that can change every frame.
Awake is called when the script is loaded and executed even before the Start method is called. Most of the time, this is used to initialize game states etc.

7.1) Script: Player
      In this script, I control the movement of the player sprite within the Update method. By Unity default, the vertical directions can be controlled on a keyboard using the W (up) and S (down) keys.
      Furthermore, the FixedUpdate method holds the movement speed calculation of the player. This method type is mostly used when dealing with a rigidbody gameobject (in other words, a gameobject that is subject to Unitys physics engine).


7.2) Script: CameraMovement
      In this script, I control the movement of the camera within the Update method. Each time the method is called, the camera position is given a new position by calculating the value using a speed variable.

7.3) Script: LoopingBackground
      In this script, I simulate an endless background in the Update method. In theory, the image file used for the background of my game is only 1080 pixels wide, with this script however it appears as if the background is constantly moving and endless. This movement is calculate similar to the camera movement using a speed variable and rendering the image in a loop.

7.4) Script: SpawnTraps
      In this script, I generate randomized spawn points for the traps within the games borders. The floats maxX and minX limit the randomizable area for the spawn points in vertical direction, so that the traps dont clip into the terrain or appear off screen. The maxY and minY are set to be wider than the visible screen because I wanted to spawn the traps outside of the game window, as spawning them in sight of the player is not optimal. The same applies when despawning them - it is nicer to look at the traps moving out of sight, rather than instantly removing the from the visible screen from one frame to the next.

7.5) Script: Traps
      In this script, I manage collision events between the player and traps as well as between the despawn point and traps. To do so, I assign the players gameobject (Kagui, the bat sprite) to a variable in the Start method. Then, I check for collision with an if statement. Should the player collide with any of the traps, Kagui is destroyed, which disables any player control over the character, and the Game Over screen is displayed.
      To reduce the load of the game on the players computer, instead of leaving the traps existing offscreen, I created another collision event - the despawn point. Slightly offscreen there is an area invisble box, which when coming into contact with a trap deletes said trap from the game.

7.6) Script: ScoreManager
      In this script, I count and add points to a score element, which is visible to the player in the top center of the game. For each second the player is alive, 1 point is added. Should the player reach a score that is higher than the current Highscore, the highscore variable is also updated continuously.
      These two variables are then passed to the Game Over screen, as well as the Leaderboard in the main menu.

7.7) Script: HighScore
      In this script, I pass the highscore variable from the ScoreManager to the Update method to convert the integer to a string, which can then be used to display the highscore in the leaderboard. 
      In addition, the ResetHighScore method resets the saved highscore back to 0 when the respective button in the settings menu is clicked.

7.8) Script: GameOverManager
      In this script, the game checks previously defind conditions (such as collision with a trap) that initialize the Game Over status. If these conditions are met, the screen will be displayed and the Update method pulls the game score from the ScoreManager and displays it in the center of the screen. 
      In this menu, the player has the option to call the Restart method, which does exactly what the name suggests - starting a new game with a fresh score counting up from 0. Furthermore, the player can return to the main menu or enter the settings, these functions however will be explained in the next script.

7.9) Script: MenuManager
      In this script, I set a default volume for the music when the game is started, as well as provide an option to adjust said volume. The player has the option to use a volume slider to increase or decrease the volume, or completely mute the game on button click.
      The LoadGame method is used to switch between main menu and gameplay. As previously mentioned, I call this function when the player clicks the Home button in the game over screen and also when pressing the Play button in the main menu. The method take an integer name Index as input. Each scene has an index number, starting from 0 - in my case, i have the Main Menu scene (0) and the Game Scene (1). The respective buttons on the UI have been programmed to pass the correct index to the method when clicked.

7.10) BackgroundMusic
        In this script, I start playing the games audio when it is launched and pass the audio clip so that the game knows which song to play.
