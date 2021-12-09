using Microsoft.AspNetCore.Mvc;
using Pery.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pery.Data.Servics
{
    public class AppPeryService
    {
        public Task<List<CollectionViewModel>> GetCollectionsAsync()
        {
            return Task.FromResult(AppStaticDb.CollectionViewModel);
        }

        public void AddCollectionsAsync(CollectionViewModel collectionViewModel)
        {
            AppStaticDb.AddCollection(collectionViewModel);
        }

        public Task<List<Product>> GetProductAsync(int collectionID)
        {
            return Task.FromResult(AppStaticDb.GetProductsByCollectionID(collectionID));
        }

        #region Category

        public Task<List<Category>> GetCategorys()
        {
            return Task.FromResult(AppStaticDb.ReadCategory());
        }

        public Task<bool> AddCategory(Category cat) 
        {
            return Task.FromResult(AppStaticDb.AddCategory(cat));
        }

        public Task<bool> RemoveCategorys(Category cat)
        {
            return Task.FromResult(AppStaticDb.RemoveCategory(cat));
        }

        public Task<bool> UpdateCategorys(Category cat)
        {
            return Task.FromResult(AppStaticDb.UpdateOrCreateCategroy(cat));
        }

        #endregion

        #region Products

        public Task<List<Product>> GetProducts()
        {
            return Task.FromResult(AppStaticDb.ReadProducts());
        }

        public Task<List<Product>> GetProducts(int categoryIds)
        {
            List<Product> products = AppStaticDb.ReadProducts();
            return Task.FromResult(AppStaticDb.GetProductsByCollectionID(categoryIds));
        }

        public Task<List<Product>> GetProducts(Guid categoryIds)
        {
            List<Product> products = AppStaticDb.ReadProducts();
            return Task.FromResult(products.Where(x => x.CategoryIds.Contains(categoryIds)).ToList());
        }

        public Task<bool> RemoveProduct(Product pro)
        {
            return Task.FromResult(AppStaticDb.RemoveProduct(pro));
        }

        public Task<bool> UpdateProduct(Product pro)
        {
            return Task.FromResult(AppStaticDb.UpdateProduct(pro));
        }

        #endregion
    }
}
