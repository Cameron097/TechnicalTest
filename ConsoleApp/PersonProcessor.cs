using ConsoleApp.Models;

namespace ConsoleApp
{
    public static class PersonProcessor
    {
       
        public static double GetTotalGoodPersonPoints(List<Person> people)
        {
            // Initially casted GoodPersonPoints to a double,
            // however if the person object is expected to contain values this large it seemed better to just initialise the person object with a double type
            // casting at runtime is also much less efficient at runtime (downside of course being you initially require more memory with initialising objects with a double property over an int property)
            return people.Sum(p => p.GoodPersonPoints);
        }

        public static List<Person> PeopleBuilder()
        {
            Random random = new Random();
            var people = new List<Person>();
            var numberOfPeople = 100;

            for (int i = 0; i < numberOfPeople; i++)
            {
                if (i % 10 == 0) 
                {
                    people.Add(new Person
                    {
                        FullName = $"john smith{i}",
                        GoodPersonPoints = 514748005
                    });
                }

                people.Add(new Person
                {
                    FullName = $"john smith{i}",
                    GoodPersonPoints = random.Next(1, 100)
                });
            }

            return people;
        }
    }
}
