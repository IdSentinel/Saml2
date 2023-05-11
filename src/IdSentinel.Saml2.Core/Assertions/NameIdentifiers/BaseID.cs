namespace IdSentinel.Saml2.Core.Assertions.NameIdentifiers
{
    public abstract class BaseID
    {
        /// <summary>
        /// The security or administrative domain that qualifies the identifier. This attribute provides a means 
        /// to federate identifiers from disparate user stores without collision.
        /// </summary>
        public string? NameQualifier { get; set; }

        /// <summary>
        /// Further qualifies an identifier with the name of a service provider or affiliation of providers. This
        /// attribute provides an additional means to federate identifiers on the basis of the relying party or
        /// parties.
        /// </summary>
        public string? SpNameQualifier { get; set; }
    }
}
