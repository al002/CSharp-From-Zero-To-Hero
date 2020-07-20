using System;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            float maxBalance = 0;
            string[] names = new string[peopleAndBalances.Length];
            for (int j = 0; j < peopleAndBalances.Length; j++)
            {
                var item = peopleAndBalances[j];
                bool hasMax = false;
                var arr = item.Split(", ");

                for (int i = 1; i < arr.Length; i++)
                {
                    var balance = float.Parse(arr[i]);
                    if (balance >= maxBalance)
                    {
                        maxBalance = balance;
                        hasMax = true;
                    }
                }

                if (hasMax)
                {
                    names[names.Length - 1] = arr[0];
                }
            }

            string nameStr = "";
            if (names.Length > 1)
            {
                nameStr = String.Join(", ", names, 0, names.Length - 1) + $" and {names[names.Length - 1]}";
            }
            else
            {
                nameStr = names[0];
            }
            
            return $"{nameStr} had the most money ever. ¤{maxBalance}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length <= 2)
            {
                return "N/A.";
            }

            var name = "";
            float biggestLoss = 0;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var item = peopleAndBalances[i];
                var arr = item.Split(", ");

                for (int j = 1; j < arr.Length - 1; j++)
                {
                    var current = float.Parse(arr[j]);
                    var next = float.Parse(arr[j + 1]);
                    var loss = current - next;

                    if (loss < biggestLoss) {
                        biggestLoss = loss;
                        name = arr[0];
                    }
                }
            }
            return $"{name} lost the most money. -¤{biggestLoss}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return "";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            return "";
        }
    }
}
