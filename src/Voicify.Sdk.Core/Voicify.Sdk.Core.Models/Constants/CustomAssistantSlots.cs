using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Constants
{
    /// <summary>
    /// Names of slots used in the custom assistant pipeline.
    /// </summary>
    public static class CustomAssistantSlots
    {
        public const string Query = nameof(Query);
        public const string Dynamic = "VoicifyDynamic";
        public const string LatestMessageCategory = nameof(LatestMessageCategory);
        public const string EventName = nameof(EventName);
        public const string IngredientName = nameof(IngredientName);
        public const string LocationName = nameof(LocationName);
        public const string MealType = nameof(MealType);
        public const string RecipeName = nameof(RecipeName);
        public const string StartTime = nameof(StartTime);
        public const string CookTime = nameof(CookTime);
        public const string StartDate = nameof(StartDate);
        public const string Number = nameof(Number);
        public const string StepNumber = nameof(StepNumber);
        public const string ListItemId = nameof(ListItemId);
    }
}
