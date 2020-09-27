using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ChangeCalculatorConsole
{
    class Denomination
    {
        //Klass som fungerar som mall för valörerna med information om valörens namn i singular och plural
        //belopp och en räknare för valören
        private string name;
        private string namePlural;
        private int amount;
        private int count;

        //konstruktorn. Count sätts till noll vid uppskapande av en instans
        public Denomination(string name, string namePlural, int amount)
        {
            this.name = name;
            this.namePlural = namePlural;
            this.amount = amount;
            this.count = 0;
        }

        //gör amount tillgängligt utanför klassen
        public int Amount
        {
            get
            {
                return amount;
            }
        }

        //metod som returnerar namnet på valören samt räknaren för valören
        public string GetCountAndName()
        {
            string returnstring;
            if (count > 1)
            {
                returnstring = count + " " + namePlural;
            }
            else
            {
                returnstring = count + " " + name;
            }
            return returnstring;
        }

        //metod som uppdaterar räknaren genom att dela med valörens belopp, samt returnerar räknaren
        public int SetAndReturnCount(int change)
        {
            count = change / amount;
            return count;
        }

        //metod som uppdaterar räknaren genom att dela med beloppet och returnerar sedan restbeloppet
        public int UpdateCountReturnRemainder(int change)
        {
            count = change / amount;
            int remainder = change % amount;
            return remainder;
        }

    }
}
