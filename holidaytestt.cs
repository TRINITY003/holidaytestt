using System;

namespace AlphasNew
{
    class Program
    {
        static void Main(string[] args)
        {

                    Console.WriteLine("---------------------------------Question 3-----------------------------");
        nt a,b,c,d,e; 
 
 printf("ENTER THE FIVE NUMBERS"); 
 scanf("%d %d %d %d %d",&a,&b,&c,&d,&e); 
 
 if(a>b && a>c &&  a>d && a>e) 
  printf("%d is largest", a); 
 
 else 
  if(b>c && b>d && b>e) 
   printf("%d is largest", b); 
 
 else 
  if(c>d && c>e) 
   printf("%d is largest", c); 
 
 else 
  if(d>e) 
   printf("%d  is largest", d); 
 
 else 
  printf("%d is largest", e); 
  
 return 0; 


                            Console.WriteLine("----------------------------Question 9---------------------------");
                 List<int> ans = new List<int>();
  
        if (matrix.Length == 0)
            return ans;
  
        int R = matrix.GetLength(0), C = matrix.GetLength(1);
        bool[,] seen = new bool[R,C];
        int[] dr = { 0, 1, 0, -1 };
        int[] dc = { 1, 0, -1, 0 };
        int r = 0, c = 0, di = 0;
  
        // Iterate from 0 to R * C - 1
        for (int i = 0; i < R * C; i++) {
            ans.Add(matrix[r,c]);
            seen[r,c] = true;
            int cr = r + dr[di];
            int cc = c + dc[di];
  
            if (0 <= cr && cr < R && 0 <= cc && cc < C
                && !seen[cr,cc]) {
                r = cr;
                c = cc;
            }
            else {
                di = (di + 1) % 4;
                r += dr[di];
                c += dc[di];
            }
        }
        return ans;
    }
  
    
    public static void Main(String[] args)
    {
        int[,]a = { { 1, 2, 3, 4 },
                      { 5, 6, 7, 8 },
                      { 9, 10, 11, 12 },
                      { 13, 14, 15, 16 } };
  
        spiralOrder(a).ForEach(i=>Console.Write(i+" "));
    }
}
  
                    Console.WriteLine("----------------------------Question 10--------------------------------");
                    int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);


                        Console.WriteLine("----------------------------Question 11-----------------------------");
                         {
        int n = arr1.Length;
        int m = arr2.Length;
 
        // If lengths of array are not
        // equal will mean array are not equal
        if (n != m)
            return false;
 
        // Sort both arrays
        Array.Sort(arr1);
        Array.Sort(arr2);
 
       
        for (int i = 0; i < n; i++)
            if (arr1[i] != arr2[i])
                return false;
 
        // If all elements were same.
        return true;
    }
 
    
    public static void Main()
    {
        int[] arr1 = { 3, 5, 2, 5, 2 };
        int[] arr2 = { 2, 3, 5, 5, 2 };
 
        if (areEqual(arr1, arr2))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}




                    Console.WriteLine("-----------------------------Question 12-------------------------------");
                    {
            int count = 1, tempCount = 1, number = 0;

			Console.Write ("Enter array length: ");
			int length = Int32.Parse (Console.ReadLine ());
			int[] arr = new int[length];

			for (int i = 0; i < arr.Length; i++) 
			{
				Console.Write ("Enter {0} element: ", i);
				arr [i] = Int32.Parse (Console.ReadLine ());
			}

			for (int i = 0; i < arr.Length - 1; i++) 
			{
                if (arr[i] == arr[i + 1]) tempCount++;
                else tempCount = 1;

				if (tempCount > count) 
				{
					count = tempCount;
					number = arr [i];
				}
			}

			for (int i = 0; i < count; i++) Console.Write ("{0}, ", number);

                    Console.WriteLine("-------------------------------Question 13-----------------------------------");
                     {
        // if frequencies of two elements are same
        // then the larger number should come first
        if (p1.Value == p2.Value)
            return p1.Key.CompareTo(p2.Key);
 
        // sort on the basis of decreasing order
        // of frequencies
        return p1.Value.CompareTo(p2.Value);
    }
}
 
public class KFrequentNumbers {
    static void print_N_mostFrequentNumber(int[] arr, int n,
                                           int k)
    {
 
        IDictionary<int, int> um
            = new Dictionary<int, int>();
 
        // Put count of all the
        // distinct elements in Map
        // with element as the key &
        // count as the value.
        for (int i = 0; i < n; i++) {
 
            // Get the count for the
            // element if already present in the
            // Map or get the default value which is 0
            if (um.ContainsKey(arr[i]))
                um[arr[i]] += 1;
            else
                um[arr[i]] = 1;
        }
 
        
 
        // Sort the list
        Comparer compare = new Comparer();
        list.Sort(compare);
 
        for (int i = 0; i < k; i++)
            Console.Write(list[i].Key + " ");
    }
 
