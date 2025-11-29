# 🎮 Escape Game Unity VR

An immersive virtual reality escape room game built with Unity, featuring magical spell-casting mechanics, interactive puzzles, and smooth VR locomotion. Navigate through locked rooms, solve puzzles, and use mystical powers to progress through the game.

## ✨ Features

- **🎯 VR-First Experience**: Fully optimized for VR headsets with intuitive controls
- **🔮 Magic Spell System**: 
  - **Portal Casting**: Activate portals using gesture recognition to unlock doors and reveal hidden paths
  - **Fireball Projectiles**: Launch destructive fireballs to destroy obstacles and barriers
- **🚶 Smooth Locomotion**: Joystick-based movement system for comfortable VR navigation
- **🎪 Interactive Environment**: 
  - Door trigger zones that activate when approached
  - Destructible objects and walls
  - Dynamic object interactions
- **🎨 Rich Visual Effects**: 
  - Particle effects for spells and impacts
  - Portal visualizations
  - Immersive lighting and atmosphere

## 🛠️ Requirements

### Software
- **Unity**: 2022.3 LTS or newer
- **XR Interaction Toolkit**: 3.2.2+
- **OpenXR Plugin**: 1.15.1+
- **Meta XR SDK**: 81.0.0+ (for Quest support)

### Hardware
- VR headset with joystick support:
  - Meta Quest 2/3/Pro
  - HTC Vive
  - Valve Index
  - Other OpenXR-compatible headsets

## 📦 Installation & Setup

### 1. Clone the Repository
```bash
git clone https://github.com/Ariazoox/Escape-Game-Unity-VR.git
cd Escape-Game-Unity-VR
```

### 2. Open in Unity
1. Launch **Unity Hub**
2. Click **Add** and select the project folder
3. Ensure Unity 2022.3 LTS or newer is installed
4. Open the project

### 3. Install Required Packages
The project should automatically resolve dependencies via `Packages/manifest.json`. If packages are missing:

1. Open **Window → Package Manager**
2. Install the following packages if not already present:
   - **XR Interaction Toolkit** (3.2.2+)
   - **OpenXR Plugin** (1.15.1+)
   - **Meta XR SDK** (81.0.0+)

### 4. Configure XR Settings
1. Go to **Edit → Project Settings**
2. Navigate to **XR Plug-in Management**
3. Enable **OpenXR** for your target platform (Android for Quest, Windows for PC VR)
4. Configure OpenXR settings as needed

### 5. Open the Main Scene
- Navigate to `Assets/Scenes/EscapeGameScene.unity`
- This is the main game scene

### 6. Test in VR
1. Connect your VR headset
2. Press **Play** in Unity Editor (or build and deploy)
3. Test joystick movement and spell-casting mechanics

## 🎮 Controls

### Movement
- **Joystick**: Smooth continuous movement in the direction you point

### Spell Casting
- **Portal Cast**: 
  - Use **Right and Left triggers** simultaneously
  - Aim at the portal and perform the gesture
  - Activates rotating portal spell to unlock doors

- **Fireball**: 
  - Hold **Right trigger** and move controller upside down
  - Performs fireball gesture to launch projectile
  - Destroys objects tagged as "DestroyOnHit"

### Interaction
- **Door Triggers**: Automatically activate when you approach trigger zones
- **Object Manipulation**: Use VR controllers to grab and interact with objects

## 📁 Project Structure

```
Escape-Game-Unity-VR/
├── Assets/
│   ├── Scenes/
│   │   └── EscapeGameScene.unity      # Main game scene
│   ├── DoorTriggerZone.cs             # Door activation system
│   ├── FireballController.cs          # Fireball projectile logic
│   ├── PlayerSpawner.cs               # Player spawn management
│   ├── PortalEffectController.cs      # Portal and spell casting
│   ├── GestureLoader.cs               # Gesture recognition system
│   └── GestureRecognition/            # Gesture recognition assets
├── ProjectSettings/                   # Unity project configuration
└── Packages/                          # Package dependencies
```

## 🔧 Technologies Used

- **Unity Engine**: 2022.3 LTS
- **XR Interaction Toolkit**: VR interaction framework
- **OpenXR**: Cross-platform VR API
- **Universal Render Pipeline (URP)**: Modern rendering pipeline
- **Meta XR SDK**: Quest platform support
- **Gesture Recognition**: Custom gesture-based spell casting system

## 🎯 Gameplay Overview

1. **Spawn**: Start at a designated spawn point in the locked room
2. **Explore**: Use joystick locomotion to navigate the environment
3. **Solve Puzzles**: Interact with objects and find clues
4. **Cast Spells**: 
   - Use portal spells to unlock doors and reveal paths
   - Launch fireballs to destroy obstacles blocking your way
5. **Progress**: Navigate through multiple rooms to reach the final destination

## 🐛 Known Issues & Limitations

- Gesture recognition requires specific similarity thresholds (0.3+) for activation
- Fireball collision detection has a 0.5s delay to prevent self-destruction
- Some assets are from third-party packages (see Licenses.txt in Assets/_Course Library)

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes, please open an issue first to discuss what you would like to change.

## 📝 License

This project uses various third-party assets. Please refer to `Assets/_Course Library/Licenses.txt` for asset-specific licensing information.

## 👤 Author

**Ariazoox**

- GitHub: [@Ariazoox](https://github.com/Ariazoox)

## 🙏 Acknowledgments

- Unity Technologies for the XR Interaction Toolkit
- All asset creators whose work is used in this project
- The VR development community for inspiration and support

---

**Note**: This project is optimized for VR and requires a VR headset to play. Desktop mode is not supported.
