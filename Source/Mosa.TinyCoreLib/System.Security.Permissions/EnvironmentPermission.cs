namespace System.Security.Permissions;

[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
public sealed class EnvironmentPermission : CodeAccessPermission, IUnrestrictedPermission
{
	public EnvironmentPermission(EnvironmentPermissionAccess flag, string pathList)
	{
	}

	public EnvironmentPermission(PermissionState state)
	{
	}

	public void AddPathList(EnvironmentPermissionAccess flag, string pathList)
	{
	}

	public override IPermission Copy()
	{
		throw null;
	}

	public override void FromXml(SecurityElement esd)
	{
	}

	public string GetPathList(EnvironmentPermissionAccess flag)
	{
		throw null;
	}

	public override IPermission Intersect(IPermission target)
	{
		throw null;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		throw null;
	}

	public bool IsUnrestricted()
	{
		throw null;
	}

	public void SetPathList(EnvironmentPermissionAccess flag, string pathList)
	{
	}

	public override SecurityElement ToXml()
	{
		throw null;
	}

	public override IPermission Union(IPermission other)
	{
		throw null;
	}
}
