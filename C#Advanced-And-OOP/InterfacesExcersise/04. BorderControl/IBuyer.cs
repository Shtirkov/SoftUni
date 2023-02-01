using System;
using System.Collections.Generic;
using System.Text;

namespace _04._BorderControl
{
   public interface IBuyer
    {
        public int Food { get; set; }

        public int BuyFood();
    }
}
