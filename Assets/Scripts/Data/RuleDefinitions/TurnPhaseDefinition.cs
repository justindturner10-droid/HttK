using UnityEngine;
using System.Collections.Generic;

namespace TCGCreator.Data
{
    /// <summary>
    /// Defines a single phase within a turn (e.g., Draw Phase, Main Phase, Combat Phase)
    /// </summary>
    [CreateAssetMenu(fileName = "NewTurnPhase", menuName = "TCG Creator/Turn Phase Definition")]
    public class TurnPhaseDefinition : ScriptableObject
    {
        [Header("Phase Identity")]
        [Tooltip("Name of this phase (e.g., 'Draw Phase', 'Main Phase', 'Combat Phase')")]
        public string phaseName;

        [TextArea(2, 4)]
        [Tooltip("What happens during this phase?")]
        public string description;

        [Header("Phase Behavior")]
        [Tooltip("Does this phase happen automatically or require player action?")]
        public PhaseType phaseType;

        [Tooltip("Can the player skip this phase?")]
        public bool canBeSkipped = false;

        [Tooltip("Maximum time for this phase in seconds (0 = unlimited)")]
        public float timeLimit = 0f;

        [Header("Allowed Actions")]
        [Tooltip("Can the player play cards during this phase?")]
        public bool canPlayCards = false;

        [Tooltip("Which card types can be played?")]
        public List<string> allowedCardTypes = new List<string>();

        [Tooltip("Can the player attack during this phase?")]
        public bool canAttack = false;

        [Tooltip("Can the player activate abilities during this phase?")]
        public bool canActivateAbilities = false;

        [Tooltip("Can the player use keywords during this phase?")]
        public bool canUseKeywords = true;

        [Header("Automatic Actions")]
        [Tooltip("Does the player draw cards at the start of this phase?")]
        public bool autoDrawCards = false;

        [Tooltip("How many cards to draw automatically?")]
        public int cardsToDraw = 1;

        [Tooltip("Does the player gain resources at the start of this phase?")]
        public bool autoGainResources = false;

        [Tooltip("How much resource to gain?")]
        public int resourcesToGain = 1;

        [Tooltip("Trigger these keywords at phase start")]
        public List<KeywordDefinition> onPhaseStartKeywords = new List<KeywordDefinition>();

        [Tooltip("Trigger these keywords at phase end")]
        public List<KeywordDefinition> onPhaseEndKeywords = new List<KeywordDefinition>();

        [Header("Transition")]
        [Tooltip("What happens when this phase ends?")]
        public PhaseTransition transitionType;

        [Tooltip("Automatically move to next phase after X seconds (0 = manual)")]
        public float autoTransitionDelay = 0f;

        [Header("Visual")]
        [Tooltip("Background color during this phase")]
        public Color phaseColor = Color.white;

        [Tooltip("Icon representing this phase")]
        public Sprite phaseIcon;

        [Tooltip("Display message when phase begins")]
        public string phaseStartMessage;
    }

    /// <summary>
    /// Type of phase behavior
    /// </summary>
    public enum PhaseType
    {
        Automatic,      // Phase executes automatically (e.g., Draw Phase)
        PlayerAction,   // Player takes actions (e.g., Main Phase)
        Interactive,    // Both automatic and player actions
        Resolution      // Resolve pending effects
    }

    /// <summary>
    /// How the phase transitions to the next
    /// </summary>
    public enum PhaseTransition
    {
        Manual,         // Player must click "Next Phase" or "End Turn"
        Automatic,      // Moves to next phase automatically
        Conditional,    // Moves when a condition is met
        Timed           // Moves after time expires
    }
}
