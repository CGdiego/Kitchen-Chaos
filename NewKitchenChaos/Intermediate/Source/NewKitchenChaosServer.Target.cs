using UnrealBuildTool;

public class NewKitchenChaosServerTarget : TargetRules
{
	public NewKitchenChaosServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("NewKitchenChaos");
	}
}
