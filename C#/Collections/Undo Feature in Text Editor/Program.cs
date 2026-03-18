namespace Undo_Feature_in_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> actions = new Stack<string>();

           
            actions.Push("Type A");
            actions.Push("Type B");
            actions.Push("Delete B");
            actions.Push("Type C");
            actions.Push("Paste Text");

            Console.WriteLine("Actions stored in stack:");
         foreach(var action in actions)
         {
                Console.WriteLine(action);
         }

            Console.WriteLine("\n undo last 3 Actions");
            for(int i=0;i<3;i++)
            {
                if(actions.Count>0)
                {
                    Console.WriteLine("Undo " + actions.Pop());

                }
            }
            Console.WriteLine("Show Current Top Action");
            if(actions.Count>0)
            {
                Console.WriteLine("\nCurrent Top Action: " + actions.Pop());

            }
            else
            {
                Console.WriteLine("No Actions Left in stack");
            }

        }
    }
}
