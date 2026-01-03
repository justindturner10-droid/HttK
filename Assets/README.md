# TCG Creator - Assets Folder

This is the root of your Unity project's asset folder.

## Folder Structure

### `/Scripts` - All C# code
- **Core/** - Core game systems and logic
- **Data/** - ScriptableObject definitions (card fields, keywords, rules)
- **Systems/** - Gameplay systems (card management, deck system, effects)
- **UI/** - User interface components
- **Editor/** - Unity Editor extensions and tools
- **Utilities/** - Helper classes and extensions

### `/Resources` - Runtime loadable assets
Place your ScriptableObject instances here so they can be loaded at runtime using `Resources.Load()`.

- **Cards/** - Individual card definitions
- **Keywords/** - Keyword definitions
- **Rules/** - Turn structures and win conditions
- **GameModes/** - Complete game mode configurations

### `/Scenes` - Unity scenes
Your game's levels and menus.

### `/Prefabs` - Reusable GameObjects
Card prefabs, UI prefabs, effect prefabs, etc.

### `/Art` - Visual assets
Sprites, textures, card art, UI elements.

### `/Audio` - Sound files
Music, sound effects, voice lines.

## Quick Start

1. Create your card fields in `Resources/Cards/`
2. Create keywords in `Resources/Keywords/`
3. Build turn structure in `Resources/Rules/`
4. Define win conditions in `Resources/Rules/`
5. Assemble everything into a GameMode in `Resources/GameModes/`

See GETTING_STARTED.md in the root directory for detailed instructions.
