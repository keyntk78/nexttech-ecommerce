using NextTech.Ecommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NextTech.Ecommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EcommerceController : AbpControllerBase
{
    protected EcommerceController()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}
