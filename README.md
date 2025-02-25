# 🎮 The World's Hardest Game 3D - With Just 5 LEVEL 🔥

## Overview 📝
This project is a 3D adaptation of *The World's Hardest Game*, featuring only five incredibly challenging levels. The game is designed to test players' reflexes, patience, and problem-solving skills. If you think you're good at tough games, this one will push you to your limits! 💀

## Features ✨
- **📸 Custom Textures**: The game features balls with my own photo on them for a personal touch!
- **🌍 3D Environment**: A modern twist on the classic *The World's Hardest Game* experience.
- **💀 5 Insanely Difficult Levels**: Each level is crafted to challenge your movement precision and strategy.
- **🎮 Simple Controls, Complex Gameplay**: Easy to learn, hard to master.
- **🎨 Minimalistic Aesthetic**: Clean, focused design with a strong emphasis on gameplay.

## Installation & Setup 🛠️
1. Clone the repository:
   ```bash
   git clone https://github.com/DoritosLover1/The-World-s-Hardest-Game-3D-With-Just-5-LEVEL.git
   ```
2. Open the project in Unity (recommended version: *6000.0.38f1-LTS*).
3. Build and run the game.

## How to Play 🎯
- Use **WASD** or **Arrow Keys** to move your character.
- Avoid all moving obstacles. ⚠️
- Reach the goal 🏆 to complete each level.
- Precision and patience are key! 🕹️

## Contributions 🤝
Contributions are welcome! If you have ideas for improvements or bug fixes, feel free to open an issue or submit a pull request. 🚀

## Credits 👑
Developed by **DoritosLover1**.

---

Enjoy the challenge and good luck making it past all 5 levels! 🔥

---

# Unity Scripts Documentation

## 1. AudioManager
### Description
Handles background music and sound effects, ensuring persistence across scenes with a singleton pattern.
### Properties
- `musicSource` (AudioSource): Background music source.
- `SFXSource` (AudioSource): Sound effects source.
- `background`, `death`, `goldSound` (AudioClip): Various sound clips.
- `instance` (AudioManager): Singleton instance.
### Methods
- `Start()`: Plays background music.
- `Awake()`: Implements singleton pattern.
- `PlaySFX(AudioClip clip)`: Plays a sound effect.

## 2. MainMenu
### Description
Manages main menu interactions and scene transitions.
### Properties
- `fadeDuration` (float): Scene transition duration.
### Methods
- `PlayGame()`: Starts scene transition.
- `LoadScene(int sceneIndex)`: Loads the specified scene.

## 3. MouseSensitivitySetting
### Description
Handles mouse sensitivity settings.
### Properties
- `sensitivitySlider` (Slider), `cancelButton`, `applyButton` (Button): UI components.
- `mouseSensitivity` (static float): Current sensitivity.
- `oldSensitivity` (float): Previous sensitivity.
### Methods
- `Start()`: Initializes settings.
- `ApplySensitivity()`: Saves new sensitivity.
- `GetBackOlSensitivity()`: Reverts to previous value.
- `SetMouseSensitivity(float value)`: Updates sensitivity.

## 4. ResolutionManager
### Description
Manages screen resolution settings.
### Properties
- `resolutionDropdown` (TMP_Dropdown), `applyButtonRef`, `cancelButtonRef` (Button): UI components.
- `resolutions` (Resolution[]): Available resolutions.
- `currentResolution` (Resolution): Active resolution.
### Methods
- `Start()`: Initializes resolution options.
- `GetBackOldResolution()`: Restores previous resolution.
- `ApplyResolution()`: Applies selected resolution.

## 5. SoundVolumeSettings
### Description
Manages audio volume settings.
### Properties
- `volumeSlider` (Slider), `cancelButton`, `applyButton` (Button): UI components.
- `soundVolume` (static float): Current volume.
- `oldVolume` (float): Previous volume.
### Methods
- `Start()`: Initializes volume settings.
- `ApplyVolume()`: Saves new volume.
- `GetBackOldVolume()`: Restores previous volume.
- `SetVolumeSetting(float value)`: Updates audio volume.

## 6. DiabloticTrapCode
### Description
Triggers a trap when the player enters a zone.
### Properties
- `wallOpen`, `wallClosed` (GameObject): Trap walls.
- `trapTextLight` (Light), `trapTextTMP` (GameObject): UI elements.
- `awaitTime` (int): Trap delay.
- `trapBall` (GameObject): Trap object.
### Methods
- `Start()`: Initializes trap state.
- `OnTriggerEnter(Collider other)`: Activates trap and delays trap ball.

## 7. SceneTransition
### Description
Handles scene fade transitions.
### Properties
- `fadeCanvasGroup` (CanvasGroup): UI fade effect.
- `fadeDuration` (float): Fade duration.
### Methods
- `Start()`: Initiates fade-in.
- `FadeIn()`: Gradually reveals the scene.
- `FadeOut(string sceneName)`: Gradually hides the scene.

## 8. Timer
### Description
Tracks elapsed playtime.
### Properties
- `timerText` (TextMeshProUGUI): UI text for timer.
### Methods
- `Update()`: Updates elapsed time display.

## 9. BallsMovement
### Description
Handles ball movement and collision.
### Properties
- `moveSpeed` (float): Movement speed.
- `myTexture` (Texture): Ball texture.
### Methods
- `Start()`: Applies texture.
- `Update()`: Moves ball.
- `OnCollisionEnter(Collision other)`: Changes direction or resets scene.
- `BallMove()`: Moves the ball.

## 10. Spinner
### Description
Rotates an object continuously.
### Properties
- `xRotation`, `yRotation`, `zRotation` (float): Rotation speeds.
### Methods
- `Update()`: Rotates object.
- `OnCollisionEnter(Collision other)`: Resets scene if colliding with player.

## 11. MouseLook
### Description
Handles first-person camera movement.
### Properties
- `playerBody` (Transform): Player reference.
### Methods
- `Start()`: Locks cursor.
- `LateUpdate()`: Rotates player.

## 12. NextLevelTeleporter
### Description
Transitions to the next level upon trigger.
### Properties
- `level` (int): Target scene index.
- `fadeDuration` (float): Delay duration.
### Methods
- `OnTriggerEnter(Collider other)`: Starts scene transition.
- `PlayGame()`: Initiates scene load.

## 13. PlayerController
### Description
Handles player movement.
### Properties
- `moveSpeed` (float): Movement speed.
- `controller` (CharacterController): Character controller reference.
### Methods
- `Update()`: Reads input and moves player.

This documentation provides a structured reference for game scripts, aiding development and maintenance.

