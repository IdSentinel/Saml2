namespace IdSentinel.Saml2.Core.Protocols.Assertions
{
    public class AttributeQuery : SubjectQuery
    {
        /// <summary>
        /// Each <saml:Attribute> element specifies an attribute whose value(s) are to be returned. If no
        /// attributes are specified, it indicates that all attributes allowed by policy are requested. If a given
        /// <saml:Attribute> element contains one or more <saml:AttributeValue> elements, then if
        /// that attribute is returned in the response, it MUST NOT contain any values that are not equal to the
        /// values specified in the query. In the absence of equality rules specified by particular profiles or
        /// attributes, equality is defined as an identical XML representation of the value. For more information on
        /// <saml:Attribute>, see Section 2.7.3.1.
        /// </summary>
        public List<Attribute> Attributes { get; set; }
    }
}
