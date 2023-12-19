using NextTech.Ecommerce.Samples;
using Xunit;

namespace NextTech.Ecommerce.EntityFrameworkCore.Domains;

[Collection(EcommerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<EcommerceEntityFrameworkCoreTestModule>
{

}
