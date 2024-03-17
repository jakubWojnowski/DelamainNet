using Microsoft.AspNetCore.Mvc;

namespace DelamainNet.Shared.Infrastructure.Api;

public class ProduceDefaultContentTypeAttribute : ProducesAttribute
{
    public ProduceDefaultContentTypeAttribute(Type type) : base(type)
    {
    }

    public ProduceDefaultContentTypeAttribute( params string[] additionalContentTypes) : base("application/json", additionalContentTypes)
    {
    }
}