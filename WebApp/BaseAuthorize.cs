using Microsoft.AspNetCore.Authorization;

namespace WebApp;

public class BaseAuthorize : AuthorizeAttribute
{
    public HashSet<string> Scopes { get; set; }
    public BaseAuthorize(string scope) : base()
        => Scopes = new HashSet<string> {scope};

}


public class AccessTokenScopeAttribute : BaseAuthorize
{
    public HashSet<string> Scopes { get; set; }

    public AccessTokenScopeAttribute(string scope) : base()
        => Scopes = new HashSet<string> {scope};
}
