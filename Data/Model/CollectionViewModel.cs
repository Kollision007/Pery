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
}
