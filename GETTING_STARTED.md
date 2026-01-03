# Getting Started with TCG Creation Tool

This guide will help you set up Unity and start building your custom TCG game.

---

## Prerequisites

### 1. Install Unity Hub
Download and install Unity Hub from: https://unity.com/download

### 2. Install Unity Editor
**Recommended Version:** Unity 2022.3 LTS (Long Term Support)

In Unity Hub:
1. Click "Installs" tab
2. Click "Install Editor"
3. Select "2022.3 LTS" (or latest LTS version)
4. Add modules:
   - ✅ Windows Build Support (IL2CPP) - for Windows builds
   - ✅ Visual Studio Community (if you don't have an IDE)
   - ✅ Documentation (optional but helpful)

### 3. Code Editor Setup
You'll need a C# code editor. Choose one:
- **Visual Studio Community** (comes with Unity, beginner-friendly)
- **Visual Studio Code** (lightweight, requires C# extension)
- **JetBrains Rider** (powerful, paid but has student license)

---

## Setting Up This Project

### Step 1: Create Unity Project

1. Open Unity Hub
2. Click "New Project"
3. Select **"2D Core"** template
4. Project Name: `TCG-Creator` (or your choice)
5. Location: Choose the `HttK` folder (this repository)
6. Click "Create Project"

### Step 2: Import Project Structure

The folder structure is already created in `Assets/Scripts/`. Unity will automatically recognize these folders.

### Step 3: Configure Unity Settings

Once Unity opens:

1. **Set Build Target to Windows:**
   - File → Build Settings
   - Select "PC, Mac & Linux Standalone"
   - Target Platform: Windows
   - Architecture: x86_64
   - Click "Switch Platform"

2. **Configure Player Settings:**
   - Edit → Project Settings → Player
   - Company Name: [Your Name]
   - Product Name: TCG Creator
   - Default Icon: (optional, set later)

3. **Set Script Editor:**
   - Edit → Preferences → External Tools
   - External Script Editor: Select your installed editor

### Step 4: Verify Scripts

1. In Unity, go to Window → Console
2. Look for any compilation errors
3. Scripts should compile successfully (they're standalone ScriptableObjects)

---

## Understanding the Project Structure

```
Assets/
├── Scripts/
│   ├── Core/               # Core game logic (implement gameplay here)
│   ├── Data/               # ✅ COMPLETE - ScriptableObject definitions
│   ├── Systems/            # Game systems (to be implemented)
│   ├── UI/                 # User interface (to be implemented)
│   └── Editor/             # Unity editor tools (to be implemented)
│
├── Resources/              # Runtime-loadable assets
├── Scenes/                 # Unity scenes
└── Prefabs/                # Reusable GameObjects
```

### What's Already Built

✅ **Card Field Definition System** - Define custom card properties
✅ **Keyword Definition System** - Create effect keywords
✅ **Turn Structure System** - Define turn phases
✅ **Win Condition System** - Create victory/defeat conditions
✅ **Game Mode System** - Tie everything together

---

## Creating Your First Game Mode

### Step 1: Create Card Fields

1. In Unity, right-click in Project window
2. Navigate to: `Assets/Resources/Cards`
3. Right-click → Create → TCG Creator → Card Field Definition
4. Name it "FieldName" (e.g., "FieldAttack")
5. In Inspector, fill in:
   - Field Name: "Attack"
   - Field Type: Integer
   - Default Int Value: 1
   - Show On Card: ✅
   - Min Value: 0
   - Max Value: 10

**Repeat for common fields:**
- Name (Text)
- Cost (Integer)
- Health (Integer)
- Type (Enum: Creature, Spell, Trap)
- Description (Text)

### Step 2: Create Keywords

1. Navigate to: `Assets/Resources/Keywords`
2. Right-click → Create → TCG Creator → Keyword Definition
3. Name it "KeywordDraw"
4. In Inspector:
   - Keyword Name: "Draw"
   - Description: "Draw {X} cards from your deck"
   - Category: CardDraw
   - Behavior: Instant
   - Has Numeric Parameter: ✅
   - Default Parameter Value: 1
   - Requires Target: ❌

**Create more keywords:**
- Damage (deal damage to target)
- Heal (restore health)
- Destroy (remove a card)
- Buff (increase stats)

### Step 3: Create Turn Structure

1. First, create individual phases:
   - Navigate to: `Assets/Resources/Rules`
   - Create → TCG Creator → Turn Phase Definition
   - Create these phases:
     - **Draw Phase** (auto draw cards, automatic)
     - **Main Phase** (play cards, player action)
     - **Combat Phase** (attack, player action)
     - **End Phase** (cleanup, automatic)

2. Then create the turn structure:
   - Create → TCG Creator → Turn Structure
   - Name it "StandardTurnStructure"
   - In Inspector:
     - Add all 4 phases to the "Phases" list in order
     - Set turn limits as desired

### Step 4: Create Win Conditions

1. Navigate to: `Assets/Resources/Rules`
2. Create → TCG Creator → Win Condition
3. Name it "HealthZeroDefeat"
4. In Inspector:
   - Condition Name: "Health Reaches Zero"
   - Description: "Lose when your health reaches 0"
   - Outcome: Defeat
   - Target: Self
   - Condition Type: HealthBased
   - Health Threshold: 0
   - Health Comparison: LessThanOrEqual

**Create additional conditions:**
- Opponent health reaches zero (Victory)
- Cannot draw from deck (Defeat)

### Step 5: Create Game Mode

1. Navigate to: `Assets/Resources/GameModes`
2. Create → TCG Creator → Game Mode
3. Name it "MyFirstTCG"
4. In Inspector:
   - Game Mode Name: "My First TCG"
   - Add all your card fields to "Card Fields" list
   - Add all keywords to "Available Keywords"
   - Assign your Turn Structure
   - Add win conditions
   - Set game settings:
     - Starting Health: 20
     - Starting Hand Size: 5
     - Uses Resource System: ✅
     - Resource Name: "Mana"
     - Max Resource: 10
     - Resource Growth: Incremental
     - Min Deck Size: 20
     - Max Deck Size: 60

---

## Next Steps

### Phase 1: Test Your Definitions (Current)
- Create a test scene
- Write a simple script to load your GameModeDefinition
- Verify all data is accessible in code

### Phase 2: Build Core Systems
- Implement TurnManager (executes turn structure)
- Implement CardManager (handles card instances)
- Implement EffectResolver (processes keywords)
- Implement WinConditionEvaluator (checks conditions)

### Phase 3: Create UI
- Design card visualization
- Build hand display
- Create field/board layout
- Add turn phase indicator

### Phase 4: Implement Gameplay
- Card playing mechanics
- Combat resolution
- Effect processing
- Win/loss detection

---

## Learning Resources

### Unity Basics
- Unity Learn: https://learn.unity.com/
- "Unity for Beginners" tutorial series
- "Introduction to ScriptableObjects"

### C# Basics
- Microsoft C# Guide: https://docs.microsoft.com/en-us/dotnet/csharp/
- "C# for Unity" tutorial

### Card Game Development
- "How to make a Card Game in Unity" (YouTube)
- Study open-source card games on GitHub

---

## Troubleshooting

### Scripts won't compile
- Make sure all files are in correct folders
- Check for missing `using` statements
- Verify Unity version is 2022.3 or newer

### Can't create ScriptableObjects
- Ensure scripts have compiled successfully
- Check that `[CreateAssetMenu]` attribute is present
- Try reimporting scripts (right-click → Reimport)

### Unity runs slowly
- Close unnecessary applications
- Reduce quality settings: Edit → Project Settings → Quality
- Disable Auto-Refresh: Edit → Preferences → Asset Pipeline

---

## Quick Reference

### Creating New ScriptableObjects
```
Right-click in Project → Create → TCG Creator → [Type]
```

### Accessing Data in Code
```csharp
using TCGCreator.Data;

// Load a game mode
GameModeDefinition gameMode = Resources.Load<GameModeDefinition>("GameModes/MyFirstTCG");

// Get card fields
List<CardFieldDefinition> fields = gameMode.cardFields;

// Get keywords
KeywordDefinition drawKeyword = gameMode.GetKeyword("Draw");
```

### Finding Help
- Unity Documentation: `Help → Unity Manual`
- Console errors: `Window → General → Console`
- Script reference: https://docs.unity3d.com/ScriptReference/

---

## Development Roadmap

- [x] Project structure created
- [x] Core data definitions (ScriptableObjects)
- [ ] Visual editors for creating definitions
- [ ] Core gameplay systems
- [ ] Card visualization and UI
- [ ] Turn execution and game loop
- [ ] AI opponent
- [ ] Polish and refinement

---

**You're ready to start!** Begin by creating your first GameMode in Unity following the steps above.

Good luck building your TCG! 🎮
