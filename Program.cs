using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);

/*
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});*/

var app = builder.Build();

app.Run();

