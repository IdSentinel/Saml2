namespace IdSentinel.Saml2.Core.Assertions.Statements
{
    public class Attribute
    {
        /// <summary>
        /// The name of the attribute.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A URI reference representing the classification of the attribute name for purposes of interpreting the
        /// name. See Section 8.2 for some URI references that MAY be used as the value of the NameFormat
        /// attribute and their associated descriptions and processing rules. If no NameFormat value is provided,
        /// the identifier urn:oasis:names:tc:SAML:2.0:attrname-format:unspecified (see Section
        /// 8.2.1) is in effect.
        /// </summary>
        public Uri? NameFormat { get; set; }

        /// <summary>
        /// A string that provides a more human-readable form of the attribute's name, which may be useful in
        /// cases in which the actual Name is complex or opaque, such as an OID or a UUID.This attribute's
        /// value MUST NOT be used as a basis for formally identifying SAML attributes.
        /// </summary>
        public string? FriendlyName { get; set; }

        /// <summary>
        /// Contains a value of the attribute. If an attribute contains more than one discrete value, it is
        /// RECOMMENDED that each value appear in its own <AttributeValue> element. If more than
        /// one <AttributeValue> element is supplied for an attribute, and any of the elements have a
        /// datatype assigned through xsi:type, then all of the <AttributeValue> elements must have
        /// the identical datatype assigned.
        /// </summary>
        public List<string> AttributeValues { get; set; }
    }
}
