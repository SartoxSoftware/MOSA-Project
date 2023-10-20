﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Utility.SourceCodeGenerator;

public class BuildARM32Instructions : BuildBaseTemplate
{
	public BuildARM32Instructions(string jsonFile, string destinationPath, string destinationFile)
		: base(jsonFile, destinationPath, destinationFile)
	{
	}

	protected override void Body()
	{
		Lines.AppendLine("using System.Collections.Generic;");
		Lines.AppendLine("using Mosa.Compiler.Framework;");
		Lines.AppendLine();
		Lines.AppendLine("namespace Mosa.Compiler.ARM32;");
		Lines.AppendLine();
		Lines.AppendLine("/// <summary>");
		Lines.AppendLine("/// ARM32 Instruction Map");
		Lines.AppendLine("/// </summary>");
		Lines.AppendLine("public static class ARM32Instructions");
		Lines.AppendLine("{");
		Lines.AppendLine("\tpublic static readonly List<BaseInstruction> List = new List<BaseInstruction> {");

		foreach (var entry in Entries.Instructions)
		{
			Lines.AppendLine("\t\tARM32." + entry.Name + ",");
		}

		Lines.AppendLine("\t};");
		Lines.AppendLine("}");
	}
}