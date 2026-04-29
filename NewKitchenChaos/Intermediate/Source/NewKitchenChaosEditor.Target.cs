using UnrealBuildTool;

public class NewKitchenChaosEditorTarget : TargetRules
{
	public NewKitchenChaosEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("NewKitchenChaos");
	}
}
