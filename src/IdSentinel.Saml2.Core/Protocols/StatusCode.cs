namespace IdSentinel.Saml2.Core.Protocols
{
    public class StatusCode
    {
        /// <summary>
        /// The status code value. This attribute contains a URI reference. The value of the topmost
        /// <StatusCode> element MUST be from the top-level list provided in this section.
        /// </summary>
        public Uri Value { get; set; }
    }
}
