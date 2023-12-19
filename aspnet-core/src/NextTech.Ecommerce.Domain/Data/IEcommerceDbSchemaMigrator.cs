using System.Threading.Tasks;

namespace NextTech.Ecommerce.Data;

public interface IEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
