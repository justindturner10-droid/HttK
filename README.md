# TCG Creation Tool

A **Trading Card Game Creation Engine** - build your own custom card games without coding!

Design your own TCG with custom rules, card types, effects, win conditions, and turn structures. Inspired by the mechanics of Yu-Gi-Oh!, Hearthstone, Slay the Spire, and Dominion, but fully customizable to create your unique card game.

## Project Status

**Phase:** Foundation - Core Systems Implemented
**Current Version:** Pre-Alpha v0.1
**Last Updated:** 2026-01-03

## Documentation

- **[GETTING_STARTED.md](GETTING_STARTED.md)** - Complete setup guide for Unity and first steps
- **[PROJECT_ARCHITECTURE.md](PROJECT_ARCHITECTURE.md)** - Technical architecture and system design
- **[ROADMAP.md](ROADMAP.md)** - Original dungeon runner concept (reference)
- **[GAME_DESIGN_DOCUMENT.md](GAME_DESIGN_DOCUMENT.md)** - Game design concepts (reference)

## Quick Start

### For Developers:

1. Install Unity Hub and Unity 2022.3 LTS
2. Follow the [Getting Started Guide](GETTING_STARTED.md)
3. Open the project in Unity
4. Create your first game mode using ScriptableObjects
5. Start building gameplay systems

### For Game Designers (No Coding):

Once the visual editors are complete, you'll be able to:
- Define custom card properties (Attack, Health, Cost, etc.)
- Create effect keywords (Draw, Damage, Heal, etc.)
- Design turn structures (phases and rules)
- Set win/loss conditions
- Build complete card games visually

## Core Features

### ✅ Implemented
- **Card Field Definition System** - Define custom properties for cards
- **Keyword Library** - Create reusable effect keywords
- **Turn Structure Builder** - Design custom turn phases
- **Win Condition System** - Define victory/defeat conditions
- **Game Mode Configuration** - Tie all systems together
- **Data-Driven Architecture** - Everything configured via ScriptableObjects

### 🚧 In Progress
- Visual editors for Unity
- Core gameplay systems (turn management, card instances)
- Effect resolution engine
- Card visualization UI

### 📋 Planned
- Deck builder
- Card creator with visual editor
- AI opponent
- Save/load custom games
- Export/share game modes
- Dungeon runner mode (original concept)

## Technology Stack

**Engine:** Unity 2022.3 LTS (chosen for ease of use and powerful editor tools)
**Language:** C#
**Architecture:** Data-Driven Design with ScriptableObjects
**Platform:** Windows Desktop

## Project Structure

```
Assets/
├── Scripts/
│   ├── Data/           ✅ Core definitions (Complete)
│   ├── Core/           🚧 Game logic (In Progress)
│   ├── Systems/        📋 Gameplay systems (Planned)
│   ├── UI/             📋 User interface (Planned)
│   └── Editor/         📋 Visual editors (Planned)
├── Resources/          Create your game modes here
└── Scenes/             Unity scenes
```

## Example: Creating a Simple TCG

```
1. Define Card Fields:
   - Name (text)
   - Cost (number)
   - Attack (number)
   - Health (number)

2. Create Keywords:
   - Draw X cards
   - Deal X damage
   - Heal X health

3. Design Turn Structure:
   - Draw Phase → Main Phase → Combat → End Turn

4. Set Win Conditions:
   - Opponent health reaches 0 = Victory
   - Your health reaches 0 = Defeat

5. Create Game Mode:
   - Combine all definitions
   - Set starting health, hand size, deck rules
   - Ready to play!
```

## Why Use This Tool?

- **No Coding Required** (once editors are built) - Design games visually
- **Rapid Prototyping** - Test game ideas quickly
- **Highly Customizable** - Create any TCG ruleset you can imagine
- **Data-Driven** - Easy to iterate and balance
- **Extensible** - Developers can add custom systems

## Contributing

This is an open development project. Contributions welcome once core systems are stable.

## License

[To Be Determined]

---

**Build your dream card game!** 🎮✨
