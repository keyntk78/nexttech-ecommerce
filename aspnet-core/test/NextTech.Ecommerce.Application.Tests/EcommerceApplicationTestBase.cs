using Volo.Abp.Modularity;

namespace NextTech.Ecommerce;

public abstract class EcommerceApplicationTestBase<TStartupModule> : EcommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
