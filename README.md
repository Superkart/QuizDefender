Quiz Defender

A Multiplayer Physics-Based Quiz Challenge Built in Unity

Overview

Quiz Defender is a two-player multiplayer quiz game where players compete to answer computer science-themed questions inside a stylized digital arena. The game combines real-time networking, physics-driven interactions, and dynamic lighting to create a fast-paced, engaging experience that tests both reflexes and knowledge.

Key Features

Multiplayer System (Unity Netcode + Relay):
Host and client players join the same session, sharing synchronized questions and gameplay states.

Physics-Based Gameplay:

Wrong answers push the player backward using Rigidbody physics.

Floating answer cubes animate smoothly to enhance immersion.

Dynamic Lighting and Textures:
Directional lights and textured materials bring the quiz arena to life.
The rotating billboard displays the current question, adding movement and depth.

Game Flow Logic:
A global countdown timer begins each round.

Correct answers freeze the player’s personal timer.

Wrong answers trigger pushback.

The arena floor material changes after each question for visual feedback.

Player Controls:

Move: W, A, S, D

Answer: Walk into a cube (A/B/C/D)

Quit: Escape

How to Run

Option 1 — Run via Unity:

git clone https://github.com/Superkart/QuizDefender.git


Open the project in Unity 2022.3 or newer, and press Play.

Option 2 — Run Executable (Windows):

Download the latest build

Extract the ZIP file.

Run QuizDefender.exe from the Output folder.

Gameplay Instructions

Host starts the game and shares the join code.

Client joins using that code.

Both players read the question on the central billboard.

Walk into an answer cube to select your choice.

Correct answers freeze your timer; wrong answers push you back.

After all questions, the player with the lowest total time wins.

Demo Video

Watch Gameplay on YouTube

Tools and Technologies

Unity (C#)

Netcode for GameObjects

Unity Relay Services

Rigidbody Physics System

HDRP Lighting and Material Effects

Troubleshooting

If multiplayer does not connect, verify Unity Relay credentials.

If quitting does not work inside the Unity Editor, try the standalone executable.

Future Enhancements

Add leaderboard and scoring.

Expand question categories (cybersecurity, networks, operating systems).

Add mobile controls and touch UI.
