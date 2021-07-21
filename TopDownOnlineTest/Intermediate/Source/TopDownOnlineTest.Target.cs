using UnrealBuildTool;

public class TopDownOnlineTestTarget : TargetRules
{
	public TopDownOnlineTestTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TopDownOnlineTest");
	}
}
