using IdSentinel.Saml2.Core.Assertions.Subjects;

namespace IdSentinel.Saml2.Core.Protocols.Assertions
{
    public abstract class SubjectQuery : Request
    {
        public Subject Subject { get; set; }
    }
}
