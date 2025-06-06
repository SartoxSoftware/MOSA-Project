namespace System.Reflection.Metadata;

public enum SerializationTypeCode : byte
{
	Invalid = 0,
	Boolean = 2,
	Char = 3,
	SByte = 4,
	Byte = 5,
	Int16 = 6,
	UInt16 = 7,
	Int32 = 8,
	UInt32 = 9,
	Int64 = 10,
	UInt64 = 11,
	Single = 12,
	Double = 13,
	String = 14,
	SZArray = 29,
	Type = 80,
	TaggedObject = 81,
	Enum = 85
}
