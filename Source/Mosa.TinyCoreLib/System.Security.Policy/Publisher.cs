using System.Security.Cryptography.X509Certificates;

namespace System.Security.Policy;

[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
public sealed class Publisher : EvidenceBase, IIdentityPermissionFactory
{
	public X509Certificate Certificate
	{
		get
		{
			throw null;
		}
	}

	public Publisher(X509Certificate cert)
	{
	}

	public object Copy()
	{
		throw null;
	}

	public IPermission CreateIdentityPermission(Evidence evidence)
	{
		throw null;
	}

	public override bool Equals(object o)
	{
		throw null;
	}

	public override int GetHashCode()
	{
		throw null;
	}

	public override string ToString()
	{
		throw null;
	}
}
