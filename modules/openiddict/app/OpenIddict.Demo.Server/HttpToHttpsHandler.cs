using OpenIddict.Server;

namespace OpenIddict.Demo.Server;

public sealed class HttpToHttpsHandler : IOpenIddictServerHandler<OpenIddictServerEvents.HandleConfigurationRequestContext>
{
    public static OpenIddictServerHandlerDescriptor Descriptor { get; }
        = OpenIddictServerHandlerDescriptor.CreateBuilder<OpenIddictServerEvents.HandleConfigurationRequestContext>()
            .UseSingletonHandler<HttpToHttpsHandler>()
            .SetOrder(OpenIddictServerHandlers.Discovery.AttachEndpoints.Descriptor.Order + 1)
            .SetType(OpenIddictServerHandlerType.Custom)
            .Build();

    public ValueTask HandleAsync(OpenIddictServerEvents.HandleConfigurationRequestContext context)
    {
        if (context is null)
        {
            throw new ArgumentNullException(nameof(context));
        }

        if (context.AuthorizationEndpoint != null)
        {
            context.AuthorizationEndpoint = new Uri(context.AuthorizationEndpoint.OriginalString.Replace("http://", "https://"));
        }

        if (context.CryptographyEndpoint != null)
        {
            context.CryptographyEndpoint = new Uri(context.CryptographyEndpoint.OriginalString.Replace("http://", "https://"));
        }

        if (context.DeviceEndpoint != null)
        {
            context.DeviceEndpoint = new Uri(context.DeviceEndpoint.OriginalString.Replace("http://", "https://"));
        }

        if (context.IntrospectionEndpoint != null)
        {
            context.IntrospectionEndpoint = new Uri(context.IntrospectionEndpoint.OriginalString.Replace("http://", "https://"));
        }

        if (context.LogoutEndpoint != null)
        {
            context.LogoutEndpoint = new Uri(context.LogoutEndpoint.OriginalString.Replace("http://", "https://"));
        }

        if (context.RevocationEndpoint != null)
        {
            context.RevocationEndpoint = new Uri(context.RevocationEndpoint.OriginalString.Replace("http://", "https://"));
        }

        if (context.TokenEndpoint != null)
        {
            context.TokenEndpoint = new Uri(context.TokenEndpoint.OriginalString.Replace("http://", "https://"));
        }

        if (context.UserinfoEndpoint != null)
        {
            context.UserinfoEndpoint = new Uri(context.UserinfoEndpoint.OriginalString.Replace("http://", "https://"));
        }

        return default;
    }
}
