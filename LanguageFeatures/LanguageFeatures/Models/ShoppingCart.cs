using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace LanguageFeatures.Models
{
    public class ShoppingCart:IEnumerable<Product>
    {
        public List<Product> Products { get; set; }
        public IEnumerator<Product> GetEnumrator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator<Product> IEnumerable<Product>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}