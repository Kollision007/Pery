using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pery.Data.Model
{

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
