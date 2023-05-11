using IdSentinel.Saml2.Core.Assertions.NameIdentifiers;

namespace IdSentinel.Saml2.Core.Assertions.Subjects
{
    public class Subject
    {
        public BaseID BaseID { get; set; }

        public NameID NameID { get; set; }

        /// <summary>
        /// Information that allows the subject to be confirmed. If more than one subject confirmation is provided,
        /// then satisfying any one of them is sufficient to confirm the subject for the purpose of applying the
        /// assertion.
        /// </summary>
        public List<SubjectConfirmation> SubjectConfirmation { get; set; }
    }
}
