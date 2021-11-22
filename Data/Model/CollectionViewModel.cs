using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pery.Data.Model
{
    public class CollectionViewModel
    {
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



        public static CollectionViewModel[] GetCollections()
        {

            var list = new List<CollectionViewModel>()
            {
                new CollectionViewModel()
                    {
                    CollectionTitel = "collection-gold-title",
                    CollectionDescription ="collection-gold-description"
                },
                new CollectionViewModel()
                {
                    CollectionTitel = "collection-silver-title",
                    CollectionDescription ="collection-gold-description"
                },
                new CollectionViewModel()
                {
                    CollectionTitel = "collection-unique-title",
                    CollectionDescription ="collection-gold-description"}
            };

            return list.ToArray();


        }
    }

}
