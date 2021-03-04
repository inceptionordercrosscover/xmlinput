using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebApplication1
{
    public class SoapClass
    {
    }
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (Envelope)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "Password")]
	public class Password
	{

		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }

		[XmlText]
		public int Text { get; set; }
	}

	[XmlRoot(ElementName = "Nonce")]
	public class Nonce
	{

		[XmlAttribute(AttributeName = "EncodingType")]
		public string EncodingType { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "UsernameToken")]
	public class UsernameToken
	{

		[XmlElement(ElementName = "Username")]
		public string Username { get; set; }

		[XmlElement(ElementName = "Password")]
		public Password Password { get; set; }

		[XmlElement(ElementName = "Nonce")]
		public Nonce Nonce { get; set; }

		[XmlElement(ElementName = "Created")]
		public DateTime Created { get; set; }

		[XmlAttribute(AttributeName = "wsu")]
		public string Wsu { get; set; }

		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Security")]
	public class Security
	{

		[XmlElement(ElementName = "UsernameToken")]
		public UsernameToken UsernameToken { get; set; }

		[XmlAttribute(AttributeName = "wsse")]
		public string Wsse { get; set; }

		[XmlAttribute(AttributeName = "mustUnderstand")]
		public int MustUnderstand { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Header")]
	public class Header
	{

		[XmlElement(ElementName = "Security")]
		public Security Security { get; set; }
	}

	[XmlRoot(ElementName = "TransType")]
	public class TransType
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "TransMode")]
	public class TransMode
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "NoResponseOK")]
	public class NoResponseOK
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public bool Text { get; set; }
	}

	[XmlRoot(ElementName = "SourceInfo")]
	public class SourceInfo
	{

		[XmlElement(ElementName = "SourceInfoName")]
		public string SourceInfoName { get; set; }
	}

	[XmlRoot(ElementName = "HoldingTypeCode")]
	public class HoldingTypeCode
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "PolicyStatus")]
	public class PolicyStatus
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "ApplicationInfo")]
	public class ApplicationInfo
	{

		[XmlElement(ElementName = "TrackingID")]
		public string TrackingID { get; set; }
	}

	[XmlRoot(ElementName = "ReqCode")]
	public class ReqCode
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "ReqStatus")]
	public class ReqStatus
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "AttachmentType")]
	public class AttachmentType
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "MimeTypeTC")]
	public class MimeTypeTC
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "ImageType")]
	public class ImageType
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "AttachmentLocation")]
	public class AttachmentLocation
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Attachment")]
	public class Attachment
	{

		[XmlElement(ElementName = "AttachmentType")]
		public AttachmentType AttachmentType { get; set; }

		[XmlElement(ElementName = "MimeTypeTC")]
		public MimeTypeTC MimeTypeTC { get; set; }

		[XmlElement(ElementName = "ImageType")]
		public ImageType ImageType { get; set; }

		[XmlElement(ElementName = "AttachmentLocation")]
		public AttachmentLocation AttachmentLocation { get; set; }

		[XmlElement(ElementName = "ArchiveRefNumber")]
		public string ArchiveRefNumber { get; set; }
	}

	[XmlRoot(ElementName = "RequirementInfo")]
	public class RequirementInfo
	{

		[XmlElement(ElementName = "ReqCode")]
		public ReqCode ReqCode { get; set; }

		[XmlElement(ElementName = "RequirementInfoUniqueID")]
		public string RequirementInfoUniqueID { get; set; }

		[XmlElement(ElementName = "ReqStatus")]
		public ReqStatus ReqStatus { get; set; }

		[XmlElement(ElementName = "FulfilledDate")]
		public DateTime FulfilledDate { get; set; }

		[XmlElement(ElementName = "StatusDate")]
		public DateTime StatusDate { get; set; }

		[XmlElement(ElementName = "Attachment")]
		public Attachment Attachment { get; set; }

		[XmlAttribute(AttributeName = "AppliesToPartyID")]
		public string AppliesToPartyID { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Policy")]
	public class Policy
	{

		[XmlElement(ElementName = "PolicyStatus")]
		public PolicyStatus PolicyStatus { get; set; }

		[XmlElement(ElementName = "ApplicationInfo")]
		public ApplicationInfo ApplicationInfo { get; set; }

		[XmlElement(ElementName = "RequirementInfo")]
		public RequirementInfo RequirementInfo { get; set; }
	}

	[XmlRoot(ElementName = "Holding")]
	public class Holding
	{

		[XmlElement(ElementName = "HoldingTypeCode")]
		public HoldingTypeCode HoldingTypeCode { get; set; }

		[XmlElement(ElementName = "Policy")]
		public Policy Policy { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "PartyTypeCode")]
	public class PartyTypeCode
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "GovtIDTC")]
	public class GovtIDTC
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Gender")]
	public class Gender
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "DriversLicenseState")]
	public class DriversLicenseState
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Person")]
	public class Person
	{

		[XmlElement(ElementName = "FirstName")]
		public string FirstName { get; set; }

		[XmlElement(ElementName = "MiddleName")]
		public string MiddleName { get; set; }

		[XmlElement(ElementName = "LastName")]
		public string LastName { get; set; }

		[XmlElement(ElementName = "Gender")]
		public Gender Gender { get; set; }

		[XmlElement(ElementName = "BirthDate")]
		public DateTime BirthDate { get; set; }

		[XmlElement(ElementName = "DriversLicenseNum")]
		public string DriversLicenseNum { get; set; }

		[XmlElement(ElementName = "DriversLicenseState")]
		public DriversLicenseState DriversLicenseState { get; set; }
	}

	[XmlRoot(ElementName = "Party")]
	public class Party
	{

		[XmlElement(ElementName = "PartyTypeCode")]
		public PartyTypeCode PartyTypeCode { get; set; }

		[XmlElement(ElementName = "GovtID")]
		public int GovtID { get; set; }

		[XmlElement(ElementName = "GovtIDTC")]
		public GovtIDTC GovtIDTC { get; set; }

		[XmlElement(ElementName = "Person")]
		public Person Person { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "OriginatingObjectType")]
	public class OriginatingObjectType
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "RelatedObjectType")]
	public class RelatedObjectType
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "RelationRoleCode")]
	public class RelationRoleCode
	{

		[XmlAttribute(AttributeName = "tc")]
		public int Tc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Relation")]
	public class Relation
	{

		[XmlElement(ElementName = "OriginatingObjectType")]
		public OriginatingObjectType OriginatingObjectType { get; set; }

		[XmlElement(ElementName = "RelatedObjectType")]
		public RelatedObjectType RelatedObjectType { get; set; }

		[XmlElement(ElementName = "RelationRoleCode")]
		public RelationRoleCode RelationRoleCode { get; set; }

		[XmlAttribute(AttributeName = "OriginatingObjectID")]
		public string OriginatingObjectID { get; set; }

		[XmlAttribute(AttributeName = "RelatedObjectID")]
		public string RelatedObjectID { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "OLifE")]
	public class OLifE
	{

		[XmlElement(ElementName = "SourceInfo")]
		public SourceInfo SourceInfo { get; set; }

		[XmlElement(ElementName = "Holding")]
		public Holding Holding { get; set; }

		[XmlElement(ElementName = "Party")]
		public Party Party { get; set; }

		[XmlElement(ElementName = "Relation")]
		public Relation Relation { get; set; }
	}

	[XmlRoot(ElementName = "TXLifeRequest")]
	public class TXLifeRequest
	{

		[XmlElement(ElementName = "TransRefGUID")]
		public string TransRefGUID { get; set; }

		[XmlElement(ElementName = "TransType")]
		public TransType TransType { get; set; }

		[XmlElement(ElementName = "TransExeDate")]
		public DateTime TransExeDate { get; set; }

		[XmlElement(ElementName = "TransExeTime")]
		public DateTime TransExeTime { get; set; }

		[XmlElement(ElementName = "TransMode")]
		public TransMode TransMode { get; set; }

		[XmlElement(ElementName = "NoResponseOK")]
		public NoResponseOK NoResponseOK { get; set; }

		[XmlElement(ElementName = "OLifE")]
		public OLifE OLifE { get; set; }

		[XmlAttribute(AttributeName = "PrimaryObjectID")]
		public string PrimaryObjectID { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "TXLife")]
	public class TXLife
	{

		[XmlElement(ElementName = "TXLifeRequest")]
		public TXLifeRequest TXLifeRequest { get; set; }

		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }

		[XmlAttribute(AttributeName = "soapenv")]
		public string Soapenv { get; set; }

		[XmlAttribute(AttributeName = "xsd")]
		public string Xsd { get; set; }

		[XmlAttribute(AttributeName = "xsi")]
		public string Xsi { get; set; }

		[XmlAttribute(AttributeName = "schemaLocation")]
		public string SchemaLocation { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "UWReqIxOrderResult")]
	public class UWReqIxOrderResult
	{

		[XmlElement(ElementName = "TXLife")]
		public TXLife TXLife { get; set; }
	}

	[XmlRoot(ElementName = "Body")]
	public class Body
	{

		[XmlElement(ElementName = "UWReqIxOrderResult")]
		public UWReqIxOrderResult UWReqIxOrderResult { get; set; }
	}

	[XmlRoot(ElementName = "Envelope")]
	public class Envelope
	{

		[XmlElement(ElementName = "Header")]
		public Header Header { get; set; }

		[XmlElement(ElementName = "Body")]
		public Body Body { get; set; }

		[XmlAttribute(AttributeName = "all")]
		public string All { get; set; }

		[XmlAttribute(AttributeName = "prod")]
		public string Prod { get; set; }

		[XmlAttribute(AttributeName = "soapenv")]
		public string Soapenv { get; set; }

		[XmlText]
		public string Text { get; set; }
	}


}
