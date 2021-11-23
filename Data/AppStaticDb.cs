using Pery.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace Pery.Data
{
    public class AppStaticDb
    {
        private static List<CollectionViewModel> collectionList;

        public AppStaticDb()
        {
            if (collectionList == null)
            {
                collectionList = GetCollections();
            }
        }

        public static List<CollectionViewModel> CollectionViewModel { get { return collectionList; } set { collectionList = value; } }

        private List<CollectionViewModel> GetCollections()
        {
            return new List<CollectionViewModel>()
            {
                new CollectionViewModel()
                {
                    Id=1,
                    CollectionTitel = "collection-gold-title",
                    CollectionDescription ="collection-gold-description",
                     Product = new List<Product>(){ new Product()
                    {
                        Id = 1,
                        CollectionId=1,
                        ProductName =$"products-{1}",
                        Description = ""
                    } }
                },
                new CollectionViewModel()
                {
                    Id=2,
                    CollectionTitel = "collection-silver-title",
                    CollectionDescription ="collection-gold-description",
                    Product = new List<Product>(){ new Product()
                    {
                        Id = 2,
                        CollectionId=2,
                        ProductName =$"products-{2}",
                        Description = ""
                    } }
                },
                new CollectionViewModel()
                {
                    Id=3,
                    CollectionTitel = "collection-unique-title",
                    CollectionDescription ="collection-gold-description",
                    Product = new List<Product>(){ new Product()
                    {
                        Id = 3,
                        CollectionId=3,
                        ProductName =$"products-{3}",
                        Description = ""
                    } }
                }
            };
        }

        public static void AddCollection(CollectionViewModel collectionViewMode)
        {
            collectionList.Add(collectionViewMode);
        }

        public static void RemoveCollection(CollectionViewModel collectionViewMode)
        {
            collectionList.Remove(collectionViewMode);
        }

        public static void UpdateCollection(CollectionViewModel collectionViewMode)
        {
            collectionList.Remove(collectionViewMode);
        }


        public static List<Product> GetProductsByCollectionID(int collectionId)
        {
            return collectionList.Where(s => s.Id == collectionId).SelectMany(x => x.Product).ToList<Product>(); ;
        }

        public static void AddProduct(CollectionViewModel collectionViewMode)
        {
            collectionList.Add(collectionViewMode);
        }

        public static void RemoveProduct(CollectionViewModel collectionViewMode)
        {
            collectionList.Remove(collectionViewMode);
        }

        public static void UpdateProduct(CollectionViewModel collectionViewMode)
        {
            CollectionViewModel selected = collectionList.FirstOrDefault<CollectionViewModel>(s => s.Id == collectionViewMode.Id);

        }

    }
}


