using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace IdSentinel.Saml2.Core.Tests
{
    internal static class ReversableSerialization<T>
    {
        public static void Test(string original)
        {
            var originalDocument = new XmlDocument();
            var xmlNamespaceManager = new XmlNamespaceManager(originalDocument.NameTable);
            xmlNamespaceManager.AddNamespace(nameof(XmlNamespaces.samlp), XmlNamespaces.samlp);
            originalDocument.LoadXml(original);
            TestContext.WriteLine("Original:");
            TestContext.WriteLine(originalDocument.OuterXml);

            var roundTrippedDocument = Deserialize(Serialize(originalDocument));
            TestContext.WriteLine("Round Tripped:");
            TestContext.WriteLine(roundTrippedDocument.OuterXml);

            Assert.That(Format(roundTrippedDocument), Is.EqualTo(Format(originalDocument)));
        }

        private static T Serialize(XmlDocument originalDocument)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var reader = new XmlNodeReader(originalDocument);
            return (T)serializer.Deserialize(reader)!;
        }

        private static XmlDocument Deserialize(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            var xmlDocument = new XmlDocument();
            using var writer = xmlDocument.CreateNavigator()?.AppendChild();
            serializer.Serialize(writer, obj);
            return xmlDocument;
        }

        private static string Format(XmlDocument doc)
        {
            var stringBuilder = new StringBuilder();
            var xmlWriterSettings = new XmlWriterSettings
            {
                ConformanceLevel = ConformanceLevel.Document,
                Indent = true,
                NewLineHandling = NewLineHandling.Replace
            };
            using var writer = XmlWriter.Create(stringBuilder, xmlWriterSettings);
            doc.Save(writer);
            return stringBuilder.ToString();
        }

    }
}
