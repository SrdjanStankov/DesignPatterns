using System;
using System.Collections.Generic;

namespace DesignPatterns.Bridge
{
    public class CustomersData : DataObject
    {
        private int current = 0;
        private List<string> customers = new List<string>()
        {
            "Jim Jones",
            "Samuel Jackson",
            "Allen Good",
            "Ann Stills",
            "Lisa Giovanni"
        };

        public override void NextRecord()
        {
            if (current <= customers.Count - 1)
            {
                current++;
            }
        }

        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public override void AddRecord(string customer) => customers.Add(customer);

        public override void DeleteRecord(string customer) => customers.Remove(customer);

        public override void ShowRecord() => Console.WriteLine(customers[current]);

        public override void ShowAllRecords()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(" " + customer);
            }
        }
    }
}
