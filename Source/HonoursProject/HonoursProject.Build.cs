// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HonoursProject : ModuleRules
{
	public HonoursProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"HonoursProject",
			"HonoursProject/Variant_Platforming",
			"HonoursProject/Variant_Platforming/Animation",
			"HonoursProject/Variant_Combat",
			"HonoursProject/Variant_Combat/AI",
			"HonoursProject/Variant_Combat/Animation",
			"HonoursProject/Variant_Combat/Gameplay",
			"HonoursProject/Variant_Combat/Interfaces",
			"HonoursProject/Variant_Combat/UI",
			"HonoursProject/Variant_SideScrolling",
			"HonoursProject/Variant_SideScrolling/AI",
			"HonoursProject/Variant_SideScrolling/Gameplay",
			"HonoursProject/Variant_SideScrolling/Interfaces",
			"HonoursProject/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
