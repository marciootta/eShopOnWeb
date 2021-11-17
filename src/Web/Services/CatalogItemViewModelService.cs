using Microsoft.eShopWeb.ApplicationCore.Entities;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using Microsoft.eShopWeb.ApplicationCore.Specifications;
using Microsoft.eShopWeb.Web.Pages.Admin;
using Microsoft.eShopWeb.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Web.Services
{
    public class CatalogItemViewModelService 
    {
        private readonly IAsyncRepository<CatalogItem> _catalogItemRepository;

        public CatalogItemViewModelService(IAsyncRepository<CatalogItem> catalogItemRepository)
        {
            _catalogItemRepository = catalogItemRepository;
        }

        public async Task UpdateCatalogItem(CatalogItemViewModel viewModel)
        {
            var existingCatalogItem = await _catalogItemRepository.GetByIdAsync(viewModel.Id);
            existingCatalogItem.UpdateDetails(viewModel.Name, existingCatalogItem.Description, viewModel.Price);
            await _catalogItemRepository.UpdateAsync(existingCatalogItem);
        }

        public async Task<IEnumerable<CatalogAdminViewModel>> GetAllCatalogItems()
        {
            var catSpec = new CatalogWithBrandTypeSpecification(null, null);
            var listaCatalog = await _catalogItemRepository.ListAsync(catSpec);

            var listaCatalogAdminViewModel =
                listaCatalog.Select(c => new CatalogAdminViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Price = c.Price,
                    CatalogBrand = c.CatalogBrand.Brand,
                    CatalogType = c.CatalogType.Type,
                    PictureUri = c.PictureUri
                });
            return listaCatalogAdminViewModel;
        }

        public async Task<CatalogItemViewModel> GetCatalogItemViewModelById(int catalogId)
        {
            var item = await _catalogItemRepository.GetByIdAsync(catalogId);    
            return new CatalogItemViewModel
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                PictureUri = item.PictureUri
            };
        }
    }
}
