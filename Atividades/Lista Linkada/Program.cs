using System.Diagnostics;

public class Page
{
    public string Content {get; set;}
}

class Program
{
    static void Main(String[] args)
    {

        Page pageFirst = new Page() { Content = "Nowadays..."};
        Page pageSecond = new Page() { Content = "Application..."};
        Page pageThird = new Page() { Content = "A lot of..."};
        Page pageFourth = new Page() { Content = "What a new..."};
        Page pageFifth = new Page() { Content = "What's gone won..."};
        Page pageSixth = new Page() { Content = "Helll yea..."};

        LinkedList<Page> Pages = new LinkedList<Page>();
            Pages.AddLast(pageSecond);
            LinkedListNode<Page> nodePageFourth = Pages.AddLast(pageFourth);
            Pages.AddLast(pageSixth);
            Pages.AddFirst(pageFirst);
            Pages.AddBefore(nodePageFourth, pageThird);
            Pages.AddAfter(nodePageFourth, pageFifth);

        LinkedListNode<Page> current = Pages.First;
        int number = 1;
        while(current != null)
        {
            Console.Clear();
            string numberString = $"-{number}-";
            int leadingSpaces = (90 - numberString.Length) /2;
            Console.WriteLine (numberString.PadLeft(leadingSpaces + numberString.Length));
            Console.WriteLine();

            string Content = current.Value.Content;
            for (int i = 0; i < Content.Length; i += 90)
            {
                String line = Content.Substring(i);
                line = line.Length > 90 ? line.Substring(0, 90) : line;
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine($"Quote from 'Windows Application Development CookBook' by Marcin Jamro, {Environment.NewLine} published by Packt publishing in 2016.");

            Console.WriteLine();
            Console.WriteLine(current.Previous != null ? "< PREVIOUS [P]".PadRight(14) : string.Empty);
            Console.WriteLine(current.Next != null ? "[N]  NEXT >".PadLeft(76) : string.Empty);
            Console.WriteLine();
            
        switch(Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
                if(current.Next != null)
                {
                    current = current.Next;
                    number++;
                }
                break;
            case ConsoleKey.P:
                if(current.Previous != null)
                {
                    current = current.Previous;
                    number--;
                }
                break;
            default : return;
        }

        }
    }
}