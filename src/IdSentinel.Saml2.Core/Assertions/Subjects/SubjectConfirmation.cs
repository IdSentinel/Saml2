using IdSentinel.Saml2.Core.Assertions.NameIdentifiers;

namespace IdSentinel.Saml2.Core.Assertions.Subjects
{
    public class SubjectConfirmation
    {
        /// <summary>
        /// A URI reference that identifies a protocol or mechanism to be used to confirm the subject. URI
        /// references identifying SAML-defined confirmation methods are currently defined in the SAML profiles
        /// specification [SAMLProf]. Additional methods MAY be added by defining new URIs and profiles or by
        /// private agreement.
        /// </summary>
        public Uri Method { get; set; }

        public List<BaseID> BaseID { get; set; }

        public List<NameID> NameID { get; set; }

        /// <summary>
        /// Additional confirmation information to be used by a specific confirmation method. For example, typical
        /// content of this element might be a <ds:KeyInfo> element as defined in the XML Signature Syntax
        /// and Processing specification [XMLSig], which identifies a cryptographic key (See also Section
        /// 2.4.1.3). Particular confirmation methods MAY define a schema type to describe the elements,
        /// attributes, or content that may appear in the <SubjectConfirmationData> element.
        /// </summary>
        public List<SubjectConfirmationData> SubjectConfirmationData { get; set; }
    }
}
