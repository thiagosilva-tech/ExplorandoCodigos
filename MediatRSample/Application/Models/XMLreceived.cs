using System.Xml.Serialization;

namespace XmlDeserializationExample
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class Envelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public Body Body { get; set; }
    }

    public class Header { }

    public class Body
    {
        [XmlElement(ElementName = "executarFluxo", Namespace = "http://neurotech.com.br/")]
        public ExecutarFluxo ExecutarFluxo { get; set; }
    }

    public class ExecutarFluxo
    {
        [XmlElement(ElementName = "pCdAssociado", Namespace = "http://neurotech.com.br/")]
        public string CdAssociado { get; set; }

        [XmlElement(ElementName = "pCdFilial", Namespace = "http://neurotech.com.br/")]
        public string CdFilial { get; set; }

        [XmlElement(ElementName = "pSenha", Namespace = "http://neurotech.com.br/")]
        public string Senha { get; set; }

        [XmlElement(ElementName = "pFluxo", Namespace = "http://neurotech.com.br/")]
        public Fluxo Fluxo { get; set; }
    }

    public class Fluxo
    {
        [XmlElement(ElementName = "NmPolitica", Namespace = "http://neurotech.com.br/")]
        public string NmPolitica { get; set; }

        [XmlElement(ElementName = "NmFluxoResultado", Namespace = "http://neurotech.com.br/")]
        public string NmFluxoResultado { get; set; }

        [XmlElement(ElementName = "IdProposta", Namespace = "http://neurotech.com.br/")]
        public int IdProposta { get; set; }

        [XmlArray(ElementName = "LsParametros", Namespace = "http://neurotech.com.br/")]
        [XmlArrayItem(ElementName = "ParametroFluxo", Namespace = "http://neurotech.com.br/")]
        public List<ParametroFluxo> LsParametros { get; set; }
    }

    public class ParametroFluxo
    {
        [XmlElement(ElementName = "NmParametro", Namespace = "http://neurotech.com.br/")]
        public string NmParametro { get; set; }

        [XmlElement(ElementName = "VlParametro", Namespace = "http://neurotech.com.br/")]
        public string VlParametro { get; set; }
    }
}
