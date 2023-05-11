namespace IdSentinel.Saml2.Core.Protocols.Assertions
{
    public class RequestedAuthnContext
    {
        /// <summary>
        /// Specifies the comparison method used to evaluate the requested context classes or statements, one
        /// of "exact", "minimum", "maximum", or "better". The default is "exact".
        /// </summary>
        public AuthnContextComparison Comparison { get; set; }

        /// <summary>
        /// Specifies one or more URI references identifying authentication context classes or declarations.
        /// These elements are defined in Section 2.7.2.2. For more information about authentication context
        /// classes, see [SAMLAuthnCxt].
        /// </summary>
        public List<Uri> AuthnContextClassRefs { get; set; }

        /// <summary>
        /// Specifies one or more URI references identifying authentication context classes or declarations.
        /// These elements are defined in Section 2.7.2.2. For more information about authentication context
        /// classes, see [SAMLAuthnCxt].
        /// </summary>
        public List<Uri> AuthnContextDeclRefs { get; set; }
    }
}
