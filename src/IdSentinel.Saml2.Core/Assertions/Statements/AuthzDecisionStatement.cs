namespace IdSentinel.Saml2.Core.Assertions.Statements
{
    internal class AuthzDecisionStatement : Statement
    {
        /// <summary>
        /// The set of actions authorized to be performed on the specified resource.
        /// </summary>
        public List<Action> Actions { get; set; }

        /// <summary>
        /// A set of assertions that the SAML authority relied on in making the decision.
        /// </summary>
        public List<Evidence> Evidences { get; set; }

        /// <summary>
        /// A URI reference identifying the resource to which access authorization is sought. This attribute MAY
        /// have the value of the empty URI reference (""), and the meaning is defined to be "the start of the
        /// current document", as specified by IETF RFC 2396 [RFC 2396] Section 4.2.
        /// </summary>
        public Uri Resource { get; set; }

        /// <summary>
        /// The decision rendered by the SAML authority with respect to the specified resource. The value is of
        /// the DecisionType simple type.
        /// </summary>
        public Decision Decision { get; set; }
    }
}
