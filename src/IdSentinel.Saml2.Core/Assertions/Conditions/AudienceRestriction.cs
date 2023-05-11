namespace IdSentinel.Saml2.Core.Assertions.Conditions
{
    public class AudienceRestriction
        : Condition
    {
        public List<Uri> Audiences { get; set; }
    }
}
