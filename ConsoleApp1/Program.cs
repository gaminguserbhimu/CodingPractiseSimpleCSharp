using ConsoleApp1;
using System.Net.NetworkInformation;
using System.Text;

internal class Program
{

    public Program()
    {
        Console.WriteLine("Chill Marr");
    }
    private static void Main(string[] args)
    {
        // string input = Console.ReadLine();
        Program program = new Program();
        //program.anagrams(input, "tans");
        //program.primeList(10);
        //program.swipe(120, 130);
        //program.perfectSquare(49);
        //program.perfectCube(64);

        program.dubalicate("Vinay krishna d Kunthe");

        program.palindrome("Gadeag");

        NewProgram newProgram = new NewProgram();
    }

    void old()
    {
        Program program = new Program();
        //program.anagrams(input, "tans");
        //program.primeList(10);
        //program.swipe(120, 130);
        //program.perfectSquare(49);
        //program.perfectCube(64);

        program.removeDublicate("INDIANS");

        program.pattern3();

        program.pattern2();

        program.pattern1();

        program.reverse2("Vinay245K");

        program.sortArray();

        program.trying();

        program.sortIt2();

        program.countChars("VinayKrishna");

        program.onlyAlphaNum("Hello@123#World!$U789");

        program.seprateUpperCase("IsYourNameShiven");

        // Console.WriteLine(program.prime(251));

        Console.WriteLine("Hello, World!");

        Class1 newz = new Class1();

        newz.News();

        NewProgram newProgram = new NewProgram();

    }
    string reverse(string input)
    {
        string value = input;
        char[] chars = value.ToCharArray();

        int right = 0;
        int left = value.Length - 1;

        while (right < left)
        {
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;

            right++;
            left--;
        }

        string reverse = new string(chars);

        Console.WriteLine(reverse);


        return reverse;
    }

    void palindrome(string input)
    {
        string value = input.ToLower();

        bool result = true;

        int left = 0;
        int right = value.Length - 1;

        while (left < right)
        {
            if (value[left] != value[right])  
                result = false; 
            left++;
            right--;
        }

        if (result)
        {
            Console.WriteLine($"The given input = {input} is palindrome ");
        } else { Console.WriteLine($"The given input = {input} is not palindrome "); }
    }

    void reverse2(string input)
    {
        string value = input;
        Char[] charValue = value.ToCharArray();

        Char[] reverse = new Char[value.Length];
        int length = value.Length - 1;

        for (int i = 0; i < value.Length ; i++)
        {
            char temp = charValue[i];
            reverse[length] = temp;
            length--;

        }
        Console.WriteLine(new string(reverse));
    }

