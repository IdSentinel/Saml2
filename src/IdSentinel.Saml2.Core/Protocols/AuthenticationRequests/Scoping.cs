namespace IdSentinel.Saml2.Core.Protocols.AuthenticationRequests
{
    public class Scoping
    {
        /// <summary>
        /// Specifies the number of proxying indirections permissible between the identity provider that receives
        /// this <AuthnRequest> and the identity provider who ultimately authenticates the principal.A count of
        /// zero permits no proxying, while omitting this attribute expresses no such restriction.
        /// </summary>
        public uint ProxyCount { get; set; }

        /// <summary>
        /// An advisory list of identity providers and associated information that the requester deems acceptable
        /// to respond to the request.
        /// </summary>
        public List<IDPList> IDPList { get; set; }

        /// <summary>
        /// Identifies the set of requesting entities on whose behalf the requester is acting. Used to communicate
        /// the chain of requesters when proxying occurs, as described in Section 3.4.1.5. See Section 8.3.6 for a
        /// description of entity identifiers.
        /// </summary>
        public Uri RequesterID { get; set; }
    }
}
