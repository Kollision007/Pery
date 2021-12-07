using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pery.Data.Model
{
    public class Product
    {
        private int id;
        private List<Guid> categoryIds;
        private string name;
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

        public string Name
        {
            get { return name; }
            set { name = value; }
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
}
