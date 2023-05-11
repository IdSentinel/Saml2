namespace IdSentinel.Saml2.Core.Protocols.AuthenticationRequests
{
    public class IDPList
    {
        /// <summary>
        /// Information about a single identity provider.
        /// </summary>
        public List<IDPEntry> IDPEntry { get; set; }

        /// <summary>
        /// If the <IDPList> is not complete, using this element specifies a URI reference that can be used to
        /// retrieve the complete list. Retrieving the resource associated with the URI MUST result in an XML
        /// instance whose root element is an <IDPList> that does not itself contain a <GetComplete>
        /// element.
        /// </summary>
        public Uri GetComplete { get; set; }
    }
}
