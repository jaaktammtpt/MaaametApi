using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MaaametApi
{
    public class MaaAmetApiResponse
    {
		[XmlRoot(ElementName = "adsTase1")]
		public class AdsTase1
		{
			[XmlElement(ElementName = "kood")]
			public string Kood { get; set; }
			[XmlElement(ElementName = "nimetus")]
			public string Nimetus { get; set; }
			[XmlElement(ElementName = "nimetus_liigiga")]
			public string Nimetus_liigiga { get; set; }
		}

		[XmlRoot(ElementName = "adsTase2")]
		public class AdsTase2
		{
			[XmlElement(ElementName = "kood")]
			public string Kood { get; set; }
			[XmlElement(ElementName = "nimetus")]
			public string Nimetus { get; set; }
			[XmlElement(ElementName = "nimetus_liigiga")]
			public string Nimetus_liigiga { get; set; }
		}

		[XmlRoot(ElementName = "adsTase3")]
		public class AdsTase3
		{
			[XmlElement(ElementName = "kood")]
			public string Kood { get; set; }
			[XmlElement(ElementName = "nimetus")]
			public string Nimetus { get; set; }
			[XmlElement(ElementName = "nimetus_liigiga")]
			public string Nimetus_liigiga { get; set; }
		}

		[XmlRoot(ElementName = "aadress")]
		public class Aadress
		{
			[XmlElement(ElementName = "koodAadress")]
			public string KoodAadress { get; set; }
			[XmlElement(ElementName = "taisAadress")]
			public string TaisAadress { get; set; }
			[XmlElement(ElementName = "punktX")]
			public string PunktX { get; set; }
			[XmlElement(ElementName = "punktY")]
			public string PunktY { get; set; }
			[XmlElement(ElementName = "adsTase1")]
			public AdsTase1 AdsTase1 { get; set; }
			[XmlElement(ElementName = "adsTase2")]
			public AdsTase2 AdsTase2 { get; set; }
			[XmlElement(ElementName = "adsTase3")]
			public AdsTase3 AdsTase3 { get; set; }
		}

		[XmlRoot(ElementName = "aadressid")]
		public class Aadressid
		{
			[XmlElement(ElementName = "aadress")]
			public Aadress Aadress { get; set; }
		}

		[XmlRoot(ElementName = "objekt")]
		public class Objekt
		{
			[XmlElement(ElementName = "aadressid")]
			public Aadressid Aadressid { get; set; }
			[XmlElement(ElementName = "adsOid")]
			public string AdsOid { get; set; }
			[XmlElement(ElementName = "liik")]
			public string Liik { get; set; }
			[XmlElement(ElementName = "origTunnus")]
			public string OrigTunnus { get; set; }
			[XmlElement(ElementName = "taisAadress")]
			public string TaisAadress { get; set; }
			[XmlElement(ElementName = "tsentroidX")]
			public string TsentroidX { get; set; }
			[XmlElement(ElementName = "tsentroidY")]
			public string TsentroidY { get; set; }
		}

		[XmlRoot(ElementName = "objektid")]
		public class Objektid
		{
			[XmlElement(ElementName = "objekt")]
			public List<Objekt> Objekt { get; set; }
		}

		[XmlRoot(ElementName = "tulem")]
		public class Tulem
		{
			[XmlElement(ElementName = "objektid")]
			public Objektid Objektid { get; set; }
		}
	}
}
