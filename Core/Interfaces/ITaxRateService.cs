using API.Entities;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ITaxRateService
    {
        Task<SalesTaxRate> GetTaxRate(string city, string state);
    }
}
