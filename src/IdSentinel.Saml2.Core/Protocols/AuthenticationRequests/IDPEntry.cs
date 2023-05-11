namespace IdSentinel.Saml2.Core.Protocols.AuthenticationRequests
{
    public class IDPEntry
    {
        /// <summary>
        /// The unique identifier of the identity provider. See Section 8.3.6 for a description of such identifiers.
        /// </summary>
        public Uri ProviderID { get; set; }

        /// <summary>
        /// A human-readable name for the identity provider.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// A URI reference representing the location of a profile-specific endpoint supporting the authentication
        /// request protocol.The binding to be used must be understood from the profile of use.
        /// </summary>
        public Uri? Loc { get; set; }
    }
}
