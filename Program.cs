//// See https://aka.ms/new-console-template for more information
//using System.Linq;
//1----------------------------------------------------------------------------------------------------------

//Console.WriteLine("Hello, Welcome to EXP AirLines");
//var passenger = new string[5];
//Console.WriteLine("Enter passenger's name: ");
//for (var i = 0; i < passenger.Length; i++)
//{
//    passenger[i] = Console.ReadLine();
//}




////1.a

//Console.WriteLine();
//string temp = " ";
//for (int i = 0; i < passenger.Length; i++)
//{
//    for (int j = i + 1; j < passenger.Length; j++)
//    {
//        if (passenger[i][0] > passenger[j][0])
//        {
//            temp = passenger[j];
//            passenger[j] = passenger[i];
//            passenger[i] = temp;
//        }
//    }
//}
//Console.WriteLine("Ascending order:");
//for (int i = 0; i < passenger.Length; i++)
//{
//    Console.WriteLine(passenger[i]);
//}

//Console.WriteLine();

////1.b

//Console.WriteLine();
//string temp1 = " ";
//for (int i = 0; i < passenger.Length; i++)
//{
//    for (int j = i + 1; j < passenger.Length; j++)
//    {
//        if (passenger[i][0] < passenger[j][0])
//        {
//            temp = passenger[j];
//            passenger[j] = passenger[i];
//            passenger[i] = temp;
//        }
//    }
//}
//Console.WriteLine("Descending order:");
//for (int i = 0; i < passenger.Length; i++)
//    Console.WriteLine(passenger[i]);



//for (int i = 0; i < passenger.Length; i++)
//{
//    for (int j = i + 1; j < passenger.Length; j++)
//    {
//        if (passenger[i] == passenger[j])
//            Console.WriteLine($"Duplicate elements in given array is  {passenger[i]} ");
//        else
//        {
//            Console.WriteLine("NO Duplicates entry");
//            break;
//        }
//    }
//}

//12---------------------------------------------------------------------------------------------------------

//using System;

//var passengername = new string[5];
//Console.WriteLine("Enter passenger's name: ");
//for (var i = 0; i < passengername.Length; i++)
//{
//    passengername[i] = Console.ReadLine();
//}
//var passengerdestiny = new string[5];
//Console.WriteLine("Enter passenger's Destination: ");
//for (var i = 0; i < passengerdestiny.Length; i++)
//{
//    passengerdestiny[i] = Console.ReadLine();
//}


//for (var i = 0; i < passengerdestiny.Length; i++)
//{
//    Console.WriteLine(passengername[i] + ":" + passengerdestiny[i]);
//}


//15-------------------------------------------------------------------------------------------------

//int[] weight = new int[5];
//Console.WriteLine("Enter weight of Luggage: ");
//for (int i = 0; i < weight.Length; i++)
//{
//   weight[i]=int.Parse (Console.ReadLine());
//}
//foreach (int i in weight) {
//    if (i > 23)
//    {
//        Console.WriteLine(((i - 23) * 81.28));
//    }
//    else
//    {
//        Console.WriteLine("No extra charge");
//    }
//}

//16-------------------------------------------------------------------------------------------------------

//var food = new string[5];
//Console.WriteLine("Enter veg or Non-veg: ");
//for (var i = 0; i < food.Length; i++)
//{
//    food[i] = Console.ReadLine();
//}
//var preferences = new string[5];
//Console.WriteLine("Enter food preference: ");
//for (var i = 0; i < preferences.Length; i++)
//{
//    preferences[i] = Console.ReadLine();
//}
//for (var i = 0; i < preferences.Length; i++)
//{
//    Console.WriteLine(food[i] + ":" + preferences[i]);
//}

//int[] seatpreferences = new int[5];

//for (int i = 0; i < 5; i++)
//{

//    Console.WriteLine($"Enter  seat preferences of passenger "+(i+1)+" (5*5 seatings): ");
//    int a;
//    a = int.Parse(Console.ReadLine());
//    if (a > 26)
//    {
//        Console.WriteLine("invalid seat");
//       continue;
//    }
//    else
//    {
//        seatpreferences[i] = a;
       
//        continue;
//    }
//    seatpreferences[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Preferred seats:");
//for (int i = 0; i < seatpreferences.Length; i++)
//{
//    Console.WriteLine(seatpreferences[i]);
//}

//Console.WriteLine();









