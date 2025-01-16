using LearningFundamentals.trainingApp.Abstract;
using LearningFundamentals.trainingApp.fileSystemCommandLine;
using LearningFundamentals.trainingApp.Interface;
using System.Collections;
using System.Data;
using System.Runtime;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LearningFundamentals
{
    internal class Program
    {
        public enum Gender //simple enum
        {
            Male = 1, //the defuilte is (0) but can change it by this way
            Femal
        }
        public enum Color
        {
            red,
            blue,
            green,
            white,
            black,
            yellow,
            orange
        }
        /*
         * [flags enums]
         * what`s flags enum
         * how to define flags enum
         * how it works
         * Bitwise operation(|,&,~,^)
         */
        [Flags] //flags enum
        public enum WeekDay
        {
            None = 0,
            Saturday= 1,
            Sunday = 2,
            Monday = 4,
            Tuesday = 8,
            Wednesday = 16,
            Thursday = 32,
            Friday = 64,
        }

        static void Main(string[] args)
        {
            #region More
            //int intVar = 7;
            //double doubleVar = 17.7;

            //Console.WriteLine($"Enteger: {intVar}");
            //Console.WriteLine($"Double:  {doubleVar}");
            //Implicint Conversion
            //======================================================
            //doubleVar = intVar;
            //Console.WriteLine($"Enteger: {intVar}");
            //Console.WriteLine($"Double:  {doubleVar}");
            //======================================================
            //Explicit  Conversion
            //intVar = (int)doubleVar;
            //Console.WriteLine($"Enteger: {intVar}");
            //Console.WriteLine($"Double:  {doubleVar}");
            //Console.WriteLine(doubleVar.GetType());

            //Type Conversion using Parse and Convert Class

            //string age = "23";
            //int intVar = int.Parse(age);
            //Console.WriteLine($"String: {age}");
            //Console.WriteLine($"Integer: {intVar}");
            //intVar = 1000;
            //age = Convert.ToString(intVar);
            //Console.WriteLine($"String: {age}");
            //Console.WriteLine($"Integer: {intVar}");
            //Console.WriteLine(intVar.ToString().GetType());
            //Console.WriteLine(intVar.ToString("c"));
            #endregion
            #region DateTime
            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime);
            //dateTime = new DateTime(2001,4,1);
            ////string format = string.Format("Data is {0:yyyy}", dateTime);
            ////string format = string.Format("Data is {0:yy}", dateTime);
            ////string format = string.Format("Data is {0:yy MM}", dateTime);
            ////string format = string.Format("Data is {0:yy MM dd}", dateTime);
            //string format = string.Format("Data is {0:yyyy MMMM dddd HH:mm:ss tt}", dateTime);
            //Console.WriteLine(format);

            //Console.WriteLine(dateTime.Year);
            //Console.WriteLine(dateTime.DayOfYear);
            //Console.WriteLine(dateTime.Day);
            //Console.WriteLine(dateTime.DayOfWeek);
            //Console.WriteLine(dateTime.AddYears(3));

            //DateOnly date = new DateOnly(2001, 4, 1);
            //Console.WriteLine(date);
            //Console.WriteLine(date.Month);
            //Console.WriteLine(date.AddMonths(3).AddYears(3));

            //TimeOnly inEve = new TimeOnly(9,0);
            //TimeOnly outEv = new TimeOnly(17,0);
            //Console.WriteLine(inEve);
            //Console.WriteLine(outEv);
            //TimeSpan span = inEve - outEv;
            //Console.WriteLine(span.TotalMinutes);
            #endregion
            #region Exercise 
            //char[] chars = { 'f', 'm', 'M', 'F', 'f', 'm', 'M', 'F', 'f', 'm', 'M', 'F', 'm' };
            //int male = 0, female = 0;
            //foreach (char c in chars)
            //{
            //    if(char.ToLower(c) == 'f')
            //    {
            //        female++;
            //    }
            //    else
            //    {
            //        male++;
            //    }
            //}
            //Console.WriteLine($"Male is: {male}");
            //Console.WriteLine($"Female is: {female}");
            ////**************************************\\\\
            //int[] arr = { 443,550,2222,11,221,2244};
            //int max = 0, min=arr[0];
            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Min());
            //Console.WriteLine("-------");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    else if(arr[i] < min) 
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            ////Console.WriteLine("####################################################################");
            //Console.WriteLine("Enter your birthday(mm/dd/yy):");
            //DateOnly birthday = DateOnly.Parse(Console.ReadLine());
            //Console.WriteLine(birthday.DayOfWeek);
            //Console.WriteLine("####################################################################");
            //Console.WriteLine($"{birthday.DayOfWeek} of Manth {birthday:MMMM} Year: {birthday.Year}");
            //for (int i = 48; i < 58; i++) 
            //{
            //    Console.WriteLine($"The Number is:{i} and equ to ascii is: {(char)i}");
            //}
            //Console.WriteLine("=====================================================");
            //for (int i = 65; i < 91; i++)
            //{
            //    Console.WriteLine($"The Number is:{i} and equ to ascii is: {(char)i}");
            //}
            //Console.WriteLine("=====================================================");
            //for (int i = 97; i < 123; i++)
            //{
            //    Console.WriteLine($"The Number is:{i} and equ to ascii is: {(char)i}");
            //}
            //Console.WriteLine("####################################################################");
            //Console.Write("Enter size of array: ");
            //int s = int.Parse(Console.ReadLine());
            //int[] arr = new int[s];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter element({i+1}): ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]+"-");
            //}
            //Console.WriteLine("####################################################################");
            //Console.Write("Enter size of array: ");
            //int[] arr = new int[int.Parse(Console.ReadLine())];
            //int sum=0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter element({i + 1}): ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Reverse(arr);
            //foreach (int i in arr)
            //{
            //    sum += i;
            //}
            //sum /= arr.Length;
            //Console.WriteLine($"\nAverage: {sum}");
            //Console.WriteLine("####################################################################");
            //for (int i = 1; i <= 12; i++)
            //{
            //    for(int j = 1; j <= 12; j++)
            //    {
            //        Console.WriteLine($"{i} * {j}= {i*j}");
            //    }
            //    Console.WriteLine("=====================");
            //}
            //Console.WriteLine("####################################################################");
            //int s = 7;
            //for (int row = 1; row <= s; row++)
            //{
            //    for (int col = row; col <= s - 1; col++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int star = 1; star <= row * 2 - 1; star++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////Console.WriteLine("####################################################################");
            //Console.WriteLine();
            //for (int row = s; row >= 1; row--)
            //{
            //    for(int col = row; col <= s - 1; col++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int star=1; star < row * 2; star++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////Console.WriteLine("####################################################################");
            //for(int i=1; i <= s; i++)
            //{
            //    for( int j = 1; j <= s; j++)
            //    {
            //        if (j == 1 || j==i || i==s)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            ////Console.WriteLine("####################################################################");
            //Console.WriteLine();
            //for (int row = 1; row <= s; row++)
            //{
            //    for (int col = row; col <= s - 1; col++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int star = 1; star <= row ; star++)
            //    {
            //        if (star == 1 || star == row || row == s)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            ////Console.WriteLine("####################################################################");
            //Console.WriteLine();
            //for (int row = s; row >= 1; row--)
            //{
            //    for (int star = 1; star <= row; star++)
            //    {
            //        if (row == s || star == row || star == 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            ////Console.WriteLine("####################################################################");
            //Console.WriteLine();
            //for (int row = 1; row <= s; row++)
            //{
            //    for (int col = row; col <= s - 1; col++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int star = 1; star <= row * 2 - 1; star++)
            //    {
            //        if(row == s || star == 1 || star == (2 * row - 1))
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            ////Console.WriteLine("####################################################################");
            //Console.WriteLine();
            //for (int row = 1; row <= s; row++)
            //{
            //    for (int col = 1; col <= row - 1; col++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int star = 1; star <= s * 2 - (2 * row - 1); star++)
            //    {
            //        if (row == 1 || star == 1 || star ==(s * 2 - (2 * row - 1)))
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Title
            //Console.Title = "Ahmed Created First Programe";
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Hello, World!");
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("Hello Ahmed");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ReadLine();
            #endregion
            #region Variables
            ////Decliration Variables
            //string title = "They is good day to, Learning"; // Assigend Variables
            //Console.WriteLine(title);
            //Console.WriteLine(title);
            //Console.WriteLine(title);
            //Console.WriteLine(title);
            //Console.WriteLine(title);

            //##########=====Boolean=====##########//
            //bool isAlive = true;
            //Console.WriteLine($"Is Alive={isAlive}");
            //bool isRunning = false;
            //bool isRunning2 = false;
            //bool result = isRunning & isRunning2;  // it cheack all Variables 
            //bool result2 = isRunning && isRunning2;// if the first Variables is false it stop
            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //result = isRunning ^ isRunning2; //xor

            //##########=====CHAR=====##########//
            //Console.Read(); // read one char only and return ASCII CODE
            //char a = '9';
            //Console.WriteLine((int)a);
            //bool b= char.IsDigit(a);
            //Console.WriteLine(b);
            //b = char.IsLetter(a);
            //Console.WriteLine(b);

            //##########=====String Data Type=====##########//
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(name.Contains("m"));
            //Console.WriteLine(name.StartsWith('a'));
            //Console.WriteLine(name.EndsWith('M'));
            //Console.WriteLine(name.EndsWith("M", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(name.IndexOf('m'));
            //Console.WriteLine(name.LastIndexOf('m'));
            //Console.WriteLine(name.Contains("hossam")? name.Replace("hossam","AHMED"): "Nothing");

            //Console.Write("ENTER origan string:");
            //string name = Console.ReadLine();
            //Console.Write("Enter old name: ");
            //string old = Console.ReadLine();
            //Console.Write("Enter new name: ");
            //string ne = Console.ReadLine();
            //Console.WriteLine($"Your name is: {name.ToLower().Replace(old.ToLower(), ne)}");

            //##########=====Numeric Data Types=====##########//
            //Console.WriteLine(typeof(int));
            //Console.WriteLine(typeof(uint));
            //Console.WriteLine("----------");
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(uint.MaxValue);
            //Console.WriteLine("----------");
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(uint.MinValue);
            //Console.WriteLine("-----------");
            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(sizeof(uint));
            #endregion
            #region Foreach
            //char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //foreach (char c in chars)
            //{
            //    Console.WriteLine($"{c}= {(int)c}");
            //}
            #endregion
            #region Trining
            //Console.Write("Enter the size of array: ");
            //int[] arr = new int[int.Parse(Console.ReadLine())];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter {arr.Length} elements {i+1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"The Bigiest element in arra {FindM(arr)}");
            //Console.WriteLine($"The Smailet element in arra {FindM(arr, true)}");
            //Average(arr);


            //int FindM(int[] array, bool defuilt = false)
            //{
            //    if (!defuilt) 
            //        return array.Max();
            //    else
            //        return array.Min();
            //}
            //void Average(int[] arr)
            //{
            //    Console.WriteLine($"The average is: {arr.Average()}");
            //}
            //##########################################################
            //Console.Write("Enter a word to check: ");
            //string word = Console.ReadLine();
            //bool isPalinrdome = false;
            //for (int i = 0; i<word.Length /2; i++)
            //{
            //    if (word.ToLower()[i] == word.ToLower()[word.Length -i - 1])
            //    {
            //        isPalinrdome = true;
            //    }
            //}
            //Console.WriteLine($"{isPalinrdome}");
            #endregion

            //App.Run(args);

            //DataTable data = new DataTable();
            //string ex = Console.ReadLine();
            //var r = data.Compute(ex, "");
            //Console.WriteLine($"result: {r}");

            #region Stack & Queue

            //var commendStack = new Stack<AppendTextCommend>();
            //var redoStack = new Stack<AppendTextCommend>();
            //var originalText = "";

            //while (true)
            //{
            //    Console.Write("Type text to apped ('exit' to Exit, 'undo' to Undo, 'redo' to Redo): ");
            //    var input = Console.ReadLine();

            //    if(input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            //    {
            //        break;
            //    }
            //    else if(input.Equals("undo", StringComparison.OrdinalIgnoreCase))
            //    {
            //        if (commendStack.Count > 0)
            //        {
            //            var command = commendStack.Pop();
            //            originalText = command.Undo();
            //            redoStack.Push(command);
            //            Console.WriteLine(originalText);
            //        }
            //    }
            //    else if(input.Equals("redo", StringComparison.OrdinalIgnoreCase))
            //    {
            //        var command = redoStack.Pop();
            //        originalText = command.Execute();
            //        Console.WriteLine(originalText);
            //    }
            //    else
            //    {
            //        var command = new AppendTextCommend(originalText, input);
            //        originalText = command.Execute();
            //        commendStack.Push(command);
            //        Console.WriteLine(originalText);
            //    }
            //}
            //==========================================================================
            //var queu = new Queue<string>();

            //while(true)
            //{
            //    Console.Write("Pls, select a document to print ('print to print'): ");
            //    var input = Console.ReadLine();
            //    if(input.Equals("print", StringComparison.OrdinalIgnoreCase))
            //    {
            //        if(queu.Count > 0){
            //            Console.WriteLine(queu.Count);
            //            Console.WriteLine($"Printing document '{queu.Dequeue()}'...");
            //        }
            //        else
            //        {
            //            queu.Enqueue(input);
            //        }
            //    }
            //}

            #endregion
            #region Generic List & Dictionary
            //var list = new List<int>();
            //list.Add(1);
            //Console.WriteLine(list[0]+3);
            //============================
            //var d = new Dictionary<string,string>();
            //d.Add("n", "ahmed");
            //d.Add("p", "1234567");
            //Console.WriteLine(d["n"]);
            //var isf = d.TryGetValue("n", out var f);

            //foreach(var v in d)
            //{
            //    Console.WriteLine(v.Key +":"+ v.Value);
            //}
            #endregion
            #region ArrayList&Boxing

            //int x = 4;
            //object o = x; //boxing
            //int y = (int)o; //unboxing
            //Console.WriteLine(y);

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("ahmed");
            //list.Add('a');
            //list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            //list.Add(true);

            //list.Remove(1);
            //list.RemoveAt(2);
            //list.RemoveRange(0, 2);
            //list.Insert(3, 43);

            //foreach(Object o in list)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine("=======");
            //Console.WriteLine(list.IndexOf("ahmed"));
            //Console.WriteLine(list.IndexOf("ahmed", 3));

            #endregion
            #region Abstract
            //Circle c1 = new Circle { Area = 22.2 };
            //c1.Print();

            //Console.WriteLine("=================");

            //Shape s = new Rectangl { Lenght = 50, witdh = 20 };
            //s.Print();

            //Console.WriteLine("=================");

            //Rectangl r = new Rectangl { Lenght = 50, witdh = 20 };
            //r.Print();

            //Console.ReadKey();
            #endregion
            #region Interface
            //IDevices devic = new Computer();
            //devic.TurnON();
            //devic.TurnOff();
            //Console.WriteLine("==========");
            //devic = new Mobil();
            //devic.TurnON();
            //devic.TurnOff();
            //Console.WriteLine("==========");
            //devic = new LightBulb();
            //devic.TurnOff();
            //Console.WriteLine("==========");
            //LightBulb l = new LightBulb();
            //l.TurnOff();
            #endregion

            #region Codeforce
            #region A. String Task
            //==============================A. String Task==============================\\
            //string input = Console.ReadLine().ToLower();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == 'a' || input[i] == 'o' || input[i] == 'y' || input[i] == 'e' || input[i] == 'u' || input[i] == 'i')
            //    {
            //        continue;
            //    }
            //    Console.Write("." + input[i]);
            //}
            #endregion
            #region A. Bear and Big Brother
            //==============================A. Bear and Big Brother==============================\\
            //string[] input = Console.ReadLine().Split();
            //double limak = int.Parse(input[0]);
            //double bob = int.Parse(input[1]);
            //int count = 0;

            //while (true)
            //{
            //    if(limak <= bob)
            //    {
            //        limak *= 3;
            //        bob *= 2;
            //        count++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(count);
            //        Environment.Exit(0);
            //    }
            //}
            #endregion
            #region Domino piling
            //==============================A. Domino piling==============================\\
            //string[] input = Console.ReadLine().Split();
            //int m = int.Parse(input[0]);
            //int n = int.Parse(input[1]);
            //int count = 0;

            //for (int i = 1; i <= (m * n); i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion
            #region Bit++
            //==============================A. Bit++==============================\\
            //int x = 0, n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    string op = Console.ReadLine();
            //    switch(op)
            //    {
            //        case "X++":
            //            x++;
            //            break;
            //        case "++X":
            //            ++x;
            //            break;
            //        case "X--":
            //            x--;
            //            break;
            //        case "--X":
            //            --x;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine(x);
            #endregion
            #region Team
            //==============================Team==============================\\
            //int numProblem= int.Parse(Console.ReadLine());
            //int sum = 0, counter = 0;
            //string num;
            //string[] s;
            //int[,] matrix = new int[numProblem, 3];

            //for (int i = 0; i < numProblem; i++)
            //{
            //    num = Console.ReadLine();
            //    s = num.Split(" ");
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        matrix[i,j]= int.Parse(s[j]);
            //    }
            //}
            //for (int i = 0;i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0;j < matrix.GetLength(1); j++)
            //    {
            //        sum += matrix[i, j];
            //    }
            //    if(sum >= 2)
            //        counter++;
            //    sum = 0;
            //}
            //Console.WriteLine(counter);
            #endregion
            #region Way Too Long Words
            //==============================Way Too Long Words==============================\\
            //int count = 0;
            //string[] arr = new string[int.Parse(Console.ReadLine())];

            //for (int i = 0; i<arr.Length; i++)
            //{
            //    arr[i] = Console.ReadLine();
            //}
            //foreach (string name in arr)
            //{
            //    if (name.Length > 10)
            //    {
            //        for (int i = 1; i < name.Length - 1; i++)
            //        {
            //            count++;
            //        }
            //        Console.WriteLine($"{name[0]}{count}{name[name.Length - 1]}");
            //        count = 0;
            //    }
            //    else
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            #endregion
            #region Watermelon
            //==============================Watermelon==============================\\
            //Console.Write("Enter wight of Watermelon: ");
            //int weight = int.Parse(Console.ReadLine());
            //if(weight %2 == 0 && weight > 2)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion
            #region Next Round
            //==============================A. Next Round==============================\\
            //string[] input = Console.ReadLine().Split();
            //int n = int.Parse(input[0]);
            //int k = int.Parse(input[1]) - 1;
            //int[] scores = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int count = 0;
            //foreach (int score in scores)
            //{
            //    if (score >= scores[k] && score > 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion
            #region Theatre Square
            //==============================A. Theatre Square==============================\\
            //string inp = Console.ReadLine();
            //string[] outp;
            //double n, m, a;
            //long x, y, res;

            //outp = inp.Split(" ");
            //n = long.Parse(outp[0]);
            //m = long.Parse(outp[1]);
            //a = long.Parse(outp[2]);

            //x = (long)Math.Ceiling(n/a);
            //y= (long)Math.Ceiling(m/a);

            //Console.WriteLine(x*y);
            #endregion
            #region Beautiful Matrix
            //==============================A. Beautiful Matrix==============================\\
            //int[,] matrix = new int[5, 5];
            //int row = -1, col = -1;

            //for (int i = 0; i < 5; i++)
            //{
            //    string[] input = Console.ReadLine().Split();

            //    for (int j = 0; j < 5; j++)
            //    {
            //        matrix[i, j] = int.Parse(input[j]);

            //        if (matrix[i, j] == 1)
            //        {
            //            row = i;
            //            col = j;
            //        }
            //    }
            //}

            //int targetRow = 2;
            //int targetCol = 2;

            //int rowMoves = Math.Abs(row - targetRow);
            //int colMoves = Math.Abs(col - targetCol);

            //int totalMoves = rowMoves + colMoves;

            //Console.WriteLine(totalMoves);
            #endregion
            #region Petya and Strings
            //==============================A. Petya and Strings==============================\\
            //string n1 = Console.ReadLine();
            //string n2 = Console.ReadLine();
            //Console.WriteLine(String.Compare(n1.ToLower(), n2.ToLower()));
            #endregion
            #region Helpful Maths
            //==============================Helpful Maths==============================\\
            //int[] inpt= Array.ConvertAll(Console.ReadLine().Split("+"), int.Parse);
            //Array.Sort(inpt);

            //for (int i=0; i< inpt.Length; i++)
            //{
            //    if (i == inpt.Length - 1)
            //    {
            //        Console.WriteLine(inpt[i]);
            //    }
            //    else
            //    {
            //        Console.Write(inpt[i] + "+");
            //    }
            //}

            #endregion
            #region A. Boy or Girl
            //string name = Console.ReadLine();
            //char[] input = name.ToCharArray();
            //int counter = 0;
            //Array.Sort(input);

            //for (int i = 0; i < input.Length -1; i++)
            //{
            //    if (input[i] == input[i + 1])
            //    {
            //        counter++;
            //    }
            //}

            //if((name.Length - counter) %2 == 0)
            //{
            //    Console.WriteLine("CHAT WITH HER!");
            //}
            //else
            //{
            //    Console.WriteLine("IGNORE HIM!");
            //}


            #endregion

            #endregion

            #region String Formatting
            //string str = "My name is {0}, Hello {1}";
            //str = "My name is {0}, Hello {1}, Welcome {0,7}";
            //Console.WriteLine(str);
            //str = string.Format(str, "Ahmed", "Noorhan");
            //Console.WriteLine(str);

            //double salary = 10000.5;
            ////str = "My Salary is {0:c3}";
            ////str = "My Salary is {0:n3}";
            //str = "My Salary is {0:0.00}";
            //str = string.Format(str, salary);
            //Console.WriteLine(str);
            #endregion
            #region String Split & Join
            ////split
            //Console.Write("Enter list of numbers: ");
            //string input = Console.ReadLine();
            //int sum = 0;
            //string[] output = input.Split(",");
            //foreach (string n in output)
            //    sum += int.Parse(n);
            //Console.WriteLine("The averga= "+sum/output.Length);
            ////join
            //string[] word = { "Hello", "Passionate", "Coders", "Word" };
            //string statment = string.Join(" ", word);
            //Console.WriteLine(statment);
            #endregion
            #region StringBuilder
            //string str = "Hello";
            //str = "Hello word";
            //str += ", I love Passionate Coders";
            //Console.WriteLine(str);
            //StringBuilder sb = new StringBuilder(4096);//possebal defiend capacity optionaly
            //sb.Append("Hello");
            //sb.Append(" Word");
            //sb.AppendLine(", I love Passionate Coders");
            //sb.Append(", Thank you");
            //Console.WriteLine(sb.ToString());
            //Console.WriteLine("The Lenght: "+sb.Length);
            //Console.WriteLine("The Capacity: " + sb.Capacity);
            //Console.WriteLine("The MaxCapacity: " + sb.MaxCapacity);
            #endregion
            #region Random
            //Random random = new Random();
            //int month = random.Next(1, 13);
            //int dice = random.Next(1, 7);
            //Console.WriteLine(month);
            //Console.WriteLine(dice);
            //Console.WriteLine("----------------------");
            //double n = 0;
            //n = random.NextDouble() * 10;
            //Console.WriteLine(n);
            #endregion
            #region Multidimensional Arrays
            //int[,] arr2d =
            //{
            //    {1,0,0},
            //    {1,1,0}
            //};

            //int[,] arr2d = new int[int.Parse(Console.ReadLine()), 3];
            //int t = 0;
            //for (int i = 0; i < arr2d.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2d.GetLength(1); j++)
            //    {
            //        arr2d[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < arr2d.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2d.GetLength(1); j++)
            //    {
            //        if (arr2d[i, j] == 1)
            //        {
            //            t++;
            //        }
            //    }
            //}
            //Console.WriteLine(t / arr2d.GetLength(1));
            #endregion
            #region Enums
            //FlagsEnum=================================================================
            //WeekDay w1 = WeekDay.Friday | WeekDay.Saturday | WeekDay.Sunday;
            //WeekDay w2 = WeekDay.Friday | WeekDay.Thursday | WeekDay.Wednesday;
            //Console.WriteLine(w1 & w2);

            //w1 = WeekDay.Friday | WeekDay.Saturday | WeekDay.Sunday | WeekDay.Thursday;
            //w2 = WeekDay.Friday | WeekDay.Thursday | WeekDay.Wednesday;
            //Console.WriteLine(w1 & w2);

            //Console.WriteLine(w1 & WeekDay.Wednesday);

            //Console.WriteLine("~");
            //Console.WriteLine(w1 & ~WeekDay.Sunday);
            //Console.WriteLine("^");
            //WeekDay w3 = w2 ^ WeekDay.Sunday;
            //Console.WriteLine(w3);
            //WeekDay w4 = w3 ^ WeekDay.Sunday;
            //Console.WriteLine(w4);
            //Console.WriteLine("===");
            //WeekDay weekDay = WeekDay.Friday | WeekDay.Saturday;
            //// 0b_0100_0000
            //// 0b_0000_0001
            //// 0b_0100_0001
            //Console.WriteLine(weekDay);
            //==========================================================================
            //Console.WriteLine("Pls, select a option");
            //Console.WriteLine("[1] chang background\t\t[2]chang forground");
            //string ch = Console.ReadLine();
            //foreach (var c in Enum.GetNames(typeof(ConsoleColor)))
            //{
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine("select color:");
            //string s = Console.ReadLine();

            //ConsoleColor consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), s, true);

            //if (ch == "1")
            //    Console.BackgroundColor = consoleColor;
            //else if (ch == "2")
            //    Console.ForegroundColor = consoleColor;
            //else
            //    Console.WriteLine("Wrong choose");
            //=============================================================================
            //Gender gender = Gender.Male;
            //Console.WriteLine($"Gender={gender} => {(int)gender}");
            //Console.WriteLine("=================================");
            //foreach (var color in Enum.GetNames(typeof(Color)))
            //{
            //    Console.WriteLine($"{color} => {(int)Enum.Parse(typeof(Color), color)}");
            //}
            //Console.WriteLine("================================");
            //string v = "Black";
            //Color color1 = (Color)Enum.Parse(typeof(Color), v, true);
            //Console.WriteLine($"Color={color1} => {(int)color1}");
            #endregion
            #region Rundom Values
            //char c;
            //while (true)
            //{
            //    Console.WriteLine("Pls, select an option: ");
            //    Console.WriteLine("[1]Generate random number\t\t[2]Generate random string");
            //    string choose = Console.ReadLine();
            //    int min = 0, max = 0, len;

            //    if (choose == "1")
            //    {
            //        Console.WriteLine("Do you want select min&max number(y/n)");
            //        c = char.Parse(Console.ReadLine());
            //        if (c == 'y' || c == 'Y')
            //        {
            //            Console.WriteLine("Enter min number");
            //            min = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Enter max number");
            //            max = int.Parse(Console.ReadLine());
            //            GenerateRandomNumber(min, max);
            //        }
            //        else if (c == 'n' || c == 'N')
            //        {
            //            GenerateRandomNumber();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Wrong input");
            //        }
            //    }
            //    else if (choose == "2")
            //    {
            //        Console.WriteLine("Do you want select Lenght of string: (y/n)");
            //        c = char.Parse(Console.ReadLine());
            //        if (c == 'y' || c == 'Y')
            //        {
            //            Console.WriteLine("Enter lenght");
            //            len = int.Parse(Console.ReadLine());
            //            if (len <= 0)
            //                throw new Exception("Can`t value be nagitave");
            //            Console.WriteLine("Do you want select buffer option:(y/n)");
            //            char ch = char.Parse(Console.ReadLine());
            //            if (ch == 'y' || ch == 'Y')
            //            {
            //                Console.WriteLine(@"[1]Include capital letters
            //                [2]Include small letters
            //                [3]Include number
            //                [4]Include symbols");
            //                int cho = int.Parse(Console.ReadLine());
            //                if (cho <= 0)
            //                    throw new Exception("Can`t value be nagitave");
            //                if(cho >= 5)
            //                    Console.WriteLine("Wrong input");

            //                GenerateRandomString(len, cho);
            //            }else if (ch == 'n' || ch == 'N')
            //            {
            //                GenerateRandomString(len);
            //            }else
            //                Console.WriteLine("Wrong input");
            //        }
            //        else if (c == 'n' || c == 'N')
            //        {
            //            GenerateRandomString();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Wrong input");
            //        }
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Wrong input");
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Environment.Exit(0);
            //    }

            //    Console.WriteLine("======================================================");
            //}
            #endregion
            #region File System Command Line
            //Console.Write(">>");
            //var input = Console.ReadLine().Trim();
            //var whitespaceHandling = input.IndexOf(" ");
            //var commend = input.Substring(0, whitespaceHandling);
            //var path = input.Substring(whitespaceHandling + 1);

            //if(commend == "list")
            //{
            //    foreach(var entry in Directory.GetDirectories(path))
            //    {
            //        Console.WriteLine($"\t[Dir]: {entry}");
            //    }
            //    foreach (var entry in Directory.GetFiles(path))
            //    {
            //        Console.WriteLine($"\t[File]: {entry}");
            //    }

            //}
            //else if(commend == "info")
            //{
            //    if (Directory.Exists(path))
            //    {
            //        var dirInfo = new DirectoryInfo(path);
            //        Console.WriteLine("Type: Directory");
            //        Console.WriteLine($"Created At: {dirInfo.CreationTime}");
            //        Console.WriteLine($"Last Modified At: {dirInfo.LastAccessTime}");
            //    }
            //    else if (File.Exists(path))
            //    {
            //        var fileInfo = new FileInfo(path);
            //        Console.WriteLine("Type: File");
            //        Console.WriteLine($"Created At: {fileInfo.CreationTime}");
            //        Console.WriteLine($"Last Modified At: {fileInfo.LastAccessTime}");
            //        Console.WriteLine($"Size in Bytes: {fileInfo.Length}");
            //    }
            //}
            //else if (commend == "remove")
            //{
            //    if (Directory.Exists(path))
            //    {
            //        Directory.Delete(path, true);
            //    }
            //    else if (File.Exists(path))
            //    {
            //        File.Delete(path);
            //    }
            //}
            //else if(commend == "mkdir")
            //{
            //    Directory.CreateDirectory(path);
            //}
            //else if(commend == "print")
            //{
            //    if (File.Exists(path))
            //    {
            //        var content = File.ReadAllText(path);
            //        Console.WriteLine(content);
            //    }
            //}
            #endregion
        }
        //private static void GenerateRandomNumber(int min=1000, int max=9999)
        //{
        //    Random rnd = new Random();
        //    Console.WriteLine($"Random number {rnd.Next(min, max)}");
        //}
        //private const string BUFFER = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz012345689~@#$%^&*()";
        ////
        //private const string BUFFER_CAPITAL = "ABCDEFGHIJKLMNOPQRSTUWXYZ";
        //private const string BUFFER_SMAIL = "abcdefghijklmnopqrstuwxyz";
        //private const string BUFFER_NUMBER = "0123456789";
        //private const string BUFFER_SYMBOLS = "@#$%^&*()";
        //
        //private static void GenerateRandomString(int l=1, int c=0)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    Random rnd = new Random();
        //    while(sb.Length < l)
        //    {
        //        if(c== 0)
        //        {
        //            var randomIndex = rnd.Next(0, BUFFER.Length - 1);
        //            sb.Append(BUFFER[randomIndex]);
        //        }else if(c== 1)
        //        {
        //            var randomIndex = rnd.Next(0, BUFFER_CAPITAL.Length - 1);
        //            sb.Append(BUFFER_CAPITAL[randomIndex]);
        //        }else if (c == 2)
        //        {
        //            var randomIndex = rnd.Next(0, BUFFER_SMAIL.Length - 1);
        //            sb.Append(BUFFER_SMAIL[randomIndex]);
        //        }else if (c == 3)
        //        {
        //            var randomIndex = rnd.Next(0, BUFFER_NUMBER.Length - 1);
        //            sb.Append(BUFFER_NUMBER[randomIndex]);
        //        }else if (c == 4)
        //        {
        //            var randomIndex = rnd.Next(0, BUFFER_SYMBOLS.Length - 1);
        //            sb.Append(BUFFER_SYMBOLS[randomIndex]);
        //        }
        //    }
        //    Console.WriteLine($"Random string {sb}");
        //}
    }
    class AppendTextCommend
    {
        private string _orignalText;
        private readonly string _textAppend;

        public AppendTextCommend(string orignalText, string textAppend)
        {
            this._orignalText = orignalText;
            this._textAppend = textAppend;
        }
        public string Execute()
        {
            _orignalText += _textAppend;
            return _orignalText;
        }
        public string Undo()
        {
            _orignalText = _orignalText.Substring(0,_orignalText.Length - _textAppend.Length);
            return _orignalText;
        }

    }
}
