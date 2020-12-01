# Introduction 

This project contains core models used in external Voicify development including:

- Webhook models
- CMS API models
- Assistant API Models
- Integration API Models

# Getting Started

You can install this package from NuGet:

```
Install-Package Voicify.Sdk.Core.Models
```

Then you can pull in any of the namespaces you need by what model you need. For Example, you can create a webhook response model:


```csharp
using Voicify.Sdk.Core.Models.Webhooks.Responses;

// ...

var response = new GeneralFulfillmentResponse
{
    Data = new ContentFulfillmentWebhookData
    {
        Content = "This is now the output speech"
    }
}
```

or create a request for the Custom Assistant API:

```csharp

 var device = new CustomAssistantDevice(
    id: Guid.NewGuid().ToString(),
    name: "Voicify Sample App",
    supportsDisplayText: true,
    supportsTextInput: true
);
var user = new CustomAssistantUser(
    id: Guid.NewGuid().ToString(),
    name: "Sample User"
);

var welcomeContext = CreateContext(string.Empty);
welcomeContext.RequiresLanguageUnderstanding = false;
welcomeContext.RequestName = CustomAssistantIntents.VoicifyWelcome;
var welcomeResponse = await customAssistantApi.HandleRequestAsync(appId, appSecret, new CustomAssistantRequestBody(
    requestId: Guid.NewGuid().ToString(),
    device: device,
    user: user,
    context: welcomeContext
));

static CustomAssistantRequestContext CreateContext(string input)
{
    return new CustomAssistantRequestContext(
        channel: "Voicify Sample App",
        locale: "en-US",
        sessionId: Guid.NewGuid().ToString(),
        requestType: "IntentRequest",
        originalInput: input,
        requiresLanguageUnderstanding: true
    );
}
```

Voicify Partners and Customers can also check out the extended documentation and details at https://support.voicify.com

# Contributing

The Voicify core development team owns this repo and NuGet package, but all Voicify developers are welcome to contribute changes. Before contributing, please create an issue that you can track your PRs against and be sure there is not already a PR open for it.

# Build and Test

This project contains core models for all Voicify integrations including API models and other custom models.
There are some steps to autogenerate the C# models from the swagger API models that Voicify outputs.

## Generate Models from Swagger

Many of the models are generated from Voicify's different API gateways. You can get the latest models from those APIs by generating new models and adjusting accordingly.

Sample:

```
java -jar swagger-codegen-cli.jar generate -i http://cms.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -Dmodels -o ../../src/Voicify.Sdk.Core/Voicify.Sdk.Core.Models/Generated/CMS -DmodelTests=false
```

```
java -jar swagger-codegen-cli.jar generate -i http://assistant.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -Dmodels -o ../../src/Voicify.Sdk.Core/Voicify.Sdk.Core.Models/Generated/Assistant -DmodelTests=false
```

```
java -jar swagger-codegen-cli.jar generate -i http://analytics.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -Dmodels -o ../../src/Voicify.Sdk.Core/Voicify.Sdk.Core.Models/Generated/Analytics -DmodelTests=false
```
```
java -jar swagger-codegen-cli.jar generate -i http://integrations.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -Dmodels -o ../../src/Voicify.Sdk.Core/Voicify.Sdk.Core.Models/Generated/Integrations -DmodelTests=false
```

There may be some conflicts when all the models are generated since some of these APIs share DTOs in their sub models. In that scenario, take the CMS generated model and delete the others.

Some examples where this may happen:

- `UserModel`
- `MediaItemModel`

There are some other things to note about how the C# generator generates these models with the `-Dmodels` flag:

- There is a useless static namespace imported for date time converting. You can do a find and replace to remove this line from all files
- Some inheritance is not properly imported. Namely the Bixby models. In that case, it causes issues with pushing an `override virtual string ToJson()` method. Simply replace this with just `virtual string ToJson()` since it isn't overriding anything.
- Inheritance also messes up some validation. Just replace the calls of `BaseValidate` with `yield break`. Essentially getting rid of the foreach loop if there is one.