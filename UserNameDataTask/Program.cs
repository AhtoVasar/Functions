using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurbidi
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja nime esimest tähte
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number 1-3:");
            char userNumber = Convert.ToChar(Console.ReadLine());

         

            switch (userNumber)
            {
                case '1':
                    UserNameReverse(userName);
                    break;
                case '2':
                    UserNameFirstLetter(userName);
                    break;
                case '3':
                    UserNameLength(userName);
                    break;
            }
        }
            
     
            
                public static void UserNameReverse(string userName)
            {
            
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                string reverse = userName;
                Console.Write($"{reverse[i]}"); }
            }
            public static void UserNameFirstLetter (string userName)

            {
                string First = userName;
                Console.WriteLine($"Sinu nime esimene täht:{First[0]}");
            }
            public static void UserNameLength (string userName)
             {
                int Length = userName.Length;
                Console.WriteLine($"Sinu nime pikkus:{Length} tähte");
             }   
    }
    
}
