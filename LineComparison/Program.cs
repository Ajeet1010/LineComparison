namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Line Comparison Problems  *****\n");
            Console.Write("1. Find the length of line\n2. Using JAVA EQUALS METHOD.\n3. Using JAVA COMPARETO METHOD.\nChoose option to perform:  ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your choice is:  " + option +"\n");

            switch (option)
            {
                case 1:
                    Length length = new Length();
                    length.Compare();
                    break;
                case 2:
                    Java java = new Java();
                    java.Equals();
                    break;
                case 3:
                    JavaMethod javaMethod = new JavaMethod();
                    javaMethod.CompareTo();
                    break;
                default:
                    Console.WriteLine("Choose the correct option from above ");
                    break;
            }
            
        }
    }
}