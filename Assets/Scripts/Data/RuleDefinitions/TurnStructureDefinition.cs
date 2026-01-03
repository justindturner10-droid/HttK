using UnityEngine;
using System.Collections.Generic;

namespace TCGCreator.Data
{
    /// <summary>
    /// Defines the complete turn structure (sequence of phases)
    /// </summary>
    [CreateAssetMenu(fileName = "NewTurnStructure", menuName = "TCG Creator/Turn Structure")]
    public class TurnStructureDefinition : ScriptableObject
    {
        [Header("Turn Structure Identity")]
        [Tooltip("Name of this turn structure (e.g., 'Standard Turn', 'Fast Paced', 'Complex')")]
        public string structureName;

        [TextArea(2, 4)]
        [Tooltip("Description of this turn structure")]
        public string description;

        [Header("Turn Phases")]
        [Tooltip("The phases that make up a turn, in order")]
        public List<TurnPhaseDefinition> phases = new List<TurnPhaseDefinition>();

        [Header("Turn Settings")]
        [Tooltip("Does the first player skip their first draw?")]
        public bool firstPlayerSkipsFirstDraw = true;

        [Tooltip("Maximum turn time in seconds (0 = unlimited)")]
        public float maxTurnTime = 0f;

        [Tooltip("Can players take actions during opponent's turn?")]
        public bool allowOpponentTurnActions = false;

        [Header("Turn Limits")]
        [Tooltip("Maximum number of cards that can be played per turn (0 = unlimited)")]
        public int maxCardsPerTurn = 0;

        [Tooltip("Maximum number of attacks per turn (0 = unlimited)")]
        public int maxAttacksPerTurn = 0;

        /// <summary>
        /// Get the total number of phases in this turn structure
        /// </summary>
        public int GetPhaseCount()
        {
            return phases.Count;
        }

        /// <summary>
        /// Get a specific phase by index
        /// </summary>
        public TurnPhaseDefinition GetPhase(int index)
        {
            if (index >= 0 && index < phases.Count)
            {
                return phases[index];
            }
            return null;
        }

        /// <summary>
        /// Get the next phase index
        /// </summary>
        public int GetNextPhaseIndex(int currentIndex)
        {
            int nextIndex = currentIndex + 1;
            if (nextIndex >= phases.Count)
            {
                return -1; // End of turn
            }
            return nextIndex;
        }

        /// <summary>
        /// Validate that all phases are properly configured
        /// </summary>
        public bool ValidateStructure(out string errorMessage)
        {
            errorMessage = "";

            if (phases == null || phases.Count == 0)
            {
                errorMessage = "Turn structure must have at least one phase";
                return false;
            }

            for (int i = 0; i < phases.Count; i++)
            {
                if (phases[i] == null)
                {
                    errorMessage = $"Phase {i} is null";
                    return false;
                }
            }

            return true;
        }
    }
}
