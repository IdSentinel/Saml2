using IdSentinel.Saml2.Core.Assertions.Subjects;

namespace IdSentinel.Saml2.Core.Tests.Assertions.Subjects
{
    [TestFixture]
    internal class SubjectTests
    {
        [Test]
        public void TestKeyConfirmedSubject()
        {
            ReversableSerialization<Subject>.Test(@"<Subject xmlns:ds=""http://www.w3.org/2000/09/xmldsig#"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:saml=""urn:oasis:names:tc:SAML:2.0:assertion"">
    <NameID Format=""urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress"">
        scott@example.org
    </NameID>
    <SubjectConfirmation Method=""urn:oasis:names:tc:SAML:2.0:cm:holder-of-key"">
        <SubjectConfirmationData xsi:type=""saml:KeyInfoConfirmationDataType"">
            <ds:KeyInfo>
                <ds:KeyName>Scott's Key</ds:KeyName>
            </ds:KeyInfo>
        </SubjectConfirmationData>
    </SubjectConfirmation>
</Subject>");
        }
    }
}
