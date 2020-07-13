# Introduction 

TODO

# Getting Started

TODO

# Build and Test
This project contains core models for all Voicify integrations including API models and other custom models.
There are some steps to autogenerate the C# models from the swagger API models that Voicify outputs.

## Generate Models from Swagger

Sample:

```
java -jar swagger-codegen-cli.jar generate -i http://cms.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -Dmodels -o ../../src/Voicify.Sdk.Core/Voicify.Sdk.Core.Models/Generated/CMS -DmodelTests=false
```

```
java -jar swagger-codegen-cli.jar generate -i http://assistant.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -Dmodels -o ../../src/Voicify.Sdk.Core/Voicify.Sdk.Core.Models/Generated/Assistant -DmodelTests=false
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