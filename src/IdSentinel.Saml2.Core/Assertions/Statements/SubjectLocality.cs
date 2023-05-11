namespace IdSentinel.Saml2.Core.Assertions.Statements
{
    public class SubjectLocality
    {
        /// <summary>
        /// The network address of the system from which the principal identified by the subject was
        /// authenticated. IPv4 addresses SHOULD be represented in dotted-decimal format (e.g., "1.2.3.4").
        /// IPv6 addresses SHOULD be represented as defined by Section 2.2 of IETF RFC 3513 [RFC 3513]
        /// (e.g., "FEDC:BA98:7654:3210:FEDC:BA98:7654:3210").
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// The DNS name of the system from which the principal identified by the subject was authenticated.
        /// </summary>
        public string? DNSName { get; set; }
    }
}
