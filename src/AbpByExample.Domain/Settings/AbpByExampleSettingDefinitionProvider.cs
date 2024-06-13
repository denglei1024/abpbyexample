using Volo.Abp.Settings;

namespace AbpByExample.Settings;

public class AbpByExampleSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpByExampleSettings.MySetting1));
    }
}
