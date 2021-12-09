using Pery.Data.Model;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Pery.Data
{
    public class AppStaticDb
    {
        private static List<CollectionViewModel> collectionList = GetCollections();

        public static List<CollectionViewModel> CollectionViewModel { get { return collectionList; } set { collectionList = value; } }

        private static List<CollectionViewModel> GetCollections()
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
                            Name =$"products-{1}",
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
                        Name =$"products-{2}",
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
                        Name =$"products-{3}",
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
                        Name =$"products-{3}",
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
                        Name =$"products-{3}",
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

        public static List<Product> GetProductsByCollectionID(int collectionId)
        {
            return collectionList.Where(s => s.Id == collectionId).SelectMany(x => x.Product).ToList<Product>(); ;
        }

        #region Products

        private static string _fileProductsPath = $"{Directory.GetCurrentDirectory()}\\PeryProducts.json";

        private static void InitProducts()
        {
            if (!File.Exists(_fileProductsPath))
            {
                File.Create(_fileProductsPath);
            }
        }

        public static bool AddProduct(Product pro)
        {
            try
            {
                InitProducts();
                List<Product> products = ReadProducts();

                if (products.Count(x => x.Id == pro.Id) == 0)
                {
                    products.Add(pro);
                }
                WriteProducts(products);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static bool RemoveProduct(Product pro)
        {
            try
            {
                List<Product> products = ReadProducts();
                products.Remove(pro);
                WriteProducts(products);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static bool UpdateProduct(Product pro)
        {
            try
            {
                List<Product> products = ReadProducts();

                Product updatePro = products.FirstOrDefault<Product>(s => s.Id == pro.Id);

                if (updatePro != null)
                {
                    updatePro.CategoryIds = pro.CategoryIds;
                    updatePro.ImagesSrc = pro.ImagesSrc;
                    updatePro.Description = pro.Description;
                    updatePro.Name = pro.Name;
                }
                WriteProducts(products);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static List<Product> ReadProducts()
        {
            InitProducts();
            return JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(_fileProductsPath));
        }

        private static void WriteProducts(List<Product> yProducts)
        {
            InitProducts();
            File.WriteAllText(_fileProductsPath, JsonConvert.SerializeObject(yProducts));
        }

        #endregion

        #region Category

        private static string _fileCategoryPath = $"{Directory.GetCurrentDirectory()}\\PeryCategorys.json";

        private static void InitCategory()
        {
            if (!File.Exists(_fileCategoryPath))
            {
                File.Create(_fileCategoryPath);
            }
        }

        public static bool AddCategory(Category cat)
        {
            try
            {
                List<Category> products = ReadCategory();

                if (products.Count(x => x.Id == cat.Id) == 0)
                {
                    products.Add(cat);
                }
                WriteCategory(products);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static bool RemoveCategory(Category pro)
        {
            try
            {
                List<Category> categorys = ReadCategory();
                categorys.Remove(pro);
                WriteCategory(categorys);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static bool UpdateOrCreateCategroy(Category cat)
        {
            try
            {
                List<Category> category = ReadCategory();

                Category updatePro = category.FirstOrDefault<Category>(s => s.Id == cat.Id);

                if (updatePro != null)
                {
                    updatePro.ImagesSrc = cat.ImagesSrc;
                    updatePro.Description = cat.Description;
                    updatePro.Name = cat.Name;
                    WriteCategory(category);
                }
                else 
                {
                    AddCategory(cat);
                }
                
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static List<Category> ReadCategory()
        {
            InitCategory();

            List<Category> init = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText(_fileCategoryPath));

            if (init == null)
            {
                init = new List<Category>();
            }
            return init;
        }

        private static void WriteCategory(List<Category> yCategory)
        {
            InitCategory();
            File.WriteAllText(_fileCategoryPath, JsonConvert.SerializeObject(yCategory));
        }

        #endregion
    }
}


