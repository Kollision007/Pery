using System;
using System.Collections.Generic;

namespace Pery.Data.Model
{
    public class CollectionViewModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string collectionTitle;

        public string CollectionTitel
        {
            get { return collectionTitle; }
            set { collectionTitle = value; }
        }


        private string collectionDescription;

        public string CollectionDescription
        {
            get { return collectionDescription; }
            set { collectionDescription = value; }
        }

        public string Url
        {
            get
            {
                return "products/" + this.Id;
            }
        }

        private List<Product> products;

        public List<Product> Product
        {
            get { return products; }
            set { products = value; }
        }

    }

    public class Product 
    {
        private  int id;

        public  int Id
        {
            get { return id; }
            set {id = value; }
        }

        private int collectionid;

        public int CollectionId
        {
            get { return collectionid; }
            set { collectionid = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
