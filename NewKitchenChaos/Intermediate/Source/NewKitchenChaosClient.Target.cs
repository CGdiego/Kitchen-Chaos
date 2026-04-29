using UnrealBuildTool;

public class NewKitchenChaosClientTarget : TargetRules
{
	public NewKitchenChaosClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("NewKitchenChaos");
	}
}
