namespace IdSentinel.Saml2.Core.Protocols.Assertions
{
    public class AuthnQuery : SubjectQuery
    {
        /// <summary>
        /// If present, specifies a filter for possible responses. Such a query asks the question “What assertions
        /// containing authentication statements do you have for this subject within the context of the supplied
        /// session information?”
        /// </summary>
        public string? SessionIndex { get; set; }

        /// <summary>
        /// If present, specifies a filter for possible responses. Such a query asks the question "What assertions
        /// containing authentication statements do you have for this subject that satisfy the authentication
        /// context requirements in this element?"
        /// </summary>
        public List<RequestedAuthnContext> RequestedAuthnContext { get; set; }
    }
}
