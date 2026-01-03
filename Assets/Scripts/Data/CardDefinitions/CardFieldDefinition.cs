using UnityEngine;
using System;
using System.Collections.Generic;

namespace TCGCreator.Data
{
    /// <summary>
    /// Defines a field that cards can have (e.g., Attack, Health, Cost, etc.)
    /// This allows users to create custom card properties without coding
    /// </summary>
    [CreateAssetMenu(fileName = "NewCardField", menuName = "TCG Creator/Card Field Definition")]
    public class CardFieldDefinition : ScriptableObject
    {
        [Header("Field Identity")]
        [Tooltip("Name of this field (e.g., 'Attack', 'Cost', 'Health')")]
        public string fieldName;

        [Tooltip("Internal ID for this field (auto-generated, don't modify)")]
        public string fieldId;

        [TextArea(2, 4)]
        [Tooltip("Description of what this field does")]
        public string description;

        [Header("Field Type")]
        [Tooltip("What type of data does this field hold?")]
        public CardFieldType fieldType;

        [Header("Display Settings")]
        [Tooltip("Should this field be visible on the card?")]
        public bool showOnCard = true;

        [Tooltip("Icon to display with this field (optional)")]
        public Sprite fieldIcon;

        [Tooltip("Color for this field's text/background")]
        public Color fieldColor = Color.white;

        [Header("Default Values")]
        [Tooltip("Default value for integer fields")]
        public int defaultIntValue = 0;

        [Tooltip("Default value for text fields")]
        public string defaultStringValue = "";

        [Tooltip("Default value for boolean fields")]
        public bool defaultBoolValue = false;

        [Tooltip("Options for enum/dropdown fields")]
        public List<string> enumOptions = new List<string>();

        [Header("Validation")]
        [Tooltip("Is this field required for all cards?")]
        public bool isRequired = false;

        [Tooltip("Minimum value (for number fields)")]
        public int minValue = 0;

        [Tooltip("Maximum value (for number fields, -1 for unlimited)")]
        public int maxValue = -1;

        /// <summary>
        /// Generate a unique ID for this field
        /// </summary>
        private void OnValidate()
        {
            if (string.IsNullOrEmpty(fieldId))
            {
                fieldId = Guid.NewGuid().ToString();
            }
        }

        /// <summary>
        /// Get the default value as an object
        /// </summary>
        public object GetDefaultValue()
        {
            switch (fieldType)
            {
                case CardFieldType.Integer:
                    return defaultIntValue;
                case CardFieldType.Text:
                    return defaultStringValue;
                case CardFieldType.Boolean:
                    return defaultBoolValue;
                case CardFieldType.Enum:
                    return enumOptions.Count > 0 ? enumOptions[0] : "";
                default:
                    return null;
            }
        }

        /// <summary>
        /// Validate a value for this field
        /// </summary>
        public bool ValidateValue(object value, out string errorMessage)
        {
            errorMessage = "";

            if (isRequired && value == null)
            {
                errorMessage = $"{fieldName} is required";
                return false;
            }

            if (fieldType == CardFieldType.Integer && value is int intValue)
            {
                if (intValue < minValue)
                {
                    errorMessage = $"{fieldName} must be at least {minValue}";
                    return false;
                }
                if (maxValue >= 0 && intValue > maxValue)
                {
                    errorMessage = $"{fieldName} cannot exceed {maxValue}";
                    return false;
                }
            }

            return true;
        }
    }

    /// <summary>
    /// Types of data a card field can hold
    /// </summary>
    public enum CardFieldType
    {
        Integer,        // Whole numbers (Attack, Health, Cost, etc.)
        Text,           // Strings (Name, Description, etc.)
        Boolean,        // True/False flags
        Enum,           // Dropdown selection (Type, Rarity, etc.)
        KeywordList,    // List of keyword references
        Resource        // Reference to a resource type
    }
}
