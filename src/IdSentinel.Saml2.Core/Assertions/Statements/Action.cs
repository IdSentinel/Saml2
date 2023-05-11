namespace IdSentinel.Saml2.Core.Assertions.Statements
{
    public class Action
    {
        public string Value { get; set; }

        /// <summary>
        /// A URI reference representing the namespace in which the name of the specified action is to be
        /// interpreted. If this element is absent, the namespace
        /// urn:oasis:names:tc:SAML:1.0:action:rwedc-negation specified in Section 8.1.2 is in
        /// effect.
        /// </summary>
        public Uri Namespace { get; set; }
    }
}
