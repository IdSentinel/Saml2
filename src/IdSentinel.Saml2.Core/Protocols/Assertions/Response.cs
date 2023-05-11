using IdSentinel.Saml2.Core.Assertions.Assertions;

namespace IdSentinel.Saml2.Core.Protocols.Assertions
{
    public class Response : StatusResponse
    {
        public List<Assertion> Assertion { get; set; }
    }
}
