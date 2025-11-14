namespace _02.Article
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");
            
            int numberOfInputs = int.Parse(Console.ReadLine());

            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new Article(title, content, author);

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] commandInput = Console.ReadLine().Split(": ");

                string commandType = commandInput[0];
                string newData = commandInput[1];

                if (commandType == "Edit")
                {
                    article.Edit(newData);
                }
                else if (commandType == "ChangeAuthor")
                {
                    article.ChangeAuthor(newData);
                }
                else if (commandType == "Rename")
                {
                    article.Rename(newData);
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}


