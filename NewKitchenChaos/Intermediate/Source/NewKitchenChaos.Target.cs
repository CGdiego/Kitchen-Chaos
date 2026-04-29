using UnrealBuildTool;

public class NewKitchenChaosTarget : TargetRules
{
	public NewKitchenChaosTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("NewKitchenChaos");
	}
}
