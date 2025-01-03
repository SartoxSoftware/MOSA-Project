using System.Collections;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data.OleDb;

[Editor("Microsoft.VSDesigner.Data.Design.DBParametersEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public sealed class OleDbParameterCollection : DbParameterCollection
{
	public override int Count
	{
		get
		{
			throw null;
		}
	}

	public override bool IsFixedSize
	{
		get
		{
			throw null;
		}
	}

	public override bool IsReadOnly
	{
		get
		{
			throw null;
		}
	}

	public override bool IsSynchronized
	{
		get
		{
			throw null;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new OleDbParameter this[int index]
	{
		get
		{
			throw null;
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new OleDbParameter this[string parameterName]
	{
		get
		{
			throw null;
		}
		set
		{
		}
	}

	public override object SyncRoot
	{
		get
		{
			throw null;
		}
	}

	internal OleDbParameterCollection()
	{
	}

	public OleDbParameter Add(OleDbParameter value)
	{
		throw null;
	}

	public override int Add(object value)
	{
		throw null;
	}

	public OleDbParameter Add(string? parameterName, OleDbType oleDbType)
	{
		throw null;
	}

	public OleDbParameter Add(string? parameterName, OleDbType oleDbType, int size)
	{
		throw null;
	}

	public OleDbParameter Add(string? parameterName, OleDbType oleDbType, int size, string? sourceColumn)
	{
		throw null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Add(String parameterName, Object value) has been deprecated. Use AddWithValue(String parameterName, Object value) instead.")]
	public OleDbParameter Add(string? parameterName, object? value)
	{
		throw null;
	}

	public override void AddRange(Array values)
	{
	}

	public void AddRange(OleDbParameter[] values)
	{
	}

	public OleDbParameter AddWithValue(string? parameterName, object? value)
	{
		throw null;
	}

	public override void Clear()
	{
	}

	public bool Contains(OleDbParameter value)
	{
		throw null;
	}

	public override bool Contains(object value)
	{
		throw null;
	}

	public override bool Contains(string value)
	{
		throw null;
	}

	public override void CopyTo(Array array, int index)
	{
	}

	public void CopyTo(OleDbParameter[] array, int index)
	{
	}

	public override IEnumerator GetEnumerator()
	{
		throw null;
	}

	protected override DbParameter GetParameter(int index)
	{
		throw null;
	}

	protected override DbParameter GetParameter(string parameterName)
	{
		throw null;
	}

	public int IndexOf(OleDbParameter value)
	{
		throw null;
	}

	public override int IndexOf(object value)
	{
		throw null;
	}

	public override int IndexOf(string parameterName)
	{
		throw null;
	}

	public void Insert(int index, OleDbParameter value)
	{
	}

	public override void Insert(int index, object value)
	{
	}

	public void Remove(OleDbParameter value)
	{
	}

	public override void Remove(object value)
	{
	}

	public override void RemoveAt(int index)
	{
	}

	public override void RemoveAt(string parameterName)
	{
	}

	protected override void SetParameter(int index, DbParameter value)
	{
	}

	protected override void SetParameter(string parameterName, DbParameter value)
	{
	}
}
