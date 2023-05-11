namespace IdSentinel.Saml2.Core.Assertions.Subjects
{
    public class SubjectConfirmationData
    {
        /// <summary>
        /// A time instant before which the subject cannot be confirmed. The time value is encoded in UTC, as
        /// described in Section 1.3.3.
        /// </summary>
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// A time instant at which the subject can no longer be confirmed. The time value is encoded in UTC, as
        /// described in Section 1.3.3.
        /// </summary>
        public DateTime? NotOnOrAfter { get; set; }

        /// <summary>
        /// A URI specifying the entity or location to which an attesting entity can present the assertion. For
        /// example, this attribute might indicate that the assertion must be delivered to a particular network
        /// endpoint in order to prevent an intermediary from redirecting it someplace else.
        /// </summary>
        public Uri? Recipient { get; set; }

        /// <summary>
        /// The ID of a SAML protocol message in response to which an attesting entity can present the
        /// assertion. For example, this attribute might be used to correlate the assertion to a SAML request that
        /// resulted in its presentation.
        /// </summary>
        public string InResponseTo { get; set; }

        /// <summary>
        /// The network address/location from which an attesting entity can present the assertion. For example,
        /// this attribute might be used to bind the assertion to particular client addresses to prevent an attacker
        /// from easily stealing and presenting the assertion from another location. IPv4 addresses SHOULD be
        /// represented in the usual dotted-decimal format (e.g., "1.2.3.4"). IPv6 addresses SHOULD be
        /// represented as defined by Section 2.2 of IETF RFC 3513 [RFC 3513] (e.g.,
        /// "FEDC:BA98:7654:3210:FEDC:BA98:7654:3210").
        /// </summary>
        public string Address { get; set; }
    }
}
