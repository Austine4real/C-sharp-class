using System;

namespace my_app;
class Program
{
    static void Main(string[] args)
    {
        // int myNum = 15;
        //myNum = 20;
        //Console.WriteLine(myNum);

        // Console.WriteLine("Enter your age");
        // int age = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"you are {age} year old.");

        // Console.WriteLine("Enter your username:");
        // string? userName = Console.ReadLine();
        // Console.WriteLine($"my name is : {userName}");

        // int sum1 = 100 + 50;
        // int sum2 = sum1 + 250;
        // int sum3 = sum1 + sum2;
        // Console.WriteLine(sum1);
        // Console.WriteLine(sum2);
        // Console.WriteLine(sum3);

        // int x = 5;
        // int y = 3;
        // Console.WriteLine(x > y);

        // Console.WriteLine(Math.Max(x,y));

        // string firstName = "Austine";
        // string lastName = "Ugbodaga";
        // string name = $"My full name is : {firstName} {lastName}";
        // Console.WriteLine(name);

        // String name = "Austine Ugbodaga";
        // int myInt = name.IndexOf("U");
        // string lastName = name.Substring(myInt);
        // Console.WriteLine(lastName);

        // int a = -5;
        // int b = a;
        // Console.WriteLine(a);
        // Console.WriteLine(b);

        // b = 10;
        // Console.WriteLine(a);
        // Console.WriteLine(b);

        // int[] a = {-5};
        // int[] b = a;
        // Console.WriteLine(a[0]);
        // Console.WriteLine(b[0]);

        // b[0] = 10;
        // Console.WriteLine(a[0]);
        // Console.WriteLine(b[0]);

        // double a = double.NaN;
        // Console.WriteLine(double.IsNaN(a));

        // double a = double.PositiveInfinity;
        // Console.WriteLine(double.IsInfinity(a));

        // string name = "Austine";
        // char[] characters = {'h', 'e', 'l', 'l', 'o'};
        // string greeting = new string (characters);
        // Console.WriteLine($"{greeting} {name}");

        // string message = $"Hello my name is {name}, i will like to say {greeting}";
        // Console.WriteLine(message);

        
        // string name = "hello my name is austine";
        // string [] word = name.Split(' ');
        // Console.WriteLine(word[4]);

        // Car Ford = new Car();
        // Ford.model = "Mustang";
        // Ford.color = "red";
        // Ford.year = 1969;

        // Car Opel = new Car();
        // Opel.model = "Astra";
        // Opel.color = "white";
        // Opel.year = 2005;

        // Console.WriteLine(Ford.fullDec());
        // Console.WriteLine(Opel.fullDec());

        // Person person = new Person();
        // person.FirstName = "Austine";
        // person.LastName = "Ugbodaga";
        
        // Console.WriteLine(person.GetFullName());
        // Console.WriteLine(person.FullName);

        // Console.WriteLine("what do think, the name is?");
        // string? FullNameGuess = Console.ReadLine();

        // Console.WriteLine("second guess");
        // string? FullNameGuess2 = Console.ReadLine();

                // IF ELSE STATEMENT
        // if(person.FullName == FullNameGuess)
        // {
        //     Console.WriteLine("You got the name! you win");
        // } 
        // else if(person.FullName == FullNameGuess2)
        // {
        //     Console.WriteLine("You got the name! you got 1/2 points");
        // }
        // else
        // {
        //     Console.WriteLine("You are a dissapointment");
        // }

        // Console.WriteLine("Enter your age");
        // int age = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter your password");
        // string? password = Console.ReadLine();

        // if(age > 12 && password=="password123")
        // {
        //     Console.WriteLine("You ara a teenager and got the correct password");
        // } 
        // else if(age >12 || password=="password123")
        // {
        //     Console.WriteLine($"You are an adult but got the password wrong");
                
        // }
        // else{
        //     Console.WriteLine("You are under age and wrong password");
        // }

                // SWITCH STATEMENT 

        // Console.WriteLine("Enter your age");
        // int age = Convert.ToInt32(Console.ReadLine());
        // switch (age)
        // {
        //     case 14:
        //     Console.WriteLine("you are under age");
        //     break; 
        //     case 18:
        //     Console.WriteLine("you are aldult");
        //     break; 
        //     case 24:
        //     Console.WriteLine("you are a man");
        //     break; 
        //     default:
        //     Console.WriteLine("who are you");
        //     break;
        // }

            //   TENARY OPERATOR

            // int time = 20;
            // string result = (time>18)? "Good morning" : "Goog evening";
            // Console.WriteLine(result);

        //     Console.WriteLine("Enter your exam score");
        //     int score =Convert.ToInt32(Console.ReadLine());
        //     string result = (score>=40)? "passed": "Failed";
        //     Console.WriteLine($"You exam scores is {score}, you {result}");

        //     Console.WriteLine("Enter your age");
        //     int age =Convert.ToInt32(Console.ReadLine());
        //     string result2 = (age>=50)? "you are old": "you are young";
        //     Console.WriteLine($"You are {age} year old, {result2}");

                        // LOOPS

        // WHILE LOOP   

        // int i = 0;  //initialization
        // while (i < 10)
        // {
        //    Console.WriteLine(i);
        //    i++; 
        // }   

        // FOR LOOP
        // bool login = true;
        // for(int i = 0; i<10; i++ ){
        //     Console.WriteLine(i);
        //     if(i==7){
        //         if(login == true){
        //             Console.WriteLine("you won number 7");
        //         }
                    
        //     }

        // }    

        // for(int i = 0; i<50; i++){
        //         if(i % 3 == 0 && i % 5 == 0){
        //                 Console.WriteLine($"{i} FIZZ");     
        //         }
        //         else if(i % 2 == 0){
        //                 Console.WriteLine($"{i} BUZZ");  
        //         }
        //         else{
        //                 Console.WriteLine($"{i} FIZZBUZZ");     
        //         }
        // }


        //  for(int i=0; i<=9; i++)
        //     {
        //         for(int j=i; j<=9; j++)
        //         {
        //             Console.Write(j + " "); 
        //         }
        //             Console.WriteLine();
        //     } 

        // int i=0;
        // while (i<=9)
        // {
        //     int j=0;
        //     while (j<=i)
        //     {
        //        Console.Write(j + " " );
        //        j++;
        //     }
        //         Console.WriteLine();
        //         i++;
        // }

        // for(int i = 0; i<=5; i++){
        //     Console.WriteLine("#".Int32(i));
        //  }

            // BREAKS STATEMENT

        //     for(int i=0; i<=9; i++)
        //     {
        //         for(int j=i; j<=9; j++)
        //         {
        //             if(j == 3)
        //             {
        //                 break;
        //             }
        //             Console.Write(j + " "); 
        //         }
        //         if(i == 5)
        //             {
        //                 break;
        //             }
        //             Console.WriteLine();
        //     } 

            // CONTINUE STATEMENT

        //     for(int i=0; i<=9; i++)
        //     {
        //         for(int j=i; j<=9; j++)
        //         {
        //             if(j == 3)
        //             {
        //                 continue;
        //             }
        //             Console.Write(j + " "); 
        //         }
        //         if(i == 7)
        //             {
        //                 continue;
        //             }
        //             Console.WriteLine();
        //     } 

        //     bool found = false;
        //     int[] grades = {30, 100, 23, 10, 5};

        //     for(int i=0; i<grades.Length; i++)
        //     {
        //         if(grades[i] == 21)
        //         {
        //             Console.WriteLine("we found it!");
        //             found = true;
        //             break;
        //         }
        //     }
        //     if(!found)
        //     {
        //         Console.WriteLine("NOT FOUND");
        //     }

        //     int[] grades = {5,1,8,10,3,7,2,4,6};
        //     Array.Sort(grades);
        //      Array.Reverse(grades);
        //     for(int i=0; i<grades.Length; i++)
        //     {
        //         Console.WriteLine(grades[i]);
        //     }

            // Array SORT and REVERSE

            // int[] grades = {5,1,8,10,3,7,2,4,6};
            // Array.Sort(grades);
            // Array.Reverse(grades);
            // foreach(int i in grades)
            // {
            //     Console.WriteLine(i);
            // }


        // Array Comparism

        // int[] grades1 = {5,1,8,10,3,7,2,4,6};
        // int[] grades2 = {5,1,8,10,3,7,2,4,6};
        // if(Enumerable.SequenceEqual(grades1, grades2))
        // {
        //     Console.WriteLine("Equal");
        // }

// Multi-damensional array
        // int[,] grades = {
        //     {5, 8, 4, 1},
        //     {9, 7, 1, 4},
        //     {2, 5, 3, 8}
        // };
        // Console.WriteLine(grades[2,2]);

// Drag array

        // int[] [] grades = {
        //     new int[] {5, 8, 4, 1},
        //     new int[] {9, 7, 1, 4, 0, 8, 3, 5},
        //     new int[] {2, 5, 3, 8}
        // };
        // Console.WriteLine(grades[1][6]);

        // for(int i =0; i<grades.Length; i++){
            
        //     for(int k=0; k<grades[i].Length; k++){
        //         Console.Write(grades [i] [k] + " ");
        //     }
        //     Console.WriteLine();
        // }

// throw DAMENTIONAL ARRAY
        // int[,]grades = {
        //     {5, 8, 4, 1},
        //     {9, 7, 1, 4},
        //     {2, 5, 3, 8}
        // };
        // Console.WriteLine(grades.GetLength(0));
        // Console.WriteLine(grades.GetLength(1));

        // for(int i =0; i<grades.GetLength(0); i++){
            
        //     for(int k=0; k<grades.GetLength(1); k++){
        //         Console.Write(grades [i, k] + " ");
        //     }
        //     Console.WriteLine();
        // }

// LIST

        // List<int> grades = new List<int>() {5, 10};
        // grades.Add(30);
        // grades.Insert(2, 15);
        // grades.Remove(10);
        // Console.WriteLine(grades[0]);
        
        // List<int> grades = new List<int>() {5, 10, 26, 34, 2, 23, 200};
        // if(grades.Contains(2))
        // if(grades.IndexOf(2) == 4)
        // {
            // Console.WriteLine($"Found");
            // Console.WriteLine($"true");
            
        // }

        // how to check if two list are equal

        // List<int> grades1 = new List<int>() {5, 10, 26, 34, 2, 23, 200};
        // List<int> grades2 = new List<int>() {5, 10, 26, 34, 2, 23, 200};
        // if(grades1.SequenceEqual(grades2))
        // {
        //     Console.WriteLine($"Equal!");
            
        // }

        // how to literate through a list using for loop

        // List<int> grades = new List<int>() {5, 26, 10, 26, 34, 2, 23, 26, 200};
        // for(int i=0; i<grades.Count; i++)
        // {
        //     grades[i] *=2;
        //     System.Console.WriteLine(grades[i]);
        // }

        // using foreach loop

        // List<int> grades = new List<int>() {5, 26, 10, 26, 34, 2, 23, 26, 200};
        // foreach (int grade in grades)
        // {
        //     System.Console.WriteLine(grade);
        // }
//  working with list of list 
        // List<List<int>> studentGrades = new List<List<int>>() 
        // {
        //     new List<int>{5, 26, 10, 26}, 
        //     new List<int>{34, 2, 23, 26, 200},
        //     new List<int>{5, 8, 6, 11, 40}
        // };
        // foreach (List<int> grades in studentGrades.ToArray())
        // {
        //     foreach (int grade in grades)
        //     {
        //         Console.Write(grade + "\t");
        //     }
        //         Console.WriteLine();
        // }

// working wit dragnet arrary
        // int [] [] studentGrades = 
        // {
        //     new int[]{5, 26, 10, 26}, 
        //     new int[]{34, 2, 23, 26, 200},
        //     new int[]{5, 8, 6, 11, 40}
        // };
        // foreach (int[] grades in studentGrades.ToArray())
        // {
        //     foreach (int grade in grades)
        //     {
        //         Console.Write(grade + "\t");
        //     }
        //         Console.WriteLine();
        // }

        // List<int> stuff = new List<int>() { 5 };
        // int[] myArr = stuff.ToArray();
        // int [] [] studentGrades = 
        // {
        //     new int[]{5, 26, 10, 26}, 
        //     new int[]{34, 2, 23, 26, 200},
        //     new int[]{5, 8, 6, 11, 40}
        // };
        // List<int> myList = studentGrades[0].ToList();

        // foreach (int[] grades in studentGrades.ToArray())
        // {
        //     foreach (int grade in grades)
        //     {
        //         Console.Write(grade + "\t");
        //     }
        //         Console.WriteLine();
        // }

// Array sort and reverse
        // List<int> stuff = new List<int>() { 5, 60, 3, 50 };
        // stuff.Sort();
        // stuff.Reverse();

        // foreach(int s in stuff)
        // {
        //     Console.WriteLine(s);
        // }


            // Console.WriteLine("Enter day");
            // int day = Convert.ToInt32(Console.ReadLine());
            // switch (day)
            // {
            //     case 1:
            //     Console.WriteLine("monday");
            //     break;
            //     case 2:
            //     Console.WriteLine("tuesday");
            //     break;
            //     case 3:
            //     Console.WriteLine("wednessday");
            //     break;
            //     case 4:
            //     Console.WriteLine("thursday");
            //     break;
            //     default:
            //     Console.WriteLine("weekend");
            //     break;
            // }


        // User myUser = new User();
        // myUser.FirstName = "Austine";
        // myUser.LastName = "Ugbodaga";
        // myUser.Output(5);
        // Console.Write(myUser.Output(5));

        // Name myName = new Name();
        // // myName.fullName = "Austine";
        // myName._firstName = "Austine";
        // myName._lastName = "Ugbodaga";
        // // Console.WriteLine(myName.fullName);

        // Name userName = new Name();
        // // myName.fullName = "Austine";
        // userName._firstName = "John";
        // userName._lastName = "Okoduwa";

        // List<Name> names = new List<Name>();
        // names.Add(myName); names.Add(userName);
        // foreach(Name name in names)
        // {
        //         Console.WriteLine(name.fullName);
        // }
       

        // List<string> firstName = new List<string>(){"Austine", "John", "Mike", "Tim"};
        // List<string> lastName = new List<string>(){"Ugbodaga", "Okoduwa", "Adebayo", "salami"};

        // List<Name> names = new List<Name>();

        // for(int i=0; i<firstName.Count; i++)
        // {
        //     Name name = new Name();
        //     name.FirstName = firstName[i];    
        //     name.LastName = lastName[i];  
        //     names.Add(name);  
        // }

        // foreach(Name nam in names)
        // {
        //       Console.WriteLine(nam.fullName);  
        // }

        
        // TakeUser(names[0]);
        
        
        // MyMethod("Austine", 20);
        // MyMethod("Mike", 30);
        // MyMethod("john", 40);
         
    

    }
        //  public void TakeUser(Name name)
        // {
        //         Console.WriteLine(name.fullName);
        // }
        // static void MyMethod(){
        //     Console.WriteLine("my is austine");
        // }
        // static void MyMethod(string fname){
        //     Console.WriteLine($"{fname} Ugbodaga");
        // }
        // static void MyMethod(string fname, int age){
        //     Console.WriteLine($"{fname} Ugbodaga is {age} years old.");
        // }


}
