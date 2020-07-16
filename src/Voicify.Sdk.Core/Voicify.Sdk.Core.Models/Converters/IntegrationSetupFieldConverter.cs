using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Integrations.Setup;

namespace Voicify.Sdk.Core.Models.Converters
{
    public class IntegrationSetupFieldConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IIntegrationSetupField);
        }
        public override void WriteJson(JsonWriter writer,
            object value, JsonSerializer serializer)
        {
            throw new InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader,
            Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var field = default(IIntegrationSetupField);
            var fieldToken = jsonObject["FieldType"];
            if (fieldToken is null)
                fieldToken = jsonObject["fieldType"];
            switch (fieldToken.ToString())
            {
                case nameof(CheckboxField):
                    field = new CheckboxField();
                    break;
                case nameof(ShortTextField):
                    field = new ShortTextField();
                    break;
                case nameof(LongTextField):
                    field = new LongTextField();
                    break;
                case nameof(SsmlField):
                    field = new SsmlField();
                    break;
                case nameof(SelectField):
                    field = new SelectField();
                    break;
                case nameof(SwitchField):
                    field = new SwitchField();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), field);
            return field;
        }
    }
}
