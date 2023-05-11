namespace IdSentinel.Saml2.Core.Protocols
{
    public class Status
    {
        /// <summary>
        /// A code representing the status of the activity carried out in response to the corresponding request.
        /// </summary>
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// A message which MAY be returned to an operator.
        /// </summary>
        public string StatusMessage { get; set; }
    }
}
