namespace System.DirectoryServices.Protocols;

public delegate void DereferenceConnectionCallback(LdapConnection primaryConnection, LdapConnection connectionToDereference);
