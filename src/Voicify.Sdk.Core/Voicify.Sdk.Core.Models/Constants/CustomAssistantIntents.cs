using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Constants
{
    /// <summary>
    /// Intent names used by the custom assistant pipeline. These can be used for pretraining and sending aligned requests
    /// </summary>
    public static class CustomAssistantIntents
    {
        public const string VoicifyGeneralQuestionIntent = nameof(VoicifyGeneralQuestionIntent);
        public const string VoicifyDynamicIntent = nameof(VoicifyDynamicIntent);
        public const string VoicifyLatestMessageIntent = nameof(VoicifyLatestMessageIntent);
        public const string VoicifyEventGeneralSearch = nameof(VoicifyEventGeneralSearch);
        public const string VoicifyEventLocationSearch = nameof(VoicifyEventLocationSearch);
        public const string VoicifyEventStartTimeSearch = nameof(VoicifyEventStartTimeSearch);
        public const string VoicifyEventStatusSearch = nameof(VoicifyEventStatusSearch);
        public const string VoicifyGoToStep = nameof(VoicifyGoToStep);
        public const string VoicifyHelp = nameof(VoicifyHelp);
        public const string VoicifyMore = nameof(VoicifyMore);
        public const string VoicifyNo = nameof(VoicifyNo);
        public const string VoicifyNumber = nameof(VoicifyNumber);
        public const string VoicifyRecipeDetails = nameof(VoicifyRecipeDetails);
        public const string VoicifyRecipeSearch = nameof(VoicifyRecipeSearch);
        public const string VoicifyStart = nameof(VoicifyStart);
        public const string VoicifyStartOver = nameof(VoicifyStartOver);
        public const string VoicifyStop = nameof(VoicifyStop);
        public const string VoicifyWelcome = nameof(VoicifyWelcome);
        public const string VoicifyYes = nameof(VoicifyYes);
        public const string VoicifyNext = nameof(VoicifyNext);
        public const string VoicifyPrevious = nameof(VoicifyPrevious);
        public const string VoicifyListItemSelect = nameof(VoicifyListItemSelect);
    }
}
