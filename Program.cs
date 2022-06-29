using System;
{
namespace AlphaNew

    class Program
    {
        static void Main(string[] args)
        {
          //Arrays of months//
          
          string[] monthsName = {"January", "February", "March", "April", "May", "June", "July", "August","September","October", "November", "December"};
           Console.WriteLine("---------------Question 1------------");
           Console.WriteLine( monthsName [0] );
           Console.WriteLine( monthsName [1] );
           Console.WriteLine( monthsName [2] );
           Console.WriteLine( monthsName [3] );
           Console.WriteLine( monthsName [4] );
           Console.WriteLine( monthsName [5] );
           Console.WriteLine( monthsName [6] );
           Console.WriteLine( monthsName [7] );
           Console.WriteLine( monthsName [8] );
           Console.WriteLine( monthsName [9] );
           Console.WriteLine( monthsName [10] );
           Console.WriteLine( monthsName [11] );

           Console.WriteLine("---------------Question 2------------");
            
  
        // allocating memory for months.
        monthsName = new string[] {"January", "February", "March", "April", "May", "June", "July", "August","September","October", "November", "December"};
                                       
  
        // using Rank Property
        Console.WriteLine("Dimension of monthsName array: " 
                                       + monthsName.Rank);


           Console.WriteLine("---------------Question 3-----------------------");
           Array.Reverse(monthsName);
           Console.WriteLine("Reverse array:");
           foreach (string value in monthsName)
           {
                Console.WriteLine(value);
           }

            Console.WriteLine("-----------------Question 4---------------------");

          string[] monthsNames = {"April", "August", "December", "February", "January", "July", "June", "March", "May", "November", "October", "September"};
          Console.WriteLine( monthsNames [0] );
          Console.WriteLine( monthsNames [1] );
          Console.WriteLine( monthsNames [2] );
          Console.WriteLine( monthsNames [3] );
          Console.WriteLine( monthsNames [4] );
          Console.WriteLine( monthsNames [5] );
          Console.WriteLine( monthsNames [6] );
          Console.WriteLine( monthsNames [7] );
          Console.WriteLine( monthsNames [8] );
          Console.WriteLine( monthsNames [9] );
          Console.WriteLine( monthsNames [10] );
          Console.WriteLine( monthsNames [11] );


          Console.WriteLine("-----------------------Question 5----------------------");

            string[] monthName = {"January", "February", "March", "April", "May", "June"};
           
           Console.WriteLine( monthName [0] );
           Console.WriteLine( monthName [1] );
           Console.WriteLine( monthName [2] );
           Console.WriteLine( monthName [3] );
           Console.WriteLine( monthName [4] );
           Console.WriteLine( monthName [5] );


           Console.WriteLine("------------------------Question 6----------------------");

            string[] monthsNamez = { "January", "Febrary", "March", "April", "May", "June"};
      Console.WriteLine(string.Join(",", monthsNamez));
      string[] monthsNamezClone = monthsNamez.Clone() as string[];
      Console.WriteLine(string.Join(",", monthsNamezClone));
      Console.WriteLine();

         Console.WriteLine("------------------------Question 7------------------------");
      
        int[] myMonths = {"January", "February", "March", "April", "May", "June", "July", "August","September","October", "November", "December"};
        Console.WriteLine("Array Before Operation");
        PrintIndexAndValues(myMonths);
        Console.WriteLine();
  
        Array.Clear(myMonths, 1, 2);
  
        Console.WriteLine("Array After Operation:");
  
        PrintIndexAndValues(myMonths);
    }
  
    public static void PrintIndexAndValues(int[] myMonths)
    {
        for (int i = 0; i < myMonths.Length; i++++++++++++) {
            Console.WriteLine("{0}", myMonths[i]);


            Console.WriteLine("------------------------Question 8--------------------------");
             int[] myMonthz = {"January", "February", "March", "April", "May", "June"};
        Console.WriteLine("Array Before Operation");
        PrintIndexAndValues(myMonthz);
        Console.WriteLine();
  
        Array.Clear(myMonthz, 1, 2);
  
        Console.WriteLine("Array After Operation:");
  
        PrintIndexAndValues(myMonthz);
    }
  
       public static void PrintIndexAndValues(int[] myMonthz)
    {
        for (int i = 0; i < myMonthz.Length; i++++++) {
            Console.WriteLine("{0}", myMonthz[i]);




          



        }        

    }
    
}         


