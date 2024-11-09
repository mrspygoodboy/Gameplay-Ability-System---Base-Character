// Copyright Muhammad Aliyan

using UnrealBuildTool;
using System.Collections.Generic;

public class BloodBorneTwoEditorTarget : TargetRules
{
	public BloodBorneTwoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "BloodBorneTwo" } );
	}
}
