using UnityEngine;
using System.Collections.Generic;

namespace TCGCreator.Data
{
    /// <summary>
    /// Defines a keyword effect that the game understands (e.g., Draw, Damage, Heal)
    /// Keywords are the building blocks of card effects
    /// </summary>
    [CreateAssetMenu(fileName = "NewKeyword", menuName = "TCG Creator/Keyword Definition")]
    public class KeywordDefinition : ScriptableObject
    {
        [Header("Keyword Identity")]
        [Tooltip("Name of this keyword (e.g., 'Draw', 'Damage', 'Heal')")]
        public string keywordName;

        [TextArea(2, 4)]
        [Tooltip("What does this keyword do? (shown to users)")]
        public string description;

        [Tooltip("Short explanation shown in tooltips")]
        public string tooltipText;

        [Header("Keyword Type")]
        [Tooltip("What category does this keyword fall into?")]
        public KeywordCategory category;

        [Tooltip("How does this keyword behave?")]
        public KeywordBehavior behavior;

        [Header("Parameters")]
        [Tooltip("Does this keyword use a numeric parameter? (e.g., 'Draw 2' - parameter is 2)")]
        public bool hasNumericParameter = true;

        [Tooltip("Default parameter value")]
        public int defaultParameterValue = 1;

        [Tooltip("Does this keyword require a target?")]
        public bool requiresTarget = false;

        [Tooltip("What can be targeted?")]
        public TargetType targetType;

        [Header("Visual")]
        [Tooltip("Icon for this keyword")]
        public Sprite keywordIcon;

        [Tooltip("Color theme for this keyword")]
        public Color keywordColor = Color.white;

        [Header("Timing")]
        [Tooltip("When can this keyword be activated?")]
        public KeywordTiming timing;

        [Tooltip("Can this keyword be used on opponent's turn?")]
        public bool canUseOnOpponentTurn = false;

        [Header("Advanced")]
        [Tooltip("Custom script implementation (if needed for complex behavior)")]
        public string scriptImplementation;

        [Tooltip("Additional keywords that trigger with this one")]
        public List<KeywordDefinition> chainedKeywords = new List<KeywordDefinition>();

        /// <summary>
        /// Format the keyword with its parameter for display
        /// </summary>
        public string FormatKeyword(int parameterValue)
        {
            if (hasNumericParameter)
            {
                return $"{keywordName} {parameterValue}";
            }
            return keywordName;
        }

        /// <summary>
        /// Get the full description with parameter substitution
        /// </summary>
        public string GetDescription(int parameterValue)
        {
            return description.Replace("{X}", parameterValue.ToString());
        }
    }

    /// <summary>
    /// Categories of keywords
    /// </summary>
    public enum KeywordCategory
    {
        CardDraw,           // Drawing cards
        Damage,             // Dealing damage
        Healing,            // Restoring health
        StatModification,   // Buffing/debuffing
        CardManipulation,   // Moving, destroying, returning cards
        ResourceGeneration, // Gaining resources/mana
        Summoning,          // Creating tokens
        Control,            // Tapping, stunning, disabling
        Protection,         // Shields, immunity
        Utility,            // Other effects
        Custom              // User-defined
    }

    /// <summary>
    /// How the keyword behaves
    /// </summary>
    public enum KeywordBehavior
    {
        Instant,            // Happens immediately
        Continuous,         // Ongoing effect while card is active
        Triggered,          // Activates under certain conditions
        Activated,          // Player chooses when to use
        Static              // Always active, can't be turned off
    }

    /// <summary>
    /// What can be targeted by this keyword
    /// </summary>
    public enum TargetType
    {
        None,               // No target needed
        AnyCard,            // Any card on field
        PlayerCard,         // Your cards only
        OpponentCard,       // Opponent cards only
        Player,             // A player
        Self,               // The card itself
        Random,             // Random target selected automatically
        Multiple            // Can target multiple things
    }

    /// <summary>
    /// When the keyword can be used
    /// </summary>
    public enum KeywordTiming
    {
        Anytime,            // Can use whenever you have priority
        MainPhaseOnly,      // Only during main phase
        CombatPhaseOnly,    // Only during combat
        OnPlay,             // When card is played
        OnDestroy,          // When card is destroyed
        StartOfTurn,        // At turn start
        EndOfTurn,          // At turn end
        Custom              // Custom timing rules
    }
}
