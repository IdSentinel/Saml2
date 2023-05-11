namespace IdSentinel.Saml2.Core.Assertions.Statements
{
    public class AuthnStatement
    {
        /// <summary>
        /// Specifies the time at which the authentication took place. The time value is encoded in UTC, as
        /// described in Section 1.3.3.
        /// </summary>
        public DateTime AuthnInstant { get; set; }

        /// <summary>
        /// Specifies the index of a particular session between the principal identified by the subject and the
        /// authenticating authority.
        /// </summary>
        public string SessionIndex { get; set; }

        /// <summary>
        /// Specifies a time instant at which the session between the principal identified by the subject and the
        /// SAML authority issuing this statement MUST be considered ended. The time value is encoded in
        /// UTC, as described in Section 1.3.3. There is no required relationship between this attribute and a
        /// NotOnOrAfter condition attribute that may be present in the assertion.
        /// </summary>
        public DateTime? SessionNotOnOrAfter { get; set; }

        /// <summary>
        /// Specifies the DNS domain name and IP address for the system from which the assertion subject was
        /// apparently authenticated.
        /// </summary>
        public List<SubjectLocality> SubjectLocalities { get; set; }

        public AuthnContext AuthnContext { get; set; }
    }
}
