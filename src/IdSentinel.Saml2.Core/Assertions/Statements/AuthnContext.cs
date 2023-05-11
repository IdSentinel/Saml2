namespace IdSentinel.Saml2.Core.Assertions.Statements
{
    public class AuthnContext
    {
        /// <summary>
        /// A URI reference identifying an authentication context class that describes the authentication context
        /// declaration that follows.
        /// </summary>
        public Uri AuthnContextClassRef { get; set; }

        /// <summary>
        /// Either an authentication context declaration provided by value, or a URI reference that identifies such
        /// a declaration. The URI reference MAY directly resolve into an XML document containing the
        /// referenced declaration.
        /// </summary>
        public Uri AuthnContextDecl { get; set; }

        /// <summary>
        /// Either an authentication context declaration provided by value, or a URI reference that identifies such
        /// a declaration. The URI reference MAY directly resolve into an XML document containing the
        /// referenced declaration.
        /// </summary>
        public Uri AuthnContextDeclRef { get; set; }

        /// <summary>
        /// Zero or more unique identifiers of authentication authorities that were involved in the authentication of
        /// the principal (not including the assertion issuer, who is presumed to have been involved without being
        /// explicitly named here).
        /// </summary>
        public List<Uri> AuthenticatingAuthority { get; set; }

    }
}
