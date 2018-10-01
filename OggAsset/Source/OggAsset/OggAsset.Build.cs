
namespace UnrealBuildTool.Rules
{
	public class OggAsset : ModuleRules
	{
		public OggAsset(ReadOnlyTargetRules Target) : base(Target)
		{
            PublicDependencyModuleNames.AddRange(
                new string[] {
                    "Engine",
					"Core",
					"CoreUObject",
                }
            );

			PrivateIncludePaths.AddRange(
				new string[] {
					"Runtime/OggAsset/Private",
				}
			);
		}
	}
}
