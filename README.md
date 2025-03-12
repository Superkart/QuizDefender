CS 426 - Assignment 4: Physics, Textures, and Lights
Project Name: Computer Security Challenge
Group Name: Ctrl Freaks
Developer: Karthik Ragi

Project Overview:
This project builds upon Assignment 2 by integrating new features including physics-based mechanics, lighting enhancements, and interactive billboards. The game is a multiplayer quiz challenge where players navigate through a computer system while answering computer architecture-related questions.

Implemented Features:

Multiplayer Setup:
The game supports two players, a host and a client, using Unity Netcode and Relay.
Players see the same questions, interact with answer cubes, and their answers affect game progression.

Lighting Enhancements:
Lights have been added to answer cubes to highlight available choices.
Directional lighting has been added to the billboard for improved visibility.

Physics-Based Interactions:
Pushback on Wrong Answer: If a player selects the wrong answer, they are pushed backward to simulate a rejection effect. This is implemented using Unity Rigidbody physics.
Floating Answer Cubes: Answer cubes now float up and down smoothly, making them more interactive and visually appealing.

Interactive Billboard:
The billboard now has a texture applied, making it resemble a real-world display.
The billboard rotates slowly to create a dynamic experience.

Game Flow and Visual Effects:
Players start with a countdown timer of ten seconds before the game begins.
Answering correctly freezes that player's timer until the next question.
The floor material changes after every question, cycling through pre-defined materials.

Quit Game Feature:
Players can exit the game by pressing the Escape key, ensuring a smooth experience.

How to Run the Game:

Using GitHub Repository:
Clone the repository using the following command:
git clone https://github.com/Superkart/cs426_Ragi_Karthik_Asgn4.git
Open Unity and load the project.
Click "Play" to start the game.

Running the Executable:
Download the Windows Build from the provided Google Drive link.
Extract the zip file.
Run the ComputerEscape.exe file inside the Output folder.

Controls:
Move Player: W, A, S, D
Select Answer: Walk into the answer cube
Quit Game: Escape Key

How to Play:
The host starts the game and shares the join code.
The client joins using the code.
Players read the question displayed on the billboard.
Players walk into an answer cube labeled A, B, C, or D to select their answer.
If a player selects the correct answer, their timer freezes. If they select the wrong answer, they are pushed back.
The floor material updates after every question.
The player with the lowest timer at the end of the game wins.

Assignment Submission Details:

GitHub Repository: clone https://github.com/Superkart/cs426_Ragi_Karthik_Asgn4.git

Google Drive Link for Executable: [Insert Link Here]

TA GitHub Username: nafiul-nipu

Build Folder: Build (inside repo)

Branch Used: main

Notes and Additional Information:
If multiplayer does not work, ensure Unity Relay is properly configured.
If the Escape key does not quit, try running the game as an executable instead of inside Unity.
Thank you for reviewing my project.