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
                    Product = new List<Product>()
                    {
                        new Product()
                        {
                            Id = 1,
                            CollectionId=1,
                            ProductName =$"products-{1}",
                            Description = "",
                            ImagesSrc="https://images.unsplash.com/photo-1588392382834-a891154bca4d?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1055&q=80"
                        }
                    }
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
                        Description = "",
                        ImagesSrc = "https://images.unsplash.com/photo-1441974231531-c6227db76b6e?ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60",
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
                        Description = "",
                        ImagesSrc = "https://images.unsplash.com/photo-1470071459604-3b5ec3a7fe05?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDJ8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                    } }
                },
                new CollectionViewModel()
                {
                    Id=4,
                    CollectionTitel = "collection-unique-title",
                    CollectionDescription ="collection-gold-description",
                    Product = new List<Product>(){ new Product()
                    {
                        Id = 4,
                        CollectionId=4,
                        ProductName =$"products-{3}",
                        Description = "",
                        ImagesSrc = "https://images.unsplash.com/reserve/HgZuGu3gSD6db21T3lxm_San%20Zenone.jpg?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80",
                    } }
                },
                new CollectionViewModel()
                {
                    Id=4,
                    CollectionTitel = "collection-unique-title",
                    CollectionDescription ="collection-gold-description",
                    Product = new List<Product>(){ new Product()
                    {
                        Id = 4,
                        CollectionId=4,
                        ProductName =$"products-{3}",
                        Description = "",
                        ImagesSrc = "https://images.unsplash.com/photo-1426604966848-d7adac402bff?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDN8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
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


