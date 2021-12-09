using System;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name
        {
            get { return productName; }
            set { productName = value; }
        }
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
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
