// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Kernel.BareMetal;

namespace Mosa.BareMetal.CoolWorld.x86;

public static class Boot
{
	public static void Main()
	{
		Debug.WriteLine("Boot::Main()");
		Debug.WriteLine("MOSA x86 Kernel");

		Program.EntryPoint();
	}

	public static void ForceInclude()
	{
		Mosa.Kernel.BareMetal.x86.PlatformPlug.ForceInclude();
	}
}
