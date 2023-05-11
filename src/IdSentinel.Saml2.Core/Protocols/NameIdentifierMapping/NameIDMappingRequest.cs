using IdSentinel.Saml2.Core.Assertions.NameIdentifiers;
using IdSentinel.Saml2.Core.Protocols.AuthenticationRequests;

namespace IdSentinel.Saml2.Core.Protocols.NameIdentifierMapping
{
    public class NameIDMappingRequest
    {
        /// <summary>
        /// The identifier and associated descriptive data that specify the principal as currently recognized by the
        /// requester and the responder. (For more information on this element, see Section 2.2.)
        /// </summary>
        public BaseID BaseID { get; set; }

        /// <summary>
        /// The requirements regarding the format and optional name qualifier for the identifier to be returned.
        /// </summary>
        public NameIDPolicy NameIDPolicy { get; set; }
    }
}
