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
        AppStaticDb appStaticDb = new AppStaticDb();

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
    }
}
