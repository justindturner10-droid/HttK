# TCG Dungeon Runner - Game Design Document

## Executive Summary

**Working Title:** [Your Game Name Here]

**Genre:** Trading Card Game / Deck-Building Roguelike

**Platform:** Windows Desktop

**Target Audience:** Fans of TCGs and roguelike deckbuilders, ages 13+

**Unique Selling Point:** Combines the strategic depth of Yu-Gi-Oh! with the addictive run-based gameplay of Slay the Spire, featuring dynamic deck-building like Dominion within a dungeon-crawling framework.

---

## Core Gameplay Loop

```
Start Run → Choose Path → Encounter → Combat/Event → Rewards →
Modify Deck → Progress → Boss Fight → Next Floor → Repeat →
Victory/Defeat → Meta Progression → Start New Run
```

---

## Game Mechanics

### 1. Card System

#### Card Types (Define which to use)
- **Creature Cards:** Summonable units with attack/defense
- **Spell Cards:** One-time effect cards
- **Trap Cards:** Reactive cards triggered by opponent actions
- **Artifact/Equipment Cards:** Persistent effects or creature enhancements
- **[Add more as needed]**

#### Card Properties
- **Name:** Unique identifier
- **Cost:** Resource required to play (mana/energy)
- **Type:** Category (Creature, Spell, etc.)
- **Rarity:** Common, Uncommon, Rare, Epic, Legendary
- **Stats (for creatures):**
  - Attack Power
  - Health/Defense
  - Special abilities
- **Effect Text:** What the card does
- **Art:** Visual representation
- **Flavor Text:** Optional lore

#### Card Mechanics to Include
- [ ] Direct damage
- [ ] Healing
- [ ] Card draw
- [ ] Resource manipulation
- [ ] Board control (removal, bounce)
- [ ] Buffs/debuffs
- [ ] Summoning/token generation
- [ ] Card transformation
- [ ] Graveyard interaction
- [ ] Deck manipulation
- [ ] [Define more based on your vision]

---

### 2. Resource System

**Options to choose from:**

**Option A: Hearthstone-style Mana Crystals**
- Start with 1 mana, gain 1 each turn (max 10)
- Simple and accessible
- Mana refills completely each turn

**Option B: Energy System (Slay the Spire)**
- Fixed energy per turn (e.g., 3 energy)
- Some cards or relics can modify energy
- More predictable resource curve

**Option C: Yu-Gi-Oh! Style (No resource cost)**
- Cards have summoning conditions instead
- Tributes or sacrifices required
- More complex, less restrictive

**Option D: Hybrid System**
- Combine multiple resource types
- More strategic depth but more complex

**DECISION NEEDED:** [Choose your resource system]

---

### 3. Combat System

#### Turn Structure
1. **Start of Turn:**
   - Draw card(s)
   - Refresh resources
   - Trigger start-of-turn effects

2. **Main Phase 1:**
   - Play cards
   - Summon creatures
   - Activate abilities

3. **Combat Phase:**
   - Declare attackers
   - Opponent declares blockers (or direct damage)
   - Resolve combat damage
   - Apply effects

4. **Main Phase 2 (optional):**
   - Additional card plays
   - End turn actions

5. **End Phase:**
   - Trigger end-of-turn effects
   - Pass turn to opponent

#### Combat Rules
- **Player Health:** [20-30 HP starting?]
- **Creature Combat:** Attack vs Defense, damage calculation
- **Direct Attacks:** Can creatures attack player directly?
- **Defending:** Automatic blocking or player choice?
- **Combat Tricks:** Can spells be played during combat?

#### Win/Loss Conditions
- Reduce opponent health to 0
- Opponent cannot draw (deck-out)
- Special win condition cards?
- [Define all victory conditions]

---

### 4. Deck Building

#### Deck Constraints
- **Starting Deck Size:** 10-15 cards (Slay the Spire style)
- **Maximum Deck Size:** Unlimited or capped? (e.g., 40 cards)
- **Card Limits:** How many copies of same card? (1-3?)
- **Class/Faction Restrictions:** Can mix all cards or restricted?

#### In-Run Deck Building
- **Card Rewards:** Gain new cards after combat
  - Choose 1 of 3 cards after normal fights
  - Choose 1 of 3 rare cards after elite fights
  - Boss rewards: Powerful cards or relics

