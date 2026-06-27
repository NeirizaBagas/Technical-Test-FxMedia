# FXMedia Technical Test - Android Top-Down Collecting Game
**Position:** Unity Developer Intern (Android)  
**Developer:** Bagas

An optimized, instant-action Android top-down collecting game built with Unity using primitive shapes. This project is intentionally designed to boot directly into the core gameplay loop to ensure a seamless and efficient testing experience for reviewers.

## 🛠 Project Specifications
- **Engine Version:** Unity 6 LTS (6.4.x)
- **Language:** C#
- **Platform:** Android (Landscape Auto-Rotation)
- **Input System:** New Input System (`Pointer.current` for instant mobile touch response)
- **Navigation:** Unity NavMesh (for dynamic obstacle avoidance)

## 🌟 Features Implemented
### Core Requirements (Must Have)
- [x] **Direct Main Gameplay Scene:** The game instantly boots into the main gameplay without unnecessary menu delays.
- [x] **Player Movement:** High-responsiveness tap-to-move mechanic utilizing modern screen raycasting and `NavMeshAgent`.
- [x] **Camera Follow:** A stabilized top-down perspective camera smoothly tracking the player capsule.
- [x] **Collectible Items:** More than 5 collectible items strategically spawned across the arena.
- [x] **Collection Mechanic:** Precise `OnTriggerEnter` touch-collision logic that handles item collection and immediate disappearance.
- [x] **Scoring & UI Display:** Live score tracking text built with clean, decoupled C# Events/Actions.
- [x] **Obstacles:** Static walls that successfully block the player paths and test NavMesh pathfinding.
- [x] **Android Build:** Fully optimized and packaged into a stable Android APK.

### Bonus Requirements (Nice to Have)
- [x] **Different Item Types:** Categorized via clean `Enum` structures (Normal Coin +1, Bonus Coin +5, and Trap Item -1).
- [x] **Immediate Timer & Game Over:** A 60-second countdown timer that activates immediately upon scene load, triggering a Game Over screen once expired.
- [x] **High Score System:** Persistent score tracking using secure `PlayerPrefs` and string constants.
- [x] **Sound Effects:** Implemented programmatically using `AudioSource.PlayClipAtPoint` to avoid audio truncation upon object destruction.
- [x] **Particle Effects:** Dynamic Burst Particle Systems spawning visual feedback instantly upon item collection.

---

## 🚀 How to Open the Project
1. Clone this repository or download the ZIP file.
2. Open **Unity Hub** -> Click **Add** -> **Add project from disk**.
3. Select the root folder of this project.
4. Ensure the active build target platform is set to **Android** in the Build Settings.

## 📦 How to Build the APK
1. Open the project inside the Unity Editor.
2. Navigate to **File** -> **Build Settings**.
3. Ensure `MainScene` is added and checked under the "Scenes In Build" panel.
4. Click **Build**, select your preferred folder, and name your file (e.g., `FXMedia_Test_Bagas.apk`).

## 📱 How to Test / Play
### Testing via Unity Editor:
1. Open the `MainScene` from the project assets.
2. Press the **Play** button.
3. The 60-second countdown timer will start running **immediately**.
4. **Left-click on the ground layer/floor** to navigate the player character.

### Testing on Android Device:
1. Install the provided `.apk` file onto your Android device.
2. Open the app and hold the device in **Landscape** orientation.
3. The game starts **instantly on launch** with the timer ticking down.
4. **Tap anywhere on the floor** to command the player capsule to move, collect coins, avoid traps, and race to break the High Score before the time runs out!
