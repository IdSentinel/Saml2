using IdSentinel.Saml2.Core.Generated;

namespace IdSentinel.Saml2.Core.Tests.Generated
{
    [TestFixture]
    internal class SubjectTests
    {
        [Test]
        public void TestKeyConfirmedSubject()
        {
            ReversableSerialization<SubjectType>.Test(@"<Subject xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns=""urn:oasis:names:tc:SAML:2.0:assertion"">
  <NameID Format=""urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress"">
    scott@example.org
  </NameID>
  <SubjectConfirmation Method=""urn:oasis:names:tc:SAML:2.0:cm:holder-of-key"">
    <SubjectConfirmationData>Test</SubjectConfirmationData>
  </SubjectConfirmation>
</Subject>");
        }
    }
}