- **Card Removal:** Pay gold/currency to remove cards from deck

- **Card Upgrade:** Enhance existing cards (once per run? unlimited at campfires?)

- **Card Transformation:** Change cards into different cards

#### Shops
- **Card Shop:** Buy specific cards with gold
- **Relic Shop:** Purchase powerful passive items
- **Removal Service:** Pay to remove unwanted cards
- **Card Upgrade Service:** Pay for upgrades (alternative to campfire)

---

### 5. Dungeon/Run Structure

#### Map Layout
- **Node-based map** (like Slay the Spire)
- **Branching paths** with player choice
- **Multiple floors** (suggested: 3 acts of 15-17 encounters each)
- **Final boss** at end of each act

#### Encounter Types
1. **Normal Combat (?):** Regular enemy fight, common card reward
2. **Elite Combat (!):** Tougher enemy, rare card reward + extra gold
3. **Campfire/Rest (^):** Heal OR Upgrade a card
4. **Shop ($):** Merchant with cards, relics, services
5. **Random Event (?):** Text-based choice events
6. **Treasure (T):** Free relic or large gold reward
7. **Boss (B):** Act boss fight, boss relic reward

#### Floor Progression
```
Floor 1-6:   Mix of Combat, ? events, 1 shop
Floor 7:     Campfire before mini-boss
Floor 8:     Elite enemy or event
Floor 9-14:  Mix of Combat, elite, shop
Floor 15:    Campfire before boss
Floor 16:    ACT BOSS
[Repeat structure for Acts 2 and 3 with increasing difficulty]
```

---

### 6. Relic System

Relics are permanent passive items that modify gameplay for the current run.

#### Relic Categories
- **Starter Relics:** One per character/class (if applicable)
- **Common Relics:** Basic beneficial effects
- **Uncommon Relics:** Moderate power level
- **Rare Relics:** Strong game-changing effects
- **Boss Relics:** Powerful but may have drawbacks
- **Event Relics:** From special events only

#### Example Relic Ideas
- "+1 Energy per turn"
- "Draw an extra card each turn"
- "First card played each turn costs 0"
- "Creatures gain +1/+1 for each card drawn"
- "Heal 3 HP after each combat"
- "Start each combat with a random spell in hand"
- [Design 30+ unique relics]

---

### 7. Progression Systems

#### Run-Based Progression
- Card rewards and deck improvements
- Relic collection
- Gold for shops
- Health and healing management
- Deck synergy building

#### Meta-Progression (Between Runs)
- **Card Unlocks:** Expand available card pool
- **Relic Unlocks:** Make relics available in future runs
- **Character/Class Unlocks:** New playstyles
- **Ascension Levels:** Increased difficulty modifiers
- **Achievements:** Goals and milestones
- **Statistics Tracking:** Win rate, fastest wins, etc.

#### Unlocks System
- Win first run: Unlock 20 new cards
- Defeat specific bosses: Unlock themed cards
- Complete achievements: Unlock special relics
- Reach higher floors: Unlock harder difficulties

---

## Character Classes (Optional)

**Option:** Single class vs. multiple classes

If using classes, each could have:
- Unique starting deck (10 cards)
- Unique starting relic
- Class-specific cards (30-50 cards per class)
- Neutral cards (available to all)
- Unique playstyle focus

### Suggested Classes
1. **Warrior/Fighter:** Aggressive creatures, direct damage
2. **Mage/Wizard:** Spells, card draw, board control
3. **Cleric/Priest:** Healing, defensive buffs, control
4. **Rogue/Assassin:** Cheap cards, quick combos, debuffs
5. **Summoner:** Token generation, swarm tactics

**DECISION NEEDED:** Single protagonist or multiple classes?

---

## Enemy Design

### Enemy Types

#### Normal Enemies
- Simple patterns, 2-3 actions
- Moderate health and damage
- Basic mechanics introduction

#### Elite Enemies
- Complex patterns, 4-5 actions
- High health or defensive mechanics
- Challenging but fair

#### Bosses
- Multiple phases
- Unique mechanics per boss
- Requires deck synergy to defeat
- Memorable encounters

