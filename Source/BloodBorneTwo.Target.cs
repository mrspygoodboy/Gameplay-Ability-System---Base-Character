// Copyright Muhammad Aliyan

using UnrealBuildTool;
using System.Collections.Generic;

public class BloodBorneTwoTarget : TargetRules
{
	public BloodBorneTwoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "BloodBorneTwo" } );
	}
}
