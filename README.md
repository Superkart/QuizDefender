# Quiz Defender

**A Multiplayer Physics-Based Quiz Challenge Built in Unity**

**Demo Video**:  [Watch Gameplay on YouTube](https://www.youtube.com/watch?v=WDOzIeUmMRM)

---

## Overview

**Quiz Defender** is a two-player competitive multiplayer quiz game where players race to answer computer science questions inside a stylized digital arena. The game combines real-time networking using Unity Netcode, physics-driven player interactions, and dynamic visual feedback to create an engaging educational experience that tests both knowledge and reflexes.

Players compete head-to-head in a synchronized quiz environment where correct answers stop the timer and wrong answers trigger physics-based pushback penalties. The player with the fastest cumulative time across all questions wins. 

---

## Key Features

### Multiplayer Networking
- **Unity Netcode for GameObjects**: Authoritative server architecture with client-server synchronization
- **Unity Relay Services**: Seamless matchmaking with join code system for easy connection
- **Real-Time State Synchronization**: Questions, timers, and player states synchronized across all clients
- **Server-Authoritative Answer Validation**: Prevents cheating with server-side answer checking
- **ClientRpc and ServerRpc**: Efficient network communication patterns

### Physics-Based Gameplay
- **Rigidbody Physics**: Wrong answers trigger impulse forces that push players backward
- **Collision Detection**: Trigger-based answer selection through player-cube collisions
- **Velocity Management**: Automatic physics reset between questions to prevent momentum carryover
- **Force Application**: Synchronized pushback mechanics across networked clients

### Dynamic Visual Feedback
- **Rotating Billboard**: Central question display with camera-facing rotation for visibility
- **Floating Answer Cubes**: Smooth sine-wave animation for enhanced immersion
- **Dynamic Floor Materials**: Arena floor changes material after each question for visual progression
- **Directional Lighting**:  HDRP lighting system for atmospheric arena environment
- **TextMeshPro UI**: High-quality text rendering for questions and timers

### Game Flow and Timing System
- **Global Countdown**:  10-second pre-game countdown before questions begin
- **Question Timer**: 30-second timer per question with real-time UI updates
- **Personal Timers**: Individual player timers track speed for competitive scoring
- **Movement Freeze**: Players start frozen until countdown completes
- **Automatic Progression**: Questions advance when both players answer or time expires

### Player Controls
- **Movement**: W/A/S/D keys for directional movement
- **Answer Selection**:  Walk into answer cubes (A/B/C/D) to submit
- **Quit**:  Escape key to exit game (works in both editor and build)

---

## Technical Implementation

### Architecture and Design Patterns

**Authoritative Server Pattern**
- Host acts as server for game logic and validation
- Client sends input and receives state updates
- Prevents client-side cheating and ensures fairness

**NetworkBehaviour Components**
- `GameTimerManager`: Central game state controller on server
- `PlayerController`: Client-side input and collision detection
- `PlayerMovement`: Networked movement and physics synchronization

**Component-Based Design**
- Modular scripts for separation of concerns
- Reusable components for UI, physics, and networking
- Clean interfaces between game systems

### Core Systems

#### Networking System
```
ComputerEscape_V2/Assets/Scripts/
├── NetworkManagerUI.cs        # Relay connection and lobby management
├── PlayerMovement.cs          # Networked player movement and physics
└── PlayerController.cs        # Player spawn and answer submission
```

**Key Features:**
- Async/await pattern for Relay service integration
- Anonymous authentication with Unity Authentication
- Join code generation and validation
- Host-only start game button with proper authorization
- Client-server spawn point assignment

#### Game Logic System
```
ComputerEscape_V2/Assets/Scripts/KarthiksScripts/
├── GameTimerManager.cs        # Core game loop and state management
├── AnswerDisplay.cs           # Answer cube text and animation
└── QuitGame.cs                # Application quit handler
```

**Game State Management:**
- Question progression with index tracking
- Individual player answer states (player1Answered, player2Answered)
- Global and personal timer synchronization
- Win condition evaluation and end game logic

**Question System:**
- Computer science themed questions about CPU architecture
- Array-based question and answer storage
- Server-authoritative answer validation
- Dynamic question text updates via ClientRpc

#### Physics and Movement
```csharp
// Pushback Physics Implementation
public void ApplyPushback()
{
    Rigidbody rb = GetComponent<Rigidbody>();
    rb.AddForce(-transform.forward * 500f, ForceMode.Impulse);
}

// Position Reset Between Questions
Rigidbody playerRigidbody = player.GetComponent<Rigidbody>();
playerRigidbody.linearVelocity = Vector3.zero;
playerRigidbody.angularVelocity = Vector3.zero;
```

**Features:**
- Impulse-based force application for immediate feedback
- Velocity zeroing to prevent physics carryover
- Synchronized physics state across network
- Transform-based directional pushback

#### UI and Visual Effects
```
ComputerEscape_V2/Assets/Scripts/
├── Billboard.cs               # Camera-facing rotation for question board
├── FloorMaterialManager.cs    # Dynamic floor material switching
└── AnswerDisplay.cs           # Floating cube animation
```

**Visual Systems:**
- LookAtCamera and CameraForward billboard modes
- Axis-locked rotation for controlled orientation
- Sine-wave floating animation with configurable amplitude
- Material array indexing for floor progression
- TextMeshPro for crisp text rendering

---

## Technologies and Tools

### Unity Systems
- **Unity 2022.3 or newer**: Long-term support game engine
- **Unity Netcode for GameObjects**: Official Unity multiplayer framework
- **Unity Relay Services**: Cloud-based relay for NAT traversal
- **Unity Transport (UTP)**: Low-level networking transport layer
- **Unity Authentication**: Anonymous player sign-in
- **HDRP (High Definition Render Pipeline)**: Advanced rendering and lighting
- **TextMeshPro**:  Professional text rendering

### Programming
- **C# (. NET Standard 2.1)**: Primary programming language (94.1%)
- **HLSL**:  High-Level Shader Language (4.2%)
- **ShaderLab**: Unity shader definitions (1.3%)
- **ASP.NET**:  Configuration files (0.2%)

### Networking Patterns
- **ClientRpc**: Server-to-client remote procedure calls
- **ServerRpc**:  Client-to-server remote procedure calls
- **NetworkVariable**: Synchronized state variables
- **NetworkBehaviour**: Base class for networked components

---

## Project Structure

```
QuizDefender/
├── ComputerEscape_V2/
│   ├── Assets/
│   │   └── Scripts/
│   │       ├── Billboard.cs
│   │       ├── FloorMaterialManager. cs
│   │       ├── NetworkManagerUI.cs
│   │       ├── PlayerMovement.cs
│   │       └── KarthiksScripts/
│   │           ├── GameTimerManager.cs
│   │           ├── PlayerController.cs
│   │           ├── AnswerDisplay. cs
│   │           └── QuitGame.cs
│   ├── ProjectSettings/
│   └── Packages/
├── Build/
│   └── QuizDefender.exe
├── . gitignore
├── . gitattributes
└── README.md
```

---

## Getting Started

### Prerequisites
- Unity Hub (latest version)
- Unity Editor 2022.3 or newer
- Unity Account (for Relay services)
- Windows 10/11 (for build executable)

### Installation

**Option 1: Run via Unity Editor**

1. Clone the repository
   ```bash
   git clone https://github.com/Superkart/QuizDefender.git
   cd QuizDefender
   ```

2. Open in Unity Hub
   - Open Unity Hub
   - Click "Add" and navigate to `QuizDefender/ComputerEscape_V2` folder
   - Select Unity version 2022.3 or newer
   - Open the project

3. Wait for package resolution and compilation

4. Press Play in Unity Editor

**Option 2: Run Executable (Windows)**

1. Download the latest build from the [Build folder](Build/)

2. Extract the ZIP file

3. Run `QuizDefender.exe` from the Output folder

---

## How to Play

### Starting a Match

**Host Player:**
1. Click "Host" button to create a new game session
2. Share the displayed Join Code with the other player
3. Wait for client to connect
4. Click "Start Game" button to begin countdown

**Client Player:**
1. Enter the Join Code provided by the host
2. Click "Join" button to connect
3. Wait for host to start the game

### Gameplay Instructions

1. **Pre-Game Countdown**: Both players start frozen during 10-second countdown

2. **Question Phase**:
   - Read the question displayed on the central rotating billboard
   - Move using W/A/S/D keys
   - Walk into an answer cube (A/B/C/D) to select your answer

3. **Answer Feedback**:
   - **Correct Answer**: Your personal timer freezes for that question
   - **Wrong Answer**:  Physics pushback force propels you backward

4. **Question Progression**:
   - Questions auto-advance when both players answer or 30-second timer expires
   - Players teleport back to spawn points between questions
   - Floor material changes to indicate progression

5. **End Game**:  After all questions, the player with the lowest total time wins

---

## Game Controls

| Input | Action |
|-------|--------|
| W | Move Forward |
| A | Move Left |
| S | Move Backward |
| D | Move Right |
| Walk into Cube | Submit Answer |
| Escape | Quit Game |

---

## Code Highlights

### Multiplayer Synchronization
```csharp
[ClientRpc]
private void UpdateQuestionClientRpc(string newQuestion)
{
    questionText.text = newQuestion;
}

[ServerRpc(RequireOwnership = false)]
private void SubmitAnswerServerRpc(ulong playerId, string answer)
{
    GameTimerManager gameTimerManager = FindObjectOfType<GameTimerManager>();
    gameTimerManager.CheckAnswer(playerId, answer);
}
```

### Countdown System
```csharp
private IEnumerator CountdownCoroutine()
{
    for (int i = 10; i > 0; i--)
    {
        UpdateCountdownClientRpc(i. ToString());
        yield return new WaitForSecondsRealtime(1f);
    }
    UpdateCountdownClientRpc("Start!");
    yield return new WaitForSecondsRealtime(1f);
    StartGame();
}
```

### Answer Validation
```csharp
public void CheckAnswer(ulong playerId, string answer)
{
    bool isCorrect = answer == correctAnswers[currentQuestionIndex];
    
    if (isCorrect)
    {
        if (playerId == 0) player1Answered = true;
        else if (playerId == 1) player2Answered = true;
    }
    else
    {
        PlayerMovement player = FindPlayerById(playerId);
        player.ApplyPushback();  // Physics penalty
    }
}
```

---

## Development Highlights

### What Makes This Project Stand Out

**Authoritative Server Architecture**
- Implemented server-authoritative game logic to prevent cheating
- Proper ownership checks on networked operations
- Clean separation between client input and server validation

**Unity Relay Integration**
- Seamless peer-to-peer connection through Unity cloud services
- No port forwarding or network configuration required
- Join code system for easy matchmaking

**Synchronized Game State**
- Real-time timer synchronization across clients
- Question progression managed server-side
- Player state tracking (answered/not answered)

**Physics-Based Feedback**
- Immediate physical consequence for wrong answers
- Networked physics synchronization
- Position and velocity reset between questions

**Professional Code Quality**
- Comprehensive error checking and validation
- Debug logging for network events
- Clean component architecture
- Async/await for modern C# patterns

---

## Known Issues and Troubleshooting

### Common Issues

**Multiplayer Connection Fails**
- Verify Unity project has Relay services enabled
- Check internet connection
- Ensure both players are using same Unity Relay credentials
- Confirm Unity Authentication is properly configured

**Quitting Doesn't Work in Editor**
- Use standalone executable for proper quit functionality
- In editor, use Unity's Stop button
- Escape key quit works correctly in builds

**Physics Desync**
- Server controls authoritative physics state
- Client-side prediction not implemented
- Minor delay expected in multiplayer environment

---

## Future Enhancements

### Planned Features
- **Leaderboard System**: Track high scores and fastest times
- **Expanded Question Bank**: Multiple categories (cybersecurity, networks, operating systems, data structures)
- **Power-Ups**: Temporary speed boosts or answer hints
- **Mobile Support**: Touch controls and UI adaptation
- **Voice Chat**: Built-in voice communication for players
- **Spectator Mode**: Allow others to watch matches in progress
- **Custom Question Sets**: Allow players to create custom quiz content
- **AI Opponents**: Single-player mode with bot opponents

### Performance Optimizations
- Object pooling for answer cubes
- Network traffic optimization
- Client-side prediction for smoother movement
- Lag compensation techniques

---

## Performance Considerations

- **Target Platform**: PC (Windows/Mac/Linux)
- **Network Requirements**: Broadband internet connection recommended
- **Minimum Players**: 2 (multiplayer only)
- **Maximum Players**:  2 (designed for 1v1 matches)
- **Average Match Duration**: 2-5 minutes depending on question count

---

## Demo Video

Watch the complete gameplay demonstration showcasing: 
- Multiplayer matchmaking with join codes
- Real-time question synchronization
- Physics-based answer feedback
- Dynamic visual effects and UI
- Complete game flow from start to finish

[Watch on YouTube](https://www.youtube.com/watch?v=WDOzIeUmMRM)

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## Developer

**Superkart**

- GitHub: [@Superkart](https://github.com/Superkart)
- Project Repository: [QuizDefender](https://github.com/Superkart/QuizDefender)

---

## Acknowledgments

- **Unity Technologies** for Netcode for GameObjects and Relay services
- **TextMeshPro** for professional text rendering
- **Unity HDRP** for advanced lighting and visual effects
- **Unity Community** for networking tutorials and best practices

---

**Competitive Quiz Gaming | Multiplayer Networking | Educational Entertainment**