    public static void Main(string[] args)
    {
        int[] arr = { 3, 1, 4, 4, 5, 2, 6, 1 };
        int n = arr.Length;
        int k = 2;
 
        Console.Write(
            k + " elements with most occurrences are:\n");
        // Function call
        print_N_mostFrequentNumber(arr, n, k);
    }
}
 


            Console.WriteLine("-----------------------------Question 14--------------------");
           Console.WriteLine("Enter the Decimal Number : ");
            int number = int.Parse(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.WriteLine("Binary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.WriteLine(numberArray[i]);
            }
            Console.ReadKey();

          Console.WriteLine("---------------------------Question 15---------------------------");
            Console.Write("Enter the Binary Number : ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
           

            int base1 = 1;
            
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"Decimal Value : {decimalValue} ");
            Console.ReadKey();

            Console.WriteLine("--------------------------------Question 16-----------------------");
            int decimalNumber, quotient;
        int i = 1, j, temp = 0;
        char[] hexadecimalNumber = new char[100];
        char temp1;
        Console.WriteLine("Enter a Decimal Number :");
        decimalNumber = int.Parse(Console.ReadLine());
        quotient = decimalNumber;
        while (quotient != 0)
        {
            temp = quotient % 16;
            if (temp < 10)
                temp = temp + 48;
            else
                temp = temp + 55;
            temp1 = Convert.ToChar(temp);
            hexadecimalNumber[i++] = temp1;
            quotient = quotient / 16;
            
        }
        Console.Write("Equivalent HexaDecimal Number is ");
        for (j = i - 1; j > 0; j--)
            Console.Write(hexadecimalNumber[j]);
        Console.Read();

        Console.WriteLine("--------------------------------------Question 17----------------------------------");
          string hexval = "4B0";
     Console.WriteLine("Hexadecimal number: "+hexval);
     int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
     Console.WriteLine("Convert to-");
     Console.WriteLine("Decimal number: "+decValue);


                Console.WriteLine("------------------------------------Question 18------------------------");
                
{
    // Get the Hexadecimal number
    string s = "1AC5" ;
    char[] hexdec = new char[100];
           hexdec = s.ToCharArray();
 
    // Convert HexaDecimal to Binary
    System.Console.Write("Equivalent Binary value is : ");
    try
    {
        HexToBin(hexdec);
    }
    catch (System.IndexOutOfRangeException)
    {
        System.Console.Write("");
    }
}


            Console.WriteLine("------------------------------------------Question 19---------------------------------");
            {
  int len = s.Length, check = 0;
  int num = 0, sum = 0, mul = 1;
  List<char> ans =
       new List<char>();
 
  // Iterating through
  // the bits backwards
  for (int i = len - 1; i >= 0; i--)
  {
    sum += (s[i] - '0') * mul;
    mul *= 2;
    check++;
 
    // Computing the HexaDecimal
    // Number formed so far
    // and storing it in a vector.
    if (check == 4 || i == 0)
    {
      if (sum <= 9)
        ans.Add((char) (sum + '0'));
      else
        ans.Add((char) (sum + 55));
 
      // Reinitializing all
      // variables for next group.
      check = 0;
      sum = 0;
      mul = 1;
    }
  }
 
  len = ans.Count;
 
  // Printing the Hexadecimal
  // number formed so far.
  for (int i = len - 1; i >= 0; i--)
    Console.Write(ans[i]);
}
 
//print the result
public static void Main(String[] args)
{
  String s = "100000101111";
 
  
  bcdToHexaDecimal(s.ToCharArray());
}


            Console.WriteLine("-----------------------------------Question 20-------------------------");
            {
    int i,j;
  	int[,] arr1 = new int[3,3];
  
      
 
    /* Stored values into the array*/
       Console.Write("Input elements in the matrix :\n");
  for(i=0;i<3;i++)
  {
      for(j=0;j<3;j++)
      {
	      Console.Write("element - [{0},{1}] : ",i,j);
		  arr1[i,j] = Convert.ToInt32(Console.ReadLine()); 
      }
  }  
 
 Console.Write("\nThe matrix is : \n");
  for(i=0;i<3;i++)
  {
      Console.Write("\n");
      for(j=0;j<3;j++)
           Console.Write("{0}\t",arr1[i,j]);
     }
   Console.Write("\n\n");
   }
}






        }
           

     }
}

    
        
    

