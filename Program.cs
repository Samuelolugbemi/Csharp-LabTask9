using System;

namespace UniversityLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

                Library library1 = new Library(30, 3, 2020, 4, 4, 2020, "James", "100 level", "Things fall apart", "777", "John","Death of Yan", "7778");
                Library library2 = new Library(31, 8, 2020, 4, 2, 2020, "Stuaart", "200 level", "Things stand again", "767", "Jan","Dont cry", "778");
                Library library3 = new Library(30, 3, 2020, 10, 10, 2020, "Jas", "300 level", "Things fall apart yet again", "777", "Jean","Death of Yin", "777");
                Library library4 = new Library(18, 2, 2020, 5, 7, 2020, "James", "100 level", "Things fall apart", "777", "John","Death of Yan", "7778");
                Library library5 = new Library(30, 3, 2020, 4, 4, 2020, "James", "100 level", "Things fall apart", "777", "John","Death of Yan", "7778");


            GenericDefaulterList<IDefaulters> library = new GenericDefaulterList<IDefaulters>(6); 


               library.Add(library1);                     
               library.Add(library2);                     
               library.Add(library3);                     
               library.Add(library4);                     
               library.Add(library5);  
             

            library.GetDefaulter();
        }
    }
}
