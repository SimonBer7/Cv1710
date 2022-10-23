namespace Cviceni2210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.cviceni -------------------------------------------");
            Console.WriteLine();

            Udalost u1 = new Udalost(Typ.SYSTEMOVA, Uroven.INFORMACE, "Popiiiiiiiisek");
            Udalost u2 = new Udalost(Typ.HARDWAROVA, Uroven.VAROVANI, "Popiiisek");
            Udalost u3 = new Udalost(Typ.SYSTEMOVA, Uroven.CHYBA, "Popiiiiiiiiseeeeeeeeek");
            Udalost u4 = new Udalost(Typ.SYSTEMOVA, Uroven.INFORMACE, "Popiisekkkkk");

            Seznam s = new Seznam();

            s.Add(u1);
            s.Add(u2);
            s.Add(u3);
            s.Add(u4);

            Console.WriteLine(s);



            Console.WriteLine(s.Filtr(Typ.SYSTEMOVA, Uroven.JINY));






            Console.WriteLine("2.cviceni -------------------------------------------");
            Console.WriteLine();

             Slovnicek sl = new Slovnicek();

            sl.AddSlovo(new Slovo(
                new List<string>() { "hrbitov"}, 
                new List<string>() { "cemetery", "churchyard", "graveyard" }));


            sl.AddSlovo(new Slovo(
                new List<string>() { "zidle"},
                 new List<string>() { "chair"}));

            sl.AddSlovo(new Slovo(
                new List<string>() { "stul" }, 
                new List<string>() { "table"}));

            Console.WriteLine("Zadane preklady =>");

            foreach (Slovo word in sl.Slovnik)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();

            Console.Write("Aniglcke vyrazy pro zadane slovo: ");
            foreach (string slovo in sl.HledejVeSlovniku("hrbitov", Jazyk.CZ))
            {
                Console.Write(slovo+", ");
            }
            Console.WriteLine();


            Console.Write("Ceske vyrazy pro zadane slovo: ");
            foreach (string slovo in sl.HledejVeSlovniku("table", Jazyk.EN))
            {
                Console.Write(slovo+", ");
            }

            Console.WriteLine();
           








        }
    }
}