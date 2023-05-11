using IdSentinel.Saml2.Core.Assertions.NameIdentifiers;

namespace IdSentinel.Saml2.Core.Protocols.NameIdentifierManagement
{
    public class ManageNameIDRequest : Request
    {
        /// <summary>
        /// The name identifier and associated descriptive data (in plaintext or encrypted form) that specify the
        /// principal as currently recognized by the identity and service providers prior to this request. (For more\
        /// information on these elements, see Section 2.2.)
        /// </summary>
        public NameID NameID { get; set; }

        public string? NewID { get; set; }

        public Terminate? Terminate { get; set; }
    }
}