    void dubalicate(string input)
    {
        char[] value = input.ToUpper().ToCharArray();
        bool status = false;
        string dublic = "";
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i; j < input.Length; j++)
            {
                if (i != j)
                {
                    if (value[i].Equals(value[j]))
                    {
                        
                        dublic += value[i].ToString() + " ";
                        status = true;
                    }
                }
            }
        }
        if (status == true)
        {
            Console.WriteLine("Dublicates found " + dublic);
        }
        else
        {
            Console.WriteLine("Dublicates not found ");
        }


        //foreach (char c in value)
        //{
        //    int count = 0;
        //    foreach (char b in value)
        //    {                
        //        if(c == b) 
        //        { 
        //            count++; 
        //        }                
        //    }
        //    if (count > 1)
        //    {
        //        Console.WriteLine("Dublicates found " + c + " with occurance " + count + " times");
        //    }
        //}
    }

    void removeDublicate(string input)
    {       
        var seen = new HashSet<char>();
        var sb = new StringBuilder();

        foreach (char c in input)
        {
            if (seen.Add(c)) // Add returns false if the item already exists
            {
                sb.Append(c);
            }
        }

        Console.WriteLine( sb.ToString());
    }

    void anagrams(string input1,string input2)
    {
        char [] chars1 = input1.ToCharArray();
        char [] chars2 = input2.ToCharArray();
        Array.Sort(chars1);
        Array.Sort(chars2);

        string sorted1 = new string(chars1);
        string sorted2 = new string(chars2);

        if (sorted1.Equals(sorted2))
        {
            Console.WriteLine("given strings " + input1 + " and " + input2 + " are anagrams");
        }
        else
        {
            Console.WriteLine("given strings " + input1 + " and " + input2 + " are not anagrams");
        }
    }

    string prime(int value)
    {
        int n = value;
        bool isPrime = true;

        for (int i = 2; i < n/2; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }

        }

        string result = (isPrime ? $"The given number {n} is Prime" : $"The given number {n} is Not Prime");
        return result;

    }

    void primeList(int value)
    {
        int n = value;
        int count = 0;
        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine($"Prime number {i}");
                count++;
            }
        }
        double percentage = ((count * 100) / value);
        Console.WriteLine($"Totally {count} prime numbers are present below the given number {value} with percentage {percentage}% of prime numbers");
    }

    void swipe(int value1, int value2)
    {
        int first = value1;
        int second = value2;

        Console.WriteLine($"First value {value1} and second value {value2}");

        first = first + second;
        second = first - second;
        first = first - second;

        Console.WriteLine($"swiped First value {first} and second value {second}");
    }

    void perfectSquare(int input)
    {
        int a = input;
        bool output = false;
        for (int i = 1; (i * i) <= a; i++)
        {
            if ((i * i) == input)
            {
                output = true;
            }
        }

        if (output == true)
        {
            Console.WriteLine($"The given number {input} is a perfect square");
        }
        else
        {
            Console.WriteLine($"The given number {input} is not a perfect square");
        }
    }

    void perfectCube(int input)
    {
        int a = input;
        bool output = false;
        for (int i = 1; (i * i * i) <= a; i++)
        {
            if ((i * i * i) == input)
            {
                output = true;
            }
        }

        if (output == true)
        {
            Console.WriteLine($"The given number {input} is a perfect cube");
        }
        else
        {
            Console.WriteLine($"The given number {input} is not a perfect cube");
        }
    }

    public void sortArray()
    {
        int[] arr = { 24, 56, 7, 89, 24, 74 };
        int length = arr.Length - 1;

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length-i; j++) 
            {
                if( arr[j] < arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }

        Console.WriteLine("2nd highest  "+arr[1]);

        for (int i = 0; i < length+1; i++)
        {
            Console.WriteLine($" {i} value is {arr[i]} ");
        }

    }

    void pattern1()
    {
        for(int i = 4;i >= 1;i--)
        {
            for(int j = 4; j >= i ; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    void pattern2()
    {
        for (int i = 4; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    void pattern3()
    {
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            // Print spaces
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    void seprateUpperCase(string input)
    {
        string value = input;
        char[] chars = value.ToCharArray();
        string newOutput = "";

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i]))
            {
                newOutput += " " + chars[i];
            }
            else { 
            newOutput += chars[i];
            }
        }
        double.TryParse("3423.56", out double result);
        Console.WriteLine(new string(newOutput));
    }


    void trying()
    {
        //try and catch
        try
        {
            int a = 10;
            var c = 0;

            int result = a / c;   // This will cause an exception

            Console.WriteLine("Result: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
    }

    void countChars(string value)
    {
        string input = value.ToUpper();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        foreach (var item in charCount)
        {
            Console.Write(item.Key + " : " + item.Value + " , ");
        }

        Console.WriteLine();
    }
   
    void sortIt2()
    {
        int[] arry = { 25, 79, 7, 75, 87 };

        for (int i = 0; i < arry.Length-1; i++)
        {
            for (int j = 0; j < arry.Length - 1; j++)
            {
                if (arry[j] > arry[j + 1])
                {
                    int temp = arry[j];
                    arry[j] = arry[j+1];
                    arry[j+1] = temp;
                }
            }
            
        }

        foreach(var item in arry)
        {
            Console.WriteLine(item);
        }

    }

    void onlyAlphaNum(string value)
    {
        string input = value;
        string result = "";

        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                result += c;
            }
        }

        Console.WriteLine("Output: " + result);
    }

    public class Class1
    {
        public void News()
        {
            Console.WriteLine("write yourself");
        }
    }

    public class Class2 : Class1
    {
        public void News()
        {
            Console.WriteLine("This is you");
        }
    }



}