### Enemy Behavior Patterns
- Predictable AI with shown "intent" (what they'll do next turn)
- Variety in attack patterns (AOE, single target, buffs, debuffs)
- Scaling difficulty based on floor number
- Special enemy-only abilities

---

## User Interface Design

### Main Menu
- Continue Run (if active)
- New Run
- Collection/Card Library
- Statistics
- Settings
- Quit

### In-Combat UI
- Player health and resources
- Enemy health and intent
- Hand of cards
- Battlefield/board state
- Deck/discard pile counts
- Active relics display
- End turn button

### Map Screen
- Visual dungeon map
- Current position
- Available paths
- Floor indicator
- Run info (relics, gold, deck)

### Deck Management
- View all cards in deck
- Statistics (avg cost, card types, etc.)
- Upgrade status indicators

---

## Art Style Direction

[Define your visual aesthetic]

**Suggestions:**
- 2D hand-drawn art
- Pixel art
- Low-poly 3D
- Minimalist/abstract
- Dark fantasy
- Vibrant cartoon

**Mood:** [Dark, light, serious, whimsical, etc.]

---

## Audio Design

### Music
- Main menu theme
- Combat music (intensity levels)
- Map/exploration music
- Boss fight themes (epic)
- Victory/defeat stingers

### Sound Effects
- Card play/draw sounds
- Attack/damage sounds
- Healing effects
- UI interactions
- Special ability sounds
- Ambient dungeon atmosphere

---

## Monetization Strategy

**Options:**

1. **Premium ($15-25):** Pay once, get full game
2. **Free-to-Play:**
   - Cosmetics only (card backs, effects)
   - NO pay-to-win mechanics
3. **Expansion DLC:** Base game + paid content packs
4. **Early Access:** Reduced price during development

**DECISION NEEDED:** [Choose monetization model]

---

## Technical Requirements

### Performance Targets
- 60 FPS during gameplay
- < 5 second loading times
- < 500MB install size (initial)
- Runs on mid-range PC (5+ years old)

### System Requirements (Estimated)
**Minimum:**
- OS: Windows 10
- Processor: Intel i3 or equivalent
- RAM: 4 GB
- Graphics: Integrated graphics
- Storage: 500 MB

**Recommended:**
- OS: Windows 11
- Processor: Intel i5 or equivalent
- RAM: 8 GB
- Graphics: Dedicated GPU
- Storage: 1 GB

---

## Development Priorities

### Must-Have (MVP)
- Core combat system working
- 50+ playable cards
- 10+ enemies + 3 bosses
- Basic dungeon run (3 acts)
- Deck building during runs
- 10+ relics
- Win/loss conditions
- Save/load system

### Should-Have
- 150+ cards
- 30+ relics
- Meta-progression unlocks
- Card upgrades
- Multiple difficulty levels
- Statistics tracking
- Polish and juice

### Nice-to-Have
- Multiple character classes
- Daily challenges
- Achievements
- Deck sharing
- Advanced animations
- Voice acting/narration
- Modding support

---

## Risk Assessment

### Technical Risks
- Performance with many card effects
- Save system corruption
- Balance issues with card interactions
- AI difficulty tuning

### Design Risks
- Overly complex mechanics
- Unbalanced cards ruining runs
- Repetitive gameplay
- Difficulty curve too steep/shallow

### Mitigation Strategies
- Regular playtesting
- Iterative balance patches
- Start simple, add complexity gradually
- Prototype core mechanics early

---

## Next Steps

1. **Make key design decisions** (mark choices above)
2. **Choose technology stack** (Unity recommended)
3. **Create initial card designs** (30 cards)
4. **Build combat prototype** (single battle)
5. **Playtest and iterate**

---

## Questions to Answer

- [ ] What is the core fantasy/theme? (Medieval, sci-fi, fantasy, etc.)
- [ ] Single class or multiple classes?
- [ ] Resource system choice?
- [ ] Starting deck size?
- [ ] How many acts/floors per run?
- [ ] Monetization model?
- [ ] Art style direction?
- [ ] Will there be a story/narrative?
- [ ] Multiplayer or single-player only?

---

**Document Version:** 1.0
**Last Updated:** 2026-01-03
**Status:** Initial Draft - Needs Design Decisions
