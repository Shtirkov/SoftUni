using _03.Shopping_Spree.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Shopping_Spree
{
    public class Person
    {
        private const string SuccessfullyBoughtProductMsg = "{0} bought {1}";
        private const string CanNotAffordProductMsg = "{0} can't afford {1}";

        private string name;
        private decimal money;
        private readonly ICollection<Product> bag;

        private Person()
        {
            this.bag = new List<Product>();
        }

        public Person(string name, decimal money)
            : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMsg);
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMoneyExceptionMsg);
                }
                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag
        {
            get
            {
                return (IReadOnlyCollection<Product>)this.bag;
            }
        }

        public string BuyProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.bag.Add(product);
                return string.Format(SuccessfullyBoughtProductMsg, this.name, product.Name);
            }
            return string.Format(CanNotAffordProductMsg, this.name, product.Name);
        }

        public override string ToString()
        {
            string productOutput = this.bag.Count > 0 ? string.Join(", ", this.Bag) : "Nothing bought";

            return $"{this.name} - {productOutput}";
        }
    }
}
