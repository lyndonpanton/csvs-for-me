namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // format: <pyramid slot number>,<block letter>,<whether or not the block should be lit>
            Console.Write("Enter a valid 3 part string: ");
            string userInput = Console.ReadLine();

            int firstCommaInput = userInput.IndexOf(',');

            int pyramidSlotNumber = int.Parse(userInput.Substring(0, firstCommaInput));

            Console.WriteLine(pyramidSlotNumber);
        }
    }
}