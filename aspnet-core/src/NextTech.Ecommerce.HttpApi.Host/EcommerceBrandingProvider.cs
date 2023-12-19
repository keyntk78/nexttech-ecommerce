using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NextTech.Ecommerce;

[Dependency(ReplaceServices = true)]
public class EcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Ecommerce";
}
