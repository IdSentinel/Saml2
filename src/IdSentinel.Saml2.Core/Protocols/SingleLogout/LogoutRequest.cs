using IdSentinel.Saml2.Core.Assertions.NameIdentifiers;

namespace IdSentinel.Saml2.Core.Protocols.SingleLogout
{
    public class LogoutRequest : Request
    {
        /// <summary>
        /// The time at which the request expires, after which the recipient may discard the message. The time
        /// value is encoded in UTC, as described in Section 1.3.3.
        /// </summary>
        public DateTime? NotOnOrAfter { get; set; }

        public string? Reason { get; set; }

        public BaseID BaseID { get; set; }

        /// <summary>
        /// The identifier that indexes this session at the message recipient
        /// </summary>
        public List<string> SessionIndex { get; set; }
    }
}
