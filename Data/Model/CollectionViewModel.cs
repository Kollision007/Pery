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
        private int id;
        private List<Guid> categoryIds;
        private string productName;
        private int collectionid;
        private string description;
        private string imageSrc;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int CollectionId
        {
            get { return collectionid; }
            set { collectionid = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string ImagesSrc
        {
            get
            {
                return imageSrc;
            }
            set
            {
                imageSrc = value;
            }
        }

        public List<Guid> CategoryIds
        {
            get { return categoryIds; }
            set { categoryIds = value; }
        }
    }

    public class Category
    {
        private Guid id;
        private string imageSrc;
        private string productName;
        private string description;
        private bool active;

        public bool Active
        {
            get
            { return active; }
            set
            {
                active = value;
            }
        }

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string ImagesSrc
        {
            get
            {
                return imageSrc;
            }
            set
            {
                imageSrc = value;
            }
        }
    }
}
