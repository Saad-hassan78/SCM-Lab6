using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> groceries = new List<string>() {
            "Milk",
            "Bread",
            "Eggs",
            "Apples",
            "Rice"
        };
        groceries.Add("Chocolate");


        foreach (var item in groceries) {
            Console.WriteLine(item);
        }
    }
}
