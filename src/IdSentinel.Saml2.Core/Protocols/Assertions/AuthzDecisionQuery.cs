using IdSentinel.Saml2.Core.Assertions.Statements;

namespace IdSentinel.Saml2.Core.Protocols.Assertions
{
    public class AuthzDecisionQuery : SubjectQuery
    {
        /// <summary>
        /// A URI reference indicating the resource for which authorization is requested.
        /// </summary>
        public Uri Resource { get; set; }

        /// <summary>
        /// The actions for which authorization is requested. For more information on this element, see Section
        /// 2.7.4.2.
        /// </summary>
        public List<Core.Assertions.Statements.Action> Actions { get; set; }

        /// <summary>
        /// A set of assertions that the SAML authority MAY rely on in making its authorization decision. For more
        /// information on this element, see Section 2.7.4.3.
        /// </summary>
        public List<Evidence> Evidences { get; set; }
    }
}
