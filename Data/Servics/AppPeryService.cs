using Pery.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pery.Data.Servics
{
    public class AppPeryService
    {
        public Task<CollectionViewModel[]> GetCollectionsAsync()
        {
            return Task.FromResult(CollectionViewModel.GetCollections());
        }


    }
}
