# TCG Creation Tool - Project Architecture

## Overview
This is a **TCG Creation Sandbox** - a tool for designing and playing custom trading card games. Users can define their own rules, card types, effects, and win conditions without writing code.

## Technology Stack
- **Engine:** Unity (2022.3 LTS or newer recommended)
- **Language:** C#
- **Target Platform:** Windows Desktop
- **Architecture Pattern:** Data-Driven Design with ScriptableObjects

---

## Core Philosophy

### Data-Driven Everything
All game rules, card properties, effects, and turn structures are defined in **data files** (ScriptableObjects), not hard-coded. This allows:
- Non-programmers to create card games
- Easy iteration and testing
- Modular, reusable systems
- Save/load custom game modes

### Visual Editors
Custom Unity Editor windows for:
- Card Field Designer (define what properties cards have)
- Keyword Library (define effect keywords)
- Turn Structure Builder (define turn phases)
- Win Condition Creator (define victory/loss rules)
- Card Creator (design individual cards using defined fields)

---

## Project Structure

```
Assets/
├── Scripts/
│   ├── Core/                    # Core game systems
│   │   ├── Cards/               # Card base classes and interfaces
│   │   ├── GameRules/           # Rule engine and validation
│   │   ├── TurnSystem/          # Turn management and phases
│   │   ├── Effects/             # Effect processing system
│   │   └── Conditions/          # Win/loss condition evaluators
│   │
│   ├── Systems/                 # Game systems
│   │   ├── CardManagement/      # Card instances, lifecycle
│   │   ├── DeckSystem/          # Deck building, validation
│   │   ├── FieldSystem/         # Game field/board management
│   │   └── EffectSystem/        # Effect resolution and stack
│   │
│   ├── Data/                    # ScriptableObject definitions
│   │   ├── CardDefinitions/     # Card template definitions
│   │   ├── RuleDefinitions/     # Game rule definitions
│   │   ├── KeywordDefinitions/  # Effect keyword definitions
│   │   └── GameModes/           # Complete game mode configs
│   │
│   ├── UI/                      # User interface
│   │   ├── Editors/             # In-game editors for creators
│   │   ├── GamePlay/            # Gameplay UI (hand, field, etc.)
│   │   └── Menus/               # Main menu, settings
│   │
│   ├── Editor/                  # Unity Editor extensions
│   │   ├── CardEditor/          # Card creation tools
│   │   ├── RuleEditor/          # Rule editing tools
│   │   ├── KeywordEditor/       # Keyword library tools
│   │   └── Inspectors/          # Custom inspectors
│   │
│   └── Utilities/               # Helper classes, extensions
│
├── Resources/                   # Runtime-loadable assets
│   ├── Cards/                   # Card definitions
│   ├── Keywords/                # Keyword definitions
│   ├── Rules/                   # Rule sets
│   └── GameModes/               # Complete game configurations
│
├── Prefabs/                     # Reusable GameObjects
├── Scenes/                      # Unity scenes
├── Art/                         # Sprites, textures
└── Audio/                       # Sound effects, music
```

---

## Core Systems Explained

### 1. Card Field Definition System
**Purpose:** Define what properties cards can have

**Example Fields:**
- Name (text)
- Cost (number)
- Attack (number)
- Health (number)
- Card Type (enum: Creature, Spell, Trap, etc.)
- Rarity (enum: Common, Rare, Legendary, etc.)
- Keywords (list of keyword references)
- Effect Text (text)
- Custom Fields (user-defined)

**How it works:**
- Users create a `CardFieldDefinition` ScriptableObject
- Define field name, data type, default value
- Cards are generated dynamically based on active field definitions
- UI adapts to show all defined fields

**Files:**
- `CardFieldDefinition.cs` - ScriptableObject for field definitions
- `CardField.cs` - Base class for field types
- `CardFieldRegistry.cs` - Manages all available fields
- `DynamicCard.cs` - Card instance with dynamic fields

---

### 2. Keyword Library System
**Purpose:** Define reusable effect keywords that the game engine understands

**Example Keywords:**
- **Draw:** Draw X cards from deck
- **Damage:** Deal X damage to target
- **Heal:** Restore X health to target
- **Destroy:** Remove target card from play
- **Buff:** Increase target's stats by X
- **Summon:** Create a token/card on field

**How it works:**
- Each keyword has a `KeywordDefinition` ScriptableObject
- Keywords have parameters (e.g., "Draw 2" has parameter value 2)
- Keywords map to actual C# effect implementations
- Users can combine keywords to create complex effects
- Visual keyword editor for creating new keywords

**Files:**
- `KeywordDefinition.cs` - Defines a keyword and its behavior
- `KeywordLibrary.cs` - Registry of all keywords
- `KeywordEffect.cs` - Base class for keyword implementations
- `KeywordParser.cs` - Parses text into executable effects

---

### 3. Turn Structure System
**Purpose:** Define the phases and flow of a turn

**Default Phases:**
1. Start of Turn (draw card, trigger effects)
2. Main Phase 1 (play cards)
3. Combat Phase (attacks, blocks)
4. Main Phase 2 (play more cards)
5. End of Turn (cleanup, trigger effects)

**How it works:**
- `TurnPhaseDefinition` ScriptableObject for each phase
- Define what actions are allowed in each phase
- Define phase order and transitions
- Phases can be added, removed, or reordered
- Visual turn structure editor

**Files:**
- `TurnPhaseDefinition.cs` - Defines a single phase
- `TurnStructure.cs` - Complete turn structure
- `TurnManager.cs` - Executes turn flow
- `PhaseAction.cs` - Actions available per phase

