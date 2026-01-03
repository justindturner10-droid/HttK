using UnityEngine;
using System.Collections.Generic;

namespace TCGCreator.Data
{
    /// <summary>
    /// Complete definition of a game mode - ties together all rule systems
    /// This is the top-level configuration for a playable card game
    /// </summary>
    [CreateAssetMenu(fileName = "NewGameMode", menuName = "TCG Creator/Game Mode")]
    public class GameModeDefinition : ScriptableObject
    {
        [Header("Game Mode Identity")]
        [Tooltip("Name of this game mode (e.g., 'Standard', 'Fast Paced', 'My Custom TCG')")]
        public string gameModeName;

        [TextArea(3, 6)]
        [Tooltip("Description of this game mode")]
        public string description;

        [Tooltip("Version number for this game mode")]
        public string version = "1.0";

        [Header("Core Systems")]
        [Tooltip("Card fields that are used in this game mode")]
        public List<CardFieldDefinition> cardFields = new List<CardFieldDefinition>();

        [Tooltip("Available keywords for this game mode")]
        public List<KeywordDefinition> availableKeywords = new List<KeywordDefinition>();

        [Tooltip("Turn structure for this game mode")]
        public TurnStructureDefinition turnStructure;

        [Tooltip("Win/loss conditions for this game mode")]
        public List<WinConditionDefinition> winConditions = new List<WinConditionDefinition>();

        [Header("Game Settings")]
        [Tooltip("Starting health for each player")]
        public int startingHealth = 20;

        [Tooltip("Starting hand size")]
        public int startingHandSize = 5;

        [Tooltip("Maximum hand size (0 = unlimited)")]
        public int maxHandSize = 10;

        [Tooltip("Maximum cards on field per player (0 = unlimited)")]
        public int maxFieldSize = 7;

        [Header("Resource System")]
        [Tooltip("Does this game use a resource/mana system?")]
        public bool usesResourceSystem = true;

        [Tooltip("Name of the resource (e.g., 'Mana', 'Energy', 'Action Points')")]
        public string resourceName = "Mana";

        [Tooltip("Starting resource amount")]
        public int startingResource = 0;

        [Tooltip("Maximum resource (0 = unlimited)")]
        public int maxResource = 10;

        [Tooltip("How does resource increase?")]
        public ResourceGrowthType resourceGrowth;

        [Tooltip("Resource gain per turn (if using PerTurn growth)")]
        public int resourceGainPerTurn = 1;

        [Tooltip("Does resource refill each turn?")]
        public bool resourceRefillsEachTurn = true;

        [Header("Deck Building Rules")]
        [Tooltip("Minimum deck size")]
        public int minDeckSize = 20;

        [Tooltip("Maximum deck size (0 = unlimited)")]
        public int maxDeckSize = 60;

        [Tooltip("Maximum copies of a single card (0 = unlimited)")]
        public int maxCopiesPerCard = 3;

        [Tooltip("Are duplicate cards allowed?")]
        public bool allowDuplicates = true;

        [Header("Gameplay Rules")]
        [Tooltip("Can players mulligan (redraw) their starting hand?")]
        public bool allowMulligan = true;

        [Tooltip("How many times can a player mulligan?")]
        public int mulliganLimit = 1;

        [Tooltip("Can players attack on their first turn?")]
        public bool canAttackFirstTurn = false;

        [Tooltip("Do creatures have summoning sickness (can't attack the turn played)?")]
        public bool hasSummoningSickness = true;

        [Header("Advanced Rules")]
        [Tooltip("Maximum stack size for effects (0 = unlimited)")]
        public int maxStackSize = 0;

        [Tooltip("Enable graveyard interaction?")]
        public bool enableGraveyard = true;

        [Tooltip("Enable exile/banish zone?")]
        public bool enableExile = false;

        [Tooltip("Can cards be played from graveyard?")]
        public bool allowGraveyardPlay = false;

        [Header("AI & Multiplayer")]
        [Tooltip("Is this game mode playable against AI?")]
        public bool supportsAI = true;

        [Tooltip("Is this game mode playable in multiplayer?")]
        public bool supportsMultiplayer = false;

        [Tooltip("Number of players (2-4)")]
        public int playerCount = 2;

        [Header("Visual Theme")]
        [Tooltip("Background image for this game mode")]
        public Sprite backgroundImage;

        [Tooltip("Theme color")]
        public Color themeColor = Color.blue;

        [Tooltip("Card back design")]
        public Sprite cardBackDesign;

        /// <summary>
        /// Validate that this game mode is properly configured
        /// </summary>
        public bool ValidateGameMode(out List<string> errors)
        {
            errors = new List<string>();

            // Check card fields
            if (cardFields == null || cardFields.Count == 0)
            {
                errors.Add("Game mode must have at least one card field defined");
            }

            // Check turn structure
            if (turnStructure == null)
            {
                errors.Add("Game mode must have a turn structure defined");
            }
            else
            {
                if (!turnStructure.ValidateStructure(out string structureError))
                {
                    errors.Add($"Turn structure error: {structureError}");
                }
            }

            // Check win conditions
            if (winConditions == null || winConditions.Count == 0)
            {
                errors.Add("Game mode must have at least one win condition");
            }

            // Check deck size
            if (minDeckSize > maxDeckSize && maxDeckSize > 0)
            {
                errors.Add("Minimum deck size cannot be greater than maximum deck size");
            }

            // Check resource settings
            if (usesResourceSystem && maxResource > 0 && startingResource > maxResource)
            {
                errors.Add("Starting resource cannot exceed maximum resource");
            }

            return errors.Count == 0;
        }

        /// <summary>
        /// Get a card field by name
        /// </summary>
        public CardFieldDefinition GetCardField(string fieldName)
        {
            return cardFields.Find(f => f.fieldName == fieldName);
        }

        /// <summary>
        /// Get a keyword by name
        /// </summary>
        public KeywordDefinition GetKeyword(string keywordName)
        {
            return availableKeywords.Find(k => k.keywordName == keywordName);
        }
    }

    /// <summary>
    /// How resources grow over time
    /// </summary>
    public enum ResourceGrowthType
    {
        None,               // No automatic growth
        PerTurn,            // Gain X per turn
        Incremental,        // Gain 1 more each turn (like Hearthstone)
        Fixed,              // Always have the same amount
        CardBased           // Growth based on cards played
    }
}
