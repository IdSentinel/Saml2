using IdSentinel.Saml2.Core.Assertions.NameIdentifiers;

namespace IdSentinel.Saml2.Core.Protocols
{
    public class StatusResponse
    {
        /// <summary>
        /// An identifier for the response. It is of type xs:ID, and MUST follow the requirements specified in
        /// Section 1.3.4 for identifier uniqueness.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// A reference to the identifier of the request to which the response corresponds, if any. If the response
        /// is not generated in response to a request, or if the ID attribute value of a request cannot be
        /// determined (for example, the request is malformed), then this attribute MUST NOT be present.
        /// Otherwise, it MUST be present and its value MUST match the value of the corresponding request's
        /// ID attribute.
        /// </summary>
        public string? InResponseTo { get; set; }

        /// <summary>
        /// The version of this response. The identifier for the version of SAML defined in this specification is
        /// "2.0". SAML versioning is discussed in Section 4.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The time instant of issue of the response. The time value is encoded in UTC, as described in Section
        /// 1.3.3.
        /// </summary>
        public DateTime IssueInstant { get; set; }

        /// <summary>
        /// A URI reference indicating the address to which this response has been sent. This is useful to prevent
        /// malicious forwarding of responses to unintended recipients, a protection that is required by some
        /// protocol bindings. If it is present, the actual recipient MUST check that the URI reference identifies the
        /// location at which the message was received. If it does not, the response MUST be discarded. Some
        /// protocol bindings may require the use of this attribute (see [SAMLBind]).
        /// </summary>
        public Uri? Destination { get; set; }

        /// <summary>
        /// Indicates whether or not (and under what conditions) consent has been obtained from a principal in
        /// the sending of this request. See Section 8.4 for some URI references that MAY be used as the value
        /// of the Consent attribute and their associated descriptions. If no Consent value is provided, the
        /// identifier urn:oasis:names:tc:SAML:2.0:consent:unspecified (see Section 8.4.1) is in
        /// effect.
        /// </summary>
        public Uri? Consent { get; set; }

        /// <summary>
        /// Identifies the entity that generated the response message. (For more information on this element, see
        /// Section 2.2.5.)
        /// </summary>
        public List<Issuer?> Issuers { get; set; }

        /// <summary>
        /// A code representing the status of the corresponding request.
        /// </summary>
        public Status Status { get; set; }
    }
}
