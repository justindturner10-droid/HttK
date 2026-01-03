# TCG Dungeon Runner - Development Roadmap

## Game Concept
A hybrid TCG/Deckbuilder/Dungeon Runner that combines:
- **Yu-Gi-Oh!** - Complex card mechanics, card types (monsters, spells, traps)
- **Hearthstone** - Streamlined digital TCG interface, mana system
- **Slay the Spire** - Roguelike dungeon progression, run-based gameplay, card rewards
- **Dominion** - Deck-building strategy, card acquisition during play

**Platform:** Windows Desktop Application

---

## Phase 1: Foundation & Architecture (Weeks 1-3)

### 1.1 Technical Setup
- [ ] Choose game engine/framework (Unity, Godot, or custom C#/WPF)
- [ ] Set up project structure and version control
- [ ] Create development environment setup documentation
- [ ] Establish coding standards and architecture patterns
- [ ] Set up build pipeline and testing framework

### 1.2 Core Architecture Design
- [ ] Design card data model (properties, effects, types)
- [ ] Design deck structure and constraints
- [ ] Plan combat system architecture
- [ ] Design save/load system architecture
- [ ] Plan UI/UX framework and navigation flow

### 1.3 Initial Prototyping
- [ ] Create basic card class structure
- [ ] Implement simple card rendering
- [ ] Create prototype battle board/field
- [ ] Design basic UI mockups

---

## Phase 2: Core Card & Combat System (Weeks 4-8)

### 2.1 Card System Implementation
- [ ] Implement card types (Creatures, Spells, Artifacts, etc.)
- [ ] Create card properties system (cost, power, health, effects)
- [ ] Build card effect system and scripting
- [ ] Implement card rarity and set systems
- [ ] Create initial card database (20-30 cards for testing)

### 2.2 Resource & Mana System
- [ ] Design resource/mana generation system
- [ ] Implement turn-based resource progression
- [ ] Create resource UI display
- [ ] Balance starting resources and costs

### 2.3 Combat System
- [ ] Implement turn structure (draw, main, combat, end phases)
- [ ] Create combat calculation system
- [ ] Implement creature attacking/blocking
- [ ] Build health/damage tracking for player and creatures
- [ ] Create combat animations and visual feedback
- [ ] Implement victory/defeat conditions

### 2.4 Basic AI
- [ ] Create simple AI opponent logic
- [ ] Implement AI decision-making for card play
- [ ] Add AI combat targeting
- [ ] Test and balance AI difficulty

---

## Phase 3: Deck Building Mechanics (Weeks 9-12)

### 3.1 Deck Management
- [ ] Create deck editor UI
- [ ] Implement deck validation rules
- [ ] Add deck saving/loading functionality
- [ ] Create starter deck templates
- [ ] Implement deck statistics display

### 3.2 In-Game Deck Building (Dominion-style)
- [ ] Design card shop/acquisition system
- [ ] Implement "buy phase" during runs
- [ ] Create card pool for purchasing
- [ ] Add deck upgrading mechanics
- [ ] Implement card removal/transformation options

### 3.3 Collection System
- [ ] Create card collection database
- [ ] Implement card unlocking system
- [ ] Add collection viewing UI
- [ ] Create card filtering and search
- [ ] Implement collection progression tracking

---

## Phase 4: Dungeon Runner System (Weeks 13-18)

### 4.1 Run Structure
- [ ] Design dungeon/run progression system
- [ ] Create node-based map (like Slay the Spire)
- [ ] Implement different encounter types (combat, elite, boss, shop, event)
- [ ] Add run initialization with starting deck
- [ ] Create run state persistence

### 4.2 Roguelike Elements
- [ ] Implement permadeath/run failure
- [ ] Create run rewards system (cards, relics, currency)
- [ ] Design relic/artifact system for run buffs
- [ ] Add random events and choices
- [ ] Implement difficulty scaling through floors

### 4.3 Map & Navigation
- [ ] Create visual map UI
- [ ] Implement node selection and pathing
- [ ] Add map generation algorithms
- [ ] Create different map layouts/themes
- [ ] Add floor progression tracking

### 4.4 Enemy System
- [ ] Design enemy types and behaviors
- [ ] Create enemy decks and AI patterns
- [ ] Implement boss encounters
- [ ] Add enemy scaling by floor
- [ ] Create elite enemy variants

---

## Phase 5: Content Creation & Balancing (Weeks 19-24)

### 5.1 Card Expansion
- [ ] Design and implement 100+ unique cards
- [ ] Create multiple card factions/classes
- [ ] Implement card synergies and archetypes
- [ ] Balance card costs and power levels
- [ ] Add legendary/unique cards

### 5.2 Enemy & Boss Design
- [ ] Create 20+ unique enemies
- [ ] Design 5+ boss encounters
- [ ] Implement unique boss mechanics
- [ ] Add enemy deck variations
- [ ] Balance enemy difficulty curves

### 5.3 Relics & Artifacts
- [ ] Design 30+ relics with unique effects
- [ ] Implement relic rarity system
- [ ] Create relic synergies
- [ ] Balance relic power levels
- [ ] Add relic unlock progression

### 5.4 Events & Encounters
- [ ] Create 15+ random events
- [ ] Design choice-based encounters
- [ ] Add shop variants and pricing
- [ ] Implement risk/reward mechanics
- [ ] Create special encounter types

### 5.5 Playtesting & Balance
- [ ] Conduct internal playtesting sessions
- [ ] Gather feedback on difficulty
- [ ] Balance card power levels
- [ ] Adjust economy and rewards
- [ ] Iterate on problematic mechanics

---

## Phase 6: Polish & Advanced Features (Weeks 25-30)

### 6.1 Visual Polish
- [ ] Create final card art and animations
- [ ] Implement particle effects for abilities
- [ ] Add screen shake and juice
- [ ] Polish UI transitions and animations
- [ ] Create victory/defeat animations

### 6.2 Audio
- [ ] Add background music tracks
- [ ] Implement sound effects for cards
- [ ] Create ambient dungeon sounds
- [ ] Add UI interaction sounds
- [ ] Implement audio settings and mixing

### 6.3 Meta-Progression
- [ ] Design account-level progression system
- [ ] Implement card unlocks across runs
- [ ] Create achievement system
- [ ] Add persistent upgrades/unlocks
- [ ] Implement difficulty modifiers (ascension levels)

### 6.4 Additional Features
- [ ] Create daily run challenges
- [ ] Implement run history and statistics
- [ ] Add deck sharing via codes
- [ ] Create tutorial/training mode
- [ ] Implement settings and options menu

### 6.5 Performance & Optimization
- [ ] Profile and optimize performance
- [ ] Reduce memory usage
- [ ] Optimize loading times
- [ ] Fix bugs and crashes
- [ ] Test on various hardware configurations

---

## Phase 7: Release Preparation (Weeks 31-34)

### 7.1 Testing
- [ ] Comprehensive QA testing
- [ ] Balance final adjustments
- [ ] Bug fixing sprint
- [ ] Performance testing
- [ ] Accessibility testing

### 7.2 Documentation
- [ ] Create user manual/guide
- [ ] Write patch notes
- [ ] Create marketing materials
- [ ] Design game website/landing page
- [ ] Prepare FAQ and support docs

### 7.3 Release
- [ ] Set up distribution (Steam, itch.io, etc.)
- [ ] Create installer/build
- [ ] Prepare launch announcement
- [ ] Plan post-launch support
- [ ] Monitor initial player feedback

---

## Post-Launch Roadmap

### Content Updates
- Monthly card expansions
- New dungeon themes and environments
- Additional game modes (draft, constructed, etc.)
- Seasonal events and challenges

### Community Features
- Leaderboards and rankings
- Community card designs
- Modding support
- Multiplayer/PvP mode (future consideration)

---

## Technical Stack Recommendations

### Option 1: Unity (Recommended for beginners/rapid development)
- **Pros:** Mature 2D tools, asset store, cross-platform
- **Cons:** Licensing considerations, larger build size

### Option 2: Godot (Open source, lightweight)
- **Pros:** Free, lightweight, good 2D support
- **Cons:** Smaller community, fewer ready-made assets

### Option 3: Custom C# with WPF/WinUI
- **Pros:** Full control, Windows-native, C# familiarity
- **Cons:** More work for graphics/animation, limited to Windows

### Option 4: MonoGame/FNA
- **Pros:** Lightweight, C# based, good 2D support
- **Cons:** More low-level, less out-of-the-box features

**Recommendation:** Start with Unity for rapid prototyping and development velocity.

---

## Key Design Decisions Needed

1. **Combat Pacing:** Turn-based like Hearthstone or more complex like Yu-Gi-Oh!?
2. **Deck Size:** Fixed (like Slay the Spire starting at 10) or variable (like Dominion)?
3. **Resource System:** Mana that resets each turn (Hearthstone) or persistent resources?
4. **Card Types:** How many types (creatures, spells, traps, artifacts)?
5. **Win Condition:** Reduce opponent to 0 HP, or alternative win conditions?
6. **Monetization:** Premium game, F2P with cosmetics, or expansion DLC?

---

## Next Immediate Steps

1. **Choose technology stack** - Decision needed for engine/framework
2. **Create detailed Game Design Document (GDD)** - Core mechanics specification
3. **Design initial card set** - 30-50 cards for prototype
4. **Build vertical slice** - One complete combat encounter working end-to-end
5. **Iterate based on playtest feedback**

---

## Estimated Timeline
- **Prototype (Phases 1-2):** 2-3 months
- **Core Game (Phases 3-4):** 3-4 months
- **Content & Polish (Phases 5-6):** 3-4 months
- **Release Prep (Phase 7):** 1 month
- **Total:** ~9-12 months for solo developer, 6-8 months with small team

---

## Success Metrics

- **Prototype:** One playable combat encounter with 30 cards
- **Alpha:** Full dungeon run with 100 cards and basic progression
- **Beta:** Complete game loop with 200+ cards, polish, and balance
- **Release:** Polished, bug-free experience with 300+ cards and meta-progression
