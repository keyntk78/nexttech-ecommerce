using Volo.Abp.Modularity;

namespace NextTech.Ecommerce;

[DependsOn(
    typeof(EcommerceApplicationModule),
    typeof(EcommerceDomainTestModule)
)]
public class EcommerceApplicationTestModule : AbpModule
{

}
