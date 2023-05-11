namespace IdSentinel.Saml2.Core.Protocols.AuthenticationRequests
{
    public class NameIDPolicy
    {
        /// <summary>
        /// Specifies the URI reference corresponding to a name identifier format defined in this or another
        /// specification (see Section 8.3 for examples). The additional value of
        /// urn:oasis:names:tc:SAML:2.0:nameid-format:encrypted is defined specifically for use
        /// within this attribute to indicate a request that the resulting identifier be encrypted.
        /// </summary>
        public Uri? Format { get; set; }

        /// <summary>
        /// Optionally specifies that the assertion subject's identifier be returned (or created) in the namespace of
        /// a service provider other than the requester, or in the namespace of an affiliation group of service
        /// providers. See for example the definition of urn:oasis:names:tc:SAML:2.0:nameidformat:persistent in Section 8.3.7.
        /// </summary>
        public string? SPNameQualifier { get; set; }

        /// <summary>
        /// A Boolean value used to indicate whether the identity provider is allowed, in the course of fulfilling the
        /// request, to create a new identifier to represent the principal. Defaults to "false". When "false", the
        /// requester constrains the identity provider to only issue an assertion to it if an acceptable identifier for
        /// the principal has already been established. Note that this does not prevent the identity provider from
        /// creating such identifiers outside the context of this specific request (for example, in advance for a
        /// large number of principals).
        /// </summary>
        public bool? AllowCreate { get; set; }
    }
}
