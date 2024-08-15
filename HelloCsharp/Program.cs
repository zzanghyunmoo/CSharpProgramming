namespace HelloCsharp
{
    class GiftBox
    {
        public required string Letter;
        public int Money;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GiftBox a = new()
            {
                Letter = "A 친구야 잘 지내니?",
                Money = 100_000,
            };
            GiftBox b = new()
            {
                Letter = "B 친구야 잘 지내니?",
                Money = 120_000,
            };
            GiftBox c = new()
            {
                Letter = "C 친구야 잘 지내니?",
                Money = 130_000,
            };
            Console.WriteLine($"a 내용: {a.Letter}\n돈: {a.Money}");
            Console.WriteLine($"b 내용: {b.Letter}\n돈: {b.Money}");
            Console.WriteLine($"c 내용: {c.Letter}\n돈: {c.Money}");
        }
    }
}


