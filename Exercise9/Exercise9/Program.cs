namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 – Extracting the Pyramid Slot Number

            // format: <pyramid slot number>,<block letter>,<whether or not the block should be lit>
            Console.Write("Enter a valid 3 part string: ");
            string userInput = Console.ReadLine();

            Console.WriteLine();

            int firstCommaInput = userInput.IndexOf(',');

            int pyramidSlotNumber = int.Parse(userInput.Substring(0, firstCommaInput));

            Console.WriteLine("First section of the input: " + pyramidSlotNumber);

            // Problem 2 – Extracting the Block Letter

            string twoPartInput = userInput.Substring(firstCommaInput + 1);

            int secondCommaInput = twoPartInput.IndexOf(",");

            char blockLetter = char.Parse(twoPartInput.Substring(0, secondCommaInput));

            Console.WriteLine("Second section of the input: " + blockLetter);

            // Problem 3 – Extracting Whether Or Not the Block Should Be Lit

            bool shouldBeLit;

            string threePartInput = twoPartInput.Substring(secondCommaInput + 1);

            if ((threePartInput.Substring(0, threePartInput.Length)) == "T")
            {
                shouldBeLit = true;
            }
            else
            {
                shouldBeLit = false;
            }


            Console.WriteLine("Third section of the input: " + shouldBeLit);

        }
    }
}