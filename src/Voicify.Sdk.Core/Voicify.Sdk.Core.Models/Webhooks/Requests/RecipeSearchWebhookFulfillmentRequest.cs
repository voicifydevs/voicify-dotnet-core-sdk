using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Webhooks.Requests;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// Request model sent to a webhoook for recipe searching
    /// </summary>
    public class RecipeSearchWebhookFulfillmentRequest : GeneralWebhookFulfillmentRequest
    {
        public string SearchRecipeName { get; set; }
        public string SearchMealType { get; set; }
        public string SearchIngredientNames { get; set; }
        public TimeSpan? SearchCookTime { get; set; }
    }
}
