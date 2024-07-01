using System.Xml.Serialization;

namespace Xml2CSharp
{
	[XmlRoot(ElementName="ParametroFluxo", Namespace="http://neurotech.com.br/")]
	public class ParametroFluxo {
		[XmlElement(ElementName="NmParametro", Namespace="http://neurotech.com.br/")]
		public string? NmParametro { get; set; }
		[XmlElement(ElementName="VlParametro", Namespace="http://neurotech.com.br/")]
		public string? VlParametro { get; set; }
	}

	[XmlRoot(ElementName="LsParametros", Namespace="http://neurotech.com.br/")]
	public class LsParametros {
		[XmlElement(ElementName="ParametroFluxo", Namespace="http://neurotech.com.br/")]
		public List<ParametroFluxo>? ParametroFluxo { get; set; }
	}

	[XmlRoot(ElementName="pFluxo", Namespace="http://neurotech.com.br/")]
	public class PFluxo {
		[XmlElement(ElementName="NmPolitica", Namespace="http://neurotech.com.br/")]
		public string? NmPolitica { get; set; }
		[XmlElement(ElementName="NmFluxoResultado", Namespace="http://neurotech.com.br/")]
		public string? NmFluxoResultado { get; set; }
		[XmlElement(ElementName="IdProposta", Namespace="http://neurotech.com.br/")]
		public string? IdProposta { get; set; }
		[XmlElement(ElementName="LsParametros", Namespace="http://neurotech.com.br/")]
		public LsParametros? LsParametros { get; set; }
	}

	[XmlRoot(ElementName="executarFluxo", Namespace="http://neurotech.com.br/")]
	public class ExecutarFluxo {
		[XmlElement(ElementName="pCdAssociado", Namespace="http://neurotech.com.br/")]
		public string? PCdAssociado { get; set; }
		[XmlElement(ElementName="pCdFilial", Namespace="http://neurotech.com.br/")]
		public string? PCdFilial { get; set; }
		[XmlElement(ElementName="pSenha", Namespace="http://neurotech.com.br/")]
		public string? PSenha { get; set; }
		[XmlElement(ElementName="pFluxo", Namespace="http://neurotech.com.br/")]
		public PFluxo? PFluxo { get; set; }
		[XmlAttribute(AttributeName="mob", Namespace="http://www.w3.org/2000/xmlns/")]
		public string? Mob { get; set; }
	}

	[XmlRoot(ElementName="Body", Namespace="http://www.w3.org/2003/05/soap-envelope")]
	public class Body {
		[XmlElement(ElementName="executarFluxo", Namespace="http://neurotech.com.br/")]
		public ExecutarFluxo? ExecutarFluxo { get; set; }
	}

	[XmlRoot(ElementName="Envelope", Namespace="http://www.w3.org/2003/05/soap-envelope")]
	public class Envelope {
		[XmlElement(ElementName="Header", Namespace="http://www.w3.org/2003/05/soap-envelope")]
		public string? Header { get; set; }
		[XmlElement(ElementName="Body", Namespace="http://www.w3.org/2003/05/soap-envelope")]
		public Body? Body { get; set; }
		[XmlAttribute(AttributeName="soap", Namespace="http://www.w3.org/2000/xmlns/")]
		public string? Soap { get; set; }
		[XmlAttribute(AttributeName="neur", Namespace="http://www.w3.org/2000/xmlns/")]
		public string? Neur { get; set; }
	}

}
