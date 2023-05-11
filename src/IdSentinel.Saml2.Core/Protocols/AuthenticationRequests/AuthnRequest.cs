
using IdSentinel.Saml2.Core.Assertions.Conditions;
using IdSentinel.Saml2.Core.Assertions.Subjects;
using IdSentinel.Saml2.Core.Protocols.Assertions;

namespace IdSentinel.Saml2.Core.Protocols.AuthenticationRequests
{
    public class AuthnRequest : Request
    {
        /// <summary>
        /// A Boolean value. If "true", the identity provider MUST authenticate the presenter directly rather than
        /// rely on a previous security context. If a value is not provided, the default is "false". However, if both
        /// ForceAuthn and IsPassive are "true", the identity provider MUST NOT freshly authenticate the
        /// presenter unless the constraints of IsPassive can be met.
        /// </summary>
        public bool? ForceAuthn { get; set; }

        /// <summary>
        /// A Boolean value. If "true", the identity provider and the user agent itself MUST NOT visibly take control
        /// of the user interface from the requester and interact with the presenter in a noticeable fashion. If a
        /// value is not provided, the default is "false".
        /// </summary>
        public bool? IsPassive { get; set; }

        /// <summary>
        /// Indirectly identifies the location to which the <Response> message should be returned to the
        /// requester. It applies only to profiles in which the requester is different from the presenter, such as the
        /// Web Browser SSO profile in [SAMLProf]. The identity provider MUST have a trusted means to map
        /// the index value in the attribute to a location associated with the requester. [SAMLMeta] provides one
        /// possible mechanism. If omitted, then the identity provider MUST return the <Response> message to
        /// the default location associated with the requester for the profile of use. If the index specified is invalid,
        /// then the identity provider MAY return an error <Response> or it MAY use the default location. Thisattribute is mutually exclusive with the AssertionConsumerServiceURL and ProtocolBinding
        /// attributes.
        /// </summary>
        public ushort? AssertionConsumerServiceIndex { get; set; }

        /// <summary>
        /// Specifies by value the location to which the <Response> message MUST be returned to the
        /// requester. The responder MUST ensure by some means that the value specified is in fact associated
        /// with the requester. [SAMLMeta] provides one possible mechanism; signing the enclosing
        /// <AuthnRequest> message is another. This attribute is mutually exclusive with the
        /// AssertionConsumerServiceIndex attribute and is typically accompanied by the
        /// ProtocolBinding attribute.
        /// </summary>
        public Uri? AssertionConsumerServiceURL { get; set; }

        /// <summary>
        /// Indirectly identifies information associated with the requester describing the SAML attributes the
        /// requester desires or requires to be supplied by the identity provider in the <Response> message. The
        /// identity provider MUST have a trusted means to map the index value in the attribute to information
        /// associated with the requester. [SAMLMeta] provides one possible mechanism. The identity provider
        /// MAY use this information to populate one or more <saml:AttributeStatement> elements in the
        /// assertion(s) it returns.
        /// </summary>
        public ushort? AttributeConsumingServiceIndex { get; set; }

        /// <summary>
        /// A URI reference that identifies a SAML protocol binding to be used when returning the <Response>
        /// message. See [SAMLBind] for more information about protocol bindings and URI references defined
        /// for them. This attribute is mutually exclusive with the AssertionConsumerServiceIndex attribute
        /// and is typically accompanied by the AssertionConsumerServiceURL attribute.
        /// ProtocolBinding attribute.
        /// </summary>
        public Uri? ProtocolBinding { get; set; }

        /// <summary>
        /// Specifies the human-readable name of the requester for use by the presenter's user agent or the
        /// identity provider.
        /// </summary>
        public string? ProviderName { get; set; }

        /// <summary>
        /// Specifies the requested subject of the resulting assertion(s). This may include one or more
        /// <saml:SubjectConfirmation> elements to indicate how and/or by whom the resulting assertions
        /// can be confirmed.For more information on this element, see Section 2.4.
        /// If entirely omitted or if no identifier is included, the presenter of the message is presumed to be the
        /// requested subject. If no <saml:SubjectConfirmation> elements are included, then the presenter
        /// is presumed to be the only attesting entity required and the method is implied by the profile of use
        /// and/or the policies of the identity provider.
        /// </summary>
        public List<Subject> Subjects { get; set; }

        /// <summary>
        /// Specifies constraints on the name identifier to be used to represent the requested subject. If omitted,
        /// then any type of identifier supported by the identity provider for the requested subject can be used,
        /// constrained by any relevant deployment-specific policies, with respect to privacy, for example.
        /// </summary>
        public List<NameIDPolicy> NameIDPolicies { get; set; }

        /// <summary>
        /// Specifies the SAML conditions the requester expects to limit the validity and/or use of the resulting
        /// assertion(s). The responder MAY modify or supplement this set as it deems necessary. The
        /// information in this element is used as input to the process of constructing the assertion, rather than as
        /// conditions on the use of the request itself. (For more information on this element, see Section 2.5.)
        /// </summary>
        public List<Conditions> Conditions { get; set; }

        /// <summary>
        /// Specifies the requirements, if any, that the requester places on the authentication context that applies
        /// to the responding provider's authentication of the presenter. See Section 3.3.2.2.1 for processing rules
        /// regarding this element.
        /// </summary>
        public List<RequestedAuthnContext> RequestedAuthnContexts { get; set; }

        /// <summary>
        /// Specifies a set of identity providers trusted by the requester to authenticate the presenter, as well as
        /// limitations and context related to proxying of the <AuthnRequest> message to subsequent identity
        /// providers by the responder.
        /// </summary>
        public List<Scoping> Scopings { get; set; }
    }
}
