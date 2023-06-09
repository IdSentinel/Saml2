﻿using IdSentinel.Saml2.Core.Protocols.Assertions;

namespace IdSentinel.Saml2.Core.Tests.Protocols.Assertions
{
    [TestFixture]
    internal class ResponseTests
    {
        [Test]
        public void TestResponse()
        {
            ReversableSerialization<Response>.Test(@"<Response
    IssueInstant=""2003-04-17T00:46:02Z"" Version=""2.0""
    ID=""_c7055387-af61-4fce-8b98-e2927324b306""
    xmlns=""urn:oasis:names:tc:SAML:2.0:protocol""
    xmlns:saml=""urn:oasis:names:tc:SAML:2.0:assertion"">
    <saml:Issuer>https://www.opensaml.org/IDP""</saml:Issuer>
    <ds:Signature xmlns:ds=""http://www.w3.org/2000/09/xmldsig#"">
        <ds:SignedInfo>
            <ds:CanonicalizationMethod
                Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#""/>
            <ds:SignatureMethod
                Algorithm=""http://www.w3.org/2000/09/xmldsig#rsa-sha1""/>
            <ds:Reference URI=""#_c7055387-af61-4fce-8b98-e2927324b306"">
                <ds:Transforms>
                    <ds:Transform
                        Algorithm=""http://www.w3.org/2000/09/xmldsig#enveloped-signature""/>
                    <ds:Transform
                        Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#"">
                    <InclusiveNamespaces PrefixList=""#default saml ds xs xsi""
                        xmlns=""http://www.w3.org/2001/10/xml-exc-c14n#""/>
                    </ds:Transform>
                </ds:Transforms>
                <ds:DigestMethod
                    Algorithm=""http://www.w3.org/2000/09/xmldsig#sha1""/>
                <ds:DigestValue>TCDVSuG6grhyHbzhQFWFzGrxIPE=</ds:DigestValue>
            </ds:Reference>
        </ds:SignedInfo>
        <ds:SignatureValue>
            x/GyPbzmFEe85pGD3c1aXG4Vspb9V9jGCjwcRCKrtwPS6vdVNCcY5rHaFPYWkf+5
            EIYcPzx+pX1h43SmwviCqXRjRtMANWbHLhWAptaK1ywS7gFgsD01qjyen3CP+m3D
            w6vKhaqledl0BYyrIzb4KkHO4ahNyBVXbJwqv5pUaE4=
        </ds:SignatureValue>
        <ds:KeyInfo>
            <ds:X509Data>
                <ds:X509Certificate>
                    MIICyjCCAjOgAwIBAgICAnUwDQYJKoZIhvcNAQEEBQAwgakxCzAJBgNVBAYTAlVT
                    MRIwEAYDVQQIEwlXaXNjb25zaW4xEDAOBgNVBAcTB01hZGlzb24xIDAeBgNVBAoT
                    F1VuaXZlcnNpdHkgb2YgV2lzY29uc2luMSswKQYDVQQLEyJEaXZpc2lvbiBvZiBJ
                    bmZvcm1hdGlvbiBUZWNobm9sb2d5MSUwIwYDVQQDExxIRVBLSSBTZXJ2ZXIgQ0Eg
                    LS0gMjAwMjA3MDFBMB4XDTAyMDcyNjA3Mjc1MVoXDTA2MDkwNDA3Mjc1MVowgYsx
                    CzAJBgNVBAYTAlVTMREwDwYDVQQIEwhNaWNoaWdhbjESMBAGA1UEBxMJQW5uIEFy
                    Ym9yMQ4wDAYDVQQKEwVVQ0FJRDEcMBoGA1UEAxMTc2hpYjEuaW50ZXJuZXQyLmVk
                    dTEnMCUGCSqGSIb3DQEJARYYcm9vdEBzaGliMS5pbnRlcm5ldDIuZWR1MIGfMA0G
                    CSqGSIb3DQEBAQUAA4GNADCBiQKBgQDZSAb2sxvhAXnXVIVTx8vuRay+x50z7GJj
                    IHRYQgIv6IqaGG04eTcyVMhoekE0b45QgvBIaOAPSZBl13R6+KYiE7x4XAWIrCP+
                    c2MZVeXeTgV3Yz+USLg2Y1on+Jh4HxwkPFmZBctyXiUr6DxF8rvoP9W7O27rhRjE
                    pmqOIfGTWQIDAQABox0wGzAMBgNVHRMBAf8EAjAAMAsGA1UdDwQEAwIFoDANBgkq
                    hkiG9w0BAQQFAAOBgQBfDqEW+OI3jqBQHIBzhujN/PizdN7s/z4D5d3pptWDJf2n
                    qgi7lFV6MDkhmTvTqBtjmNk3No7v/dnP6Hr7wHxvCCRwubnmIfZ6QZAv2FU78pLX
                    8I3bsbmRAUg4UP9hH6ABVq4KQKMknxu1xQxLhpR1ylGPdiowMNTrEG8cCx3w/w==
                </ds:X509Certificate>
            </ds:X509Data>
        </ds:KeyInfo>
    </ds:Signature>
    <Status>
        <StatusCode Value=""urn:oasis:names:tc:SAML:2.0:status:Success""/>
    </Status>
    <Assertion ID=""_a75adf55-01d7-40cc-929f-dbd8372ebdfc""
        IssueInstant=""2003-04-17T00:46:02Z"" Version=""2.0""
        xmlns=""urn:oasis:names:tc:SAML:2.0:assertion"">
            <Issuer>https://www.opensaml.org/IDP</Issuer>
            <ds:Signature xmlns:ds=""http://www.w3.org/2000/09/xmldsig#"">
                <ds:SignedInfo>
                    <ds:CanonicalizationMethod
                        Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#""/>
                    <ds:SignatureMethod
                        Algorithm=""http://www.w3.org/2000/09/xmldsig#rsa-sha1""/>
                    <ds:Reference URI=""#_a75adf55-01d7-40cc-929f-dbd8372ebdfc"">
                        <ds:Transforms>
                            <ds:Transform
                            Algorithm=""http://www.w3.org/2000/09/xmldsig#enveloped-signature""/>
                            <ds:Transform
                            Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#"">
                            <InclusiveNamespaces
                                PrefixList=""#default saml ds xs xsi""
                                xmlns=""http://www.w3.org/2001/10/xml-exc-c14n#""/>
                            </ds:Transform>
                        </ds:Transforms>
                        <ds:DigestMethod
                            Algorithm=""http://www.w3.org/2000/09/xmldsig#sha1""/>
                        <ds:DigestValue>Kclet6XcaOgOWXM4gty6/UNdviI=</ds:DigestValue>
                    </ds:Reference>
                </ds:SignedInfo>
                <ds:SignatureValue>
                    hq4zk+ZknjggCQgZm7ea8fI79gJEsRy3E8LHDpYXWQIgZpkJN9CMLG8ENR4Nrw+n
                    7iyzixBvKXX8P53BTCT4VghPBWhFYSt9tHWu/AtJfOTh6qaAsNdeCyG86jmtp3TD
                    MwuL/cBUj2OtBZOQMFn7jQ9YB7klIz3RqVL+wNmeWI4=
                </ds:SignatureValue>
                <ds:KeyInfo>
                    <ds:X509Data>
                        <ds:X509Certificate>
                            MIICyjCCAjOgAwIBAgICAnUwDQYJKoZIhvcNAQEEBQAwgakxCzAJBgNVBAYTAlVT
                            MRIwEAYDVQQIEwlXaXNjb25zaW4xEDAOBgNVBAcTB01hZGlzb24xIDAeBgNVBAoT
                            F1VuaXZlcnNpdHkgb2YgV2lzY29uc2luMSswKQYDVQQLEyJEaXZpc2lvbiBvZiBJ
                            bmZvcm1hdGlvbiBUZWNobm9sb2d5MSUwIwYDVQQDExxIRVBLSSBTZXJ2ZXIgQ0Eg
                            LS0gMjAwMjA3MDFBMB4XDTAyMDcyNjA3Mjc1MVoXDTA2MDkwNDA3Mjc1MVowgYsx
                            CzAJBgNVBAYTAlVTMREwDwYDVQQIEwhNaWNoaWdhbjESMBAGA1UEBxMJQW5uIEFy
                            Ym9yMQ4wDAYDVQQKEwVVQ0FJRDEcMBoGA1UEAxMTc2hpYjEuaW50ZXJuZXQyLmVk
                            dTEnMCUGCSqGSIb3DQEJARYYcm9vdEBzaGliMS5pbnRlcm5ldDIuZWR1MIGfMA0G
                            CSqGSIb3DQEBAQUAA4GNADCBiQKBgQDZSAb2sxvhAXnXVIVTx8vuRay+x50z7GJj
                            IHRYQgIv6IqaGG04eTcyVMhoekE0b45QgvBIaOAPSZBl13R6+KYiE7x4XAWIrCP+
                            c2MZVeXeTgV3Yz+USLg2Y1on+Jh4HxwkPFmZBctyXiUr6DxF8rvoP9W7O27rhRjE
                            pmqOIfGTWQIDAQABox0wGzAMBgNVHRMBAf8EAjAAMAsGA1UdDwQEAwIFoDANBgkq
                            hkiG9w0BAQQFAAOBgQBfDqEW+OI3jqBQHIBzhujN/PizdN7s/z4D5d3pptWDJf2n
                            qgi7lFV6MDkhmTvTqBtjmNk3No7v/dnP6Hr7wHxvCCRwubnmIfZ6QZAv2FU78pLX
                            8I3bsbmRAUg4UP9hH6ABVq4KQKMknxu1xQxLhpR1ylGPdiowMNTrEG8cCx3w/w==
                        </ds:X509Certificate>
                    </ds:X509Data>
                </ds:KeyInfo>
            </ds:Signature>
            <Subject>
                <NameID
                    Format=""urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress"">
                    scott@example.org
                </NameID>
                <SubjectConfirmation
                    Method=""urn:oasis:names:tc:SAML:2.0:cm:bearer""/>
            </Subject>
            <Conditions NotBefore=""2003-04-17T00:46:02Z""
                NotOnOrAfter=""2003-04-17T00:51:02Z"">
            <AudienceRestriction>
                <Audience>http://www.opensaml.org/SP</Audience>
            </AudienceRestriction>
        </Conditions>
        <AuthnStatement AuthnInstant=""2003-04-17T00:46:00Z"">
            <AuthnContext>
                <AuthnContextClassRef>
                    urn:oasis:names:tc:SAML:2.0:ac:classes:Password
                </AuthnContextClassRef>
            </AuthnContext>
        </AuthnStatement>
    </Assertion>
</Response>");
        }
    }
}
