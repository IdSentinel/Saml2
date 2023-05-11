namespace IdSentinel.Saml2.Core.Assertions.Conditions
{
    public class ProxyRestriction
    {
        /// <summary>
        /// Specifies the maximum number of indirections that the asserting party permits to exist between this
        /// assertion and an assertion which has ultimately been issued on the basis of it.
        /// </summary>
        public uint? Count { get; set; }

        /// <summary>
        /// Specifies the maximum number of indirections that the asserting party permits to exist between this
        /// assertion and an assertion which has ultimately been issued on the basis of it.
        /// </summary>
        public List<Uri> Audiences { get; set; }
    }
}
