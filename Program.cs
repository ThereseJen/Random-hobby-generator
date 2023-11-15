namespace Random_opg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int randomHobby = rand.Next(0, 6);

            Console.WriteLine("Si meg hva navnet ditt er, så skal du få utdelt en hobby!");
            var brukerInput = Console.ReadLine();

            if (randomHobby == 1)
            {
                Console.WriteLine($"{brukerInput}, din nye hobby er strikking!");
            }
            else if (randomHobby == 2)
            {
                Console.WriteLine($"{brukerInput}, din nye hobby er koding. Kondolerer!");
            }
            else if (randomHobby == 3)
            {
                Console.WriteLine($"{brukerInput}, din nye hobby er basejumping. Ikke spør meg hvorfor.");
            }
            else if (randomHobby == 4)
            {
                Console.WriteLine($"{brukerInput}, din nye hobby er frimerkesamling. Dessverre.");
            }
            else if (randomHobby == 5)
            {
                Console.WriteLine(
                    $"{brukerInput}, din nye hobby er kakebaker. Bare husk å sjekk blodsukkeret ditt av og til.");
            }
            else
            {
                Console.WriteLine("Du er for lat til å ha en hobby. Eller ... Kanskje politiker er noe for deg?");
            }

        }
    }
}
