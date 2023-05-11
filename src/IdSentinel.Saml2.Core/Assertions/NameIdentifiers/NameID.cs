namespace IdSentinel.Saml2.Core.Assertions.NameIdentifiers
{
    public class NameID : BaseID
    {
        public string Value { get; set; }

        /// <summary>
        /// A URI reference representing the classification of string-based identifier information. See Section
        /// 8.3 for the SAML-defined URI references that MAY be used as the value of the Format attribute
        /// and their associated descriptions and processing rules.Unless otherwise specified by an element
        /// based on this type, if no Format value is provided, then the value
        /// urn:oasis:names:tc:SAML:1.0:nameid-format:unspecified(see Section 8.3.1) is in
        /// effect.
        /// </summary>
        public Uri? Format { get; set; }

        /// <summary>
        /// A name identifier established by a service provider or affiliation of providers for the entity, if
        /// different from the primary name identifier given in the content of the element.This attribute
        /// provides a means of integrating the use of SAML with existing identifiers already in use by a
        /// service provider.For example, an existing identifier can be "attached" to the entity using the Name
        /// Identifier Management protocol defined in Section 3.6.
        /// </summary>
        public string? SPProvidedID { get; set; }
    }
}
