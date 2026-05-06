class program
{
    static void Main(string[] args)
    {
        char A = 'A';
        char Z = 'Z';
        while (A <= Z)
        {
            Console.Write($"{A}");
            A++;
            if (A <= Z)
            {
                Console.Write(",");
            }
            else
            {
                Console.WriteLine(".");
            }
            
        }
        A = 'A';
        Z = 'Z';

        while (Z >= A)
        {
            
            
            Console.Write($"{Z}");
            Z--;
            if (Z >= A)
            {
                Console.Write(",");
            }
            else
            {
                Console.WriteLine(".");
            }
            
        }
        





















    }
    
}