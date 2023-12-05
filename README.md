# Kagui the Bat - Endless Runner Game

[![Video Demo](https://img.youtube.com/vi/u05R-xR_e2w/0.jpg)](https://www.youtube.com/watch?v=u05R-xR_e2w)<br>
<br>
[![Game Demo](https://img.shields.io/badge/Play%20Demo-Unity%20WebGL-brightgreen)](https://play.unity.com/mg/other/kagui-the-bat)

This project, developed as the final submission for CS50x, is an engaging endless runner game built using Unity. It showcases an endless loop of the game environment, employing various scripts written in C# within Visual Studio.

## Overview

The game mechanics revolve around a player-controlled character maneuvering through dynamically generated traps within a scrolling environment. Several essential scripts define distinct functionalities within the game:

### Player Movement (Script: Player)

Controlled within the Update method, this script manages the player's vertical movement using the W (up) and S (down) keys. The FixedUpdate method calculates the player's movement speed, ideal for objects governed by Unity's physics engine.

### Camera Control (Script: CameraMovement)

The camera's movement logic resides in this script, adjusting its position based on a speed variable within the Update method.

### Creating Endless Background (Script: LoopingBackground)

Simulating an infinite background loop by rendering the image in a continuous motion, calculated similarly to the camera movement.

### Trap Generation (Script: SpawnTraps)

This script generates randomized spawn points within the game boundaries, ensuring traps don't clip into terrain or appear off-screen. Traps spawn outside the visible screen and smoothly despawn to enhance the gaming experience.

### Collision Management (Script: Traps)

Handles collisions between the player and traps, triggering events like player character destruction upon collision and trap removal upon reaching the despawn point.

### Score Tracking (Script: ScoreManager)

Tracks and updates the player's score, displayed prominently during gameplay and also included in the leaderboard. The highscore variable continually updates when surpassed.

### Highscore Display (Script: HighScore)

Converts the highscore variable to a string for display purposes. It also includes a method to reset the saved highscore.

### Game Over Screen (Script: GameOverManager)

Initiates the Game Over status based on specific conditions (e.g., collision with a trap). It displays the final score, allows game restart, and provides options to return to the main menu or access settings.

### Menu Management (Script: MenuManager)

Manages game settings like volume control and scene transitions between the main menu and gameplay.

### Audio Control (Script: BackgroundMusic)

Starts and controls the game's background music.

---
