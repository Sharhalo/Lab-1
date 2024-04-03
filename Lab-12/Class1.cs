using System;
using System.Collections.Generic;
using System.Linq;

record Person(string Name, int Total1, int Total2, int Total3);

class Program
{
    static void Main()
    {
        var list = new List<Person>()
        {
            new Person("James", 40, 20, 40),
            new Person("Nazar", 50, 20, 50),
            new Person("Join", 20, 20, 50)
        };

        foreach (var person in list)
        {
            var (average, aboveAverageCount) = CalculateAverageAndAboveCount(person);
            Console.WriteLine($"Ім'я: {person.Name}, Середній бал: {average:F2}, Кількість оцінок вище за середнє: {aboveAverageCount}");
        }
    }

    static (double, int) CalculateAverageAndAboveCount(Person person)
    {
        var totalScores = new int[] { person.Total1, person.Total2, person.Total3 };
        double average = totalScores.Average();
        int aboveAverageCount = totalScores.Count(score => score > average);
        return (average, aboveAverageCount);
    }
}