---

### 4. Win Condition System
**Purpose:** Define how players win or lose

**Example Conditions:**
- Reduce opponent health to 0
- Opponent cannot draw (deck empty)
- Control X cards of a type
- Survive X turns
- Complete specific objective

**How it works:**
- `WinConditionDefinition` ScriptableObject
- Define condition type and parameters
- Multiple conditions can exist (OR/AND logic)
- Checked automatically each game state change
- Visual condition editor

**Files:**
- `WinConditionDefinition.cs` - Defines a win/loss condition
- `ConditionEvaluator.cs` - Checks if condition is met
- `GameStateMonitor.cs` - Monitors game state for conditions
- `VictoryManager.cs` - Handles win/loss resolution

---

### 5. Effect Resolution System
**Purpose:** Execute card effects and keywords in proper order

**Features:**
- Effect stack (like Magic: The Gathering)
- Priority system for effect resolution
- Target selection
- Condition checking (e.g., "if you have 5+ cards")
- Trigger system (on play, on destroy, start of turn, etc.)

**How it works:**
- Effects added to stack when triggered
- Stack resolves last-in-first-out
- Each effect can have conditions and targets
- Visual feedback for effect resolution

**Files:**
- `Effect.cs` - Base effect class
- `EffectStack.cs` - Manages effect resolution order
- `EffectTrigger.cs` - Defines when effects trigger
- `TargetSelector.cs` - Handles target selection
- `EffectResolver.cs` - Executes effects

---

### 6. Game Rule Engine
**Purpose:** Enforce game rules and validate actions

**Features:**
- Resource/mana rule validation
- Card play restrictions
- Turn phase restrictions
- Deck building rules (min/max cards, duplicates, etc.)
- Custom rule definitions

**How it works:**
- `GameRuleSet` ScriptableObject defines all rules
- Rules checked before any action
- Returns valid/invalid with reason
- Rules can be enabled/disabled per game mode

**Files:**
- `GameRuleSet.cs` - Complete rule configuration
- `GameRule.cs` - Individual rule definition
- `RuleValidator.cs` - Validates actions against rules
- `RuleEngine.cs` - Enforces rules during gameplay

---

## Data Flow Example

### Creating a New Card Game

1. **Define Card Fields**
   - Open Card Field Editor
   - Create fields: Name, Cost, Type, Attack, Health, Keywords
   - Save as `MyGameCardFields.asset`

2. **Define Keywords**
   - Open Keyword Library Editor
   - Create keywords: "Draw", "Damage", "Heal"
   - Define parameters and behaviors
   - Save as `MyGameKeywords.asset`

3. **Define Turn Structure**
   - Open Turn Structure Editor
   - Create phases: Draw → Play → Combat → End
   - Define allowed actions per phase
   - Save as `MyGameTurns.asset`

4. **Define Win Conditions**
   - Open Win Condition Editor
   - Create condition: "Opponent health reaches 0"
   - Save as `MyGameWinConditions.asset`

5. **Create Game Mode**
   - Combine all definitions into `GameModeDefinition`
   - Set starting health, hand size, deck rules
   - Save as `MyFirstCardGame.asset`

6. **Create Cards**
   - Open Card Creator
   - Use defined fields to create cards
   - Assign keywords to effects
   - Save individual cards

7. **Build Deck & Play**
   - Use deck builder with created cards
   - Start game with selected game mode
   - Play!

---

## Development Phases

### Phase 1: Core Foundation (Current)
- [x] Project structure setup
- [ ] Card field definition system
- [ ] Basic card data structure
- [ ] Simple card display

### Phase 2: Rule Definition Systems
- [ ] Keyword library implementation
- [ ] Turn structure system
- [ ] Win condition system
- [ ] Rule validation engine

### Phase 3: Visual Editors
- [ ] Card field editor window
- [ ] Keyword library editor
- [ ] Turn structure editor
- [ ] Win condition editor
- [ ] Card creator tool

### Phase 4: Gameplay Systems
- [ ] Turn manager implementation
- [ ] Effect resolution system
- [ ] Combat system
- [ ] Resource/mana management

### Phase 5: UI & UX
- [ ] Gameplay UI (hand, field, etc.)
- [ ] Card visualization
- [ ] Effect animations
- [ ] Menus and navigation

### Phase 6: Advanced Features
- [ ] Deck builder
- [ ] AI opponent
- [ ] Save/load system
- [ ] Game mode templates

---

## Key Design Principles

### 1. Modularity
Every system is independent and communicates through interfaces. You can swap out turn systems, win conditions, etc., without breaking other systems.

### 2. Extensibility
New card fields, keywords, and rules can be added without modifying core code. All extensions are data-driven.

### 3. User-Friendly
Non-programmers should be able to create complete card games using visual editors. No code required for basic game creation.

### 4. Performance
Even with dynamic systems, the game should run at 60 FPS. Use object pooling, efficient data structures, and minimal runtime reflection.

### 5. Clarity
Code should be self-documenting. Use clear names, interfaces, and comments. The architecture should be obvious from file organization.

---

## Next Steps

1. Implement `CardFieldDefinition` system
2. Create `KeywordDefinition` system
3. Build basic `TurnStructure` system
4. Implement `WinCondition` evaluators
5. Create first Unity Editor window for card fields
6. Build simple test game mode to validate architecture

---

**Document Version:** 1.0
**Last Updated:** 2026-01-03
**Status:** Architecture Planning Complete
