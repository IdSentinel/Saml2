namespace IdSentinel.Saml2.Core.Assertions.Conditions
{
    public class Conditions
    {
        /// <summary>
        /// Specifies the earliest time instant at which the assertion is valid. The time value is encoded in UTC, as
        /// described in Section 1.3.3.
        /// </summary>
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// Specifies the time instant at which the assertion has expired. The time value is encoded in UTC, as
        /// described in Section 1.3.3.
        /// </summary>
        public DateTime? NotOnOrAfter { get; set; }

        /// <summary>
        /// A condition of a type defined in an extension schema. An xsi:type attribute MUST be used to
        /// indicate the actual condition type.
        /// </summary>
        public List<Condition> Condition { get; set; }
    }
}
