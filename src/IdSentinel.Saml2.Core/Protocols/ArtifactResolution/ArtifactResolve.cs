namespace IdSentinel.Saml2.Core.Protocols.ArtifactResolution
{
    public class ArtifactResolve : Request
    {
        /// <summary>
        /// The artifact value that the requester received and now wishes to translate into the protocol message it
        /// represents.See[SAMLBind] for specific artifact format information.
        /// </summary>
        public string Artifact { get; set; }
    }
}
