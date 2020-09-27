using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ChangeCalculator
{
    class Denomination
    {
        private String name;
        private String namePlural;
        private int amount;
        private int count;

        public Denomination(String name, String namePlural, int amount)
        {
            this.name = name;
            this.namePlural = namePlural;
            this.amount = amount;
            this.count = 0;
        }

        public int updateCountReturnRemainder(int change)
        {
            count = change / amount;
            int remainder = change % amount;
            return remainder;
        }

    }
}
