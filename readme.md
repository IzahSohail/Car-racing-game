# VroomVille 🏎️  
A 3D racing game developed in Unity as part of the NYU Games S25 course. The game features two unique circuits, custom-built terrains, and multiple cars for players to choose from. It was designed to be simple, fun, and visually engaging, with a balance of urban and mountainous elements.

---

## 🎮 Gameplay  
VroomVille is a single-player racing experience where the player selects a car and a circuit, then competes to complete 3 laps. Each track has shortcut paths and a clean UI to keep players aware of their current speed and lap count. The game ends with a Game Over screen once all laps are completed.

---

## 🚗 Features Implemented  

- 🌄 **Custom Terrain**  
  Manually sculpted terrain using Unity’s terrain tools. The two circuits offer different feels—one is mountain-based, the other more urban.  

- 🏙️ **Low-Poly Urban Environment**  
  Integrated the [Low Poly Simple Urban City 3D Asset Pack](https://assetstore.unity.com/packages/3d/environments/urban/free-low-poly-simple-urban-city-3d-asset-pack-239474) to add buildings, roads, and urban vibes.  

- 🛣️ **Track Design**  
  Designed race tracks with clear road layouts and realistic textures. Added shortcut routes to make each lap more strategic.  

- 🎥 **Follow Camera**  
  Implemented a Cinemachine camera setup that smoothly follows the player's car.  

- 🎛️ **HUD Elements**  
  Speedometer and lap counter displayed in real-time during the game.  

- 🎵 **Sound FX**  
  Added sound effects to enhance the gameplay feel (engine, finish line, etc.).  

- 🎨 **UI & Menu Design**  
  Main menu with circuit selection.  

- 🧭 **Lap Logic**  
  Lap system only progresses if the player drives through a midpoint and then completes a full loop—preventing lap skipping or reverse exploits.  

- 🏁 **Game Over Screen**  
  Once 3 laps are completed, the player sees a simple Game Over menu with the option to return to the main menu.

---

## 📂 Scenes

- `MainMenu` — Title screen with circuit and car selection  
- `circuit1` — A track through mountainous terrain  
- `circuit2` — An urban circuit surrounded by city buildings  
- `GameOver` — Final screen that appears after 3 laps  

---

## 📦 Assets Used

- [Low Poly Simple Urban City 3D Asset Pack](https://assetstore.unity.com/packages/3d/environments/urban/free-low-poly-simple-urban-city-3d-asset-pack-239474)  
- Unity Standard Assets (for car physics and effects)  
- Custom terrain textures and materials  
- TextMeshPro for all text elements in UI  

---

## 🛠️ How to Play

1. Launch the game by loading main scene from `Assets/Scenes/MainMenu.unity`
2. Choose the circuit you wish to play 
3. Complete 3 laps while monitoring your speed and lap count  
4. On the final lap, the game ends and offers you a return to the main menu  
