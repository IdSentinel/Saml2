# Saml2

To regenerate files execute

```cmd
xsd specs\xmldsig-core-schema.xsd \
	specs\xenc-schema.xsd  \
	specs\saml-schema-assertion-2.0.xsd \
	/classes \
	/out:src\IdSentinel.Saml2.Core\Generated\ \
	/namespace:IdSentinel.Saml2.Core.Generated
```