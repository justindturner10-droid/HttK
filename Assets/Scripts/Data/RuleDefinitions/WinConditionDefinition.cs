using UnityEngine;
using System.Collections.Generic;

namespace TCGCreator.Data
{
    /// <summary>
    /// Defines a win or loss condition for the game
    /// </summary>
    [CreateAssetMenu(fileName = "NewWinCondition", menuName = "TCG Creator/Win Condition")]
    public class WinConditionDefinition : ScriptableObject
    {
        [Header("Condition Identity")]
        [Tooltip("Name of this condition (e.g., 'Health Reaches Zero', 'Deck Out')")]
        public string conditionName;

        [TextArea(2, 4)]
        [Tooltip("Description of this win/loss condition")]
        public string description;

        [Header("Condition Type")]
        [Tooltip("Is this a win or loss condition?")]
        public ConditionOutcome outcome;

        [Tooltip("Who does this condition apply to?")]
        public ConditionTarget target;

        [Header("Condition Rules")]
        [Tooltip("What type of condition is this?")]
        public WinConditionType conditionType;

        [Header("Health-Based Conditions")]
        [Tooltip("Trigger when health reaches this value")]
        public int healthThreshold = 0;

        [Tooltip("Compare health using this operator")]
        public ComparisonOperator healthComparison = ComparisonOperator.LessThanOrEqual;

        [Header("Card-Based Conditions")]
        [Tooltip("Specific card type to check")]
        public string cardTypeToCheck;

        [Tooltip("Number of cards required")]
        public int cardCountThreshold = 0;

        [Tooltip("Compare card count using this operator")]
        public ComparisonOperator cardCountComparison = ComparisonOperator.GreaterThanOrEqual;

        [Tooltip("Where to check for cards")]
        public CardLocation locationToCheck;

        [Header("Turn-Based Conditions")]
        [Tooltip("Number of turns for turn-based conditions")]
        public int turnCount = 10;

        [Header("Keyword-Based Conditions")]
        [Tooltip("Keywords that must be present/active")]
        public List<KeywordDefinition> requiredKeywords = new List<KeywordDefinition>();

        [Header("Custom Conditions")]
        [TextArea(3, 6)]
        [Tooltip("Custom script for complex conditions")]
        public string customConditionScript;

        [Header("Multiple Conditions")]
        [Tooltip("If this condition is part of a group, how should they combine?")]
        public ConditionCombinator combinator = ConditionCombinator.None;

        [Tooltip("Other conditions that must also be met")]
        public List<WinConditionDefinition> additionalConditions = new List<WinConditionDefinition>();

        [Header("Visual Feedback")]
        [Tooltip("Message to display when condition is met")]
        public string conditionMetMessage;

        [Tooltip("Icon to show when condition is met")]
        public Sprite conditionIcon;

        [Tooltip("Color for UI feedback")]
        public Color conditionColor = Color.white;
    }

    /// <summary>
    /// Whether this is a win or loss condition
    /// </summary>
    public enum ConditionOutcome
    {
        Victory,        // Player wins when this is met
        Defeat,         // Player loses when this is met
        Draw            // Game ends in a draw
    }

    /// <summary>
    /// Who the condition applies to
    /// </summary>
    public enum ConditionTarget
    {
        Self,           // Applies to the player whose turn it is
        Opponent,       // Applies to the opponent
        Either,         // Applies to either player
        Both            // Both players must meet condition
    }

    /// <summary>
    /// Types of win/loss conditions
    /// </summary>
    public enum WinConditionType
    {
        HealthBased,            // Based on player health
        DeckEmpty,              // Cannot draw from deck
        CardControl,            // Control specific cards/number of cards
        TurnLimit,              // Survive/win within X turns
        SpecificCard,           // Play or control a specific card
        KeywordActivation,      // Activate certain keywords X times
        ResourceThreshold,      // Reach certain resource amount
        ComboBased,             // Execute a specific combo
        Custom                  // Custom scripted condition
    }

    /// <summary>
    /// Comparison operators for conditions
    /// </summary>
    public enum ComparisonOperator
    {
        Equal,
        NotEqual,
        GreaterThan,
        GreaterThanOrEqual,
        LessThan,
        LessThanOrEqual
    }

    /// <summary>
    /// Where to check for cards
    /// </summary>
    public enum CardLocation
    {
        Hand,           // In player's hand
        Deck,           // In player's deck
        Field,          // On the game field
        Graveyard,      // In discard pile
        Exile,          // In exile/banished zone
        Anywhere        // Any location
    }

    /// <summary>
    /// How to combine multiple conditions
    /// </summary>
    public enum ConditionCombinator
    {
        None,           // Single condition
        And,            // All conditions must be met
        Or,             // Any condition must be met
        Xor             // Exactly one condition must be met
    }
}
