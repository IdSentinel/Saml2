using IdSentinel.Saml2.Core.Assertions.NameIdentifiers;
using IdSentinel.Saml2.Core.Assertions.Statements;
using IdSentinel.Saml2.Core.Assertions.Subjects;

namespace IdSentinel.Saml2.Core.Assertions.Assertions
{
    public class Assertion
    {
        /// <summary>
        /// The version of this assertion. The identifier for the version of SAML defined in this specification is
        /// "2.0". SAML versioning is discussed in Section 4.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The identifier for this assertion. It is of type xs:ID, and MUST follow the requirements specified in
        /// Section 1.3.4 for identifier uniqueness.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The time instant of issue in UTC, as described in Section 1.3.3.
        /// </summary>
        public DateTime IssueInstant { get; set; }

        /// <summary>
        /// The SAML authority that is making the claim(s) in the assertion. The issuer SHOULD be unambiguous
        /// to the intended relying parties.
        /// 
        /// This specification defines no particular relationship between the entity represented by this element
        /// and the signer of the assertion (if any). Any such requirements imposed by a relying party that
        /// consumes the assertion or by specific profiles are application-specific.
        /// </summary>
        public Issuer Issuer { get; set; }

        /// <summary>
        /// The subject of the statement(s) in the assertion.
        /// </summary>
        public List<Subject> Subjects { get; set; }

        /// <summary>
        /// Conditions that MUST be evaluated when assessing the validity of and/or when using the assertion.
        /// See Section 2.5 for additional information on how to evaluate conditions.
        /// </summary>
        public List<Conditions.Conditions> Conditions { get; set; }

        /// <summary>
        /// Additional information related to the assertion that assists processing in certain situations but which
        /// MAY be ignored by applications that do not understand the advice or do not wish to make use of it.
        /// </summary>
        public List<Advice> Advices { get; set; }

        public List<Statement> Statements { get; set; }
    }
}
