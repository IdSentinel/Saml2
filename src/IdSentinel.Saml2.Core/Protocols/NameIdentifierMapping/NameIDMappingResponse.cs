using IdSentinel.Saml2.Core.Assertions.NameIdentifiers;

namespace IdSentinel.Saml2.Core.Protocols.NameIdentifierMapping
{
    public class NameIDMappingResponse : StatusResponse
    {
        public NameID NameID { get; set; }
    }
}
