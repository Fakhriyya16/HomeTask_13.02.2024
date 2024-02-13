//void ShowText()
//{
//    Console.WriteLine("Hello World");
//}
//ShowText();






//void Sum()
//{
//    int a = 10;
//    int b = 20;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}
//Sum();






//int SumOfNumbers()
//{
//    int a = 10;
//    int b = 20;
//    int sum = a + b;
//    return sum;
//}

//Console.WriteLine(SumOfNumbers());

//int result = SumOfNumbers();
//Console.WriteLine(result);






//void SumOfEvenNumbers()
//{
//    int[] elems = { 1, 2, 3, 4, 5, 6, 7, 8 };

//    int sum = 0;

//    foreach (var item in elems)
//    {
//        if(item%2 == 0)
//        {
//             sum+= item;
//        }
//    }

//    Console.WriteLine(sum);
//}

//SumOfEvenNumbers();






//void ShowText(string text)
//{
//    Console.WriteLine(text);
//}

//bool isWord = false;

//if (isWord)
//{
//    ShowText("salam");
//}
//else
//{
//    ShowText("Azerbaijan");
//}






//void Sum(int num1 , int num2)
//{
//    int sum = num1 + num2;
//    Console.WriteLine(sum);
//}

//Sum(100, 200);







//void SumOfEvenNumbers(int[] elems, int number)
//{
//    int sum = 0;

//    foreach (var elem in elems)
//    {
//        if(elem%2 == 0)
//        {
//            sum += elem;
//        }
//    }
//    int result = sum + number;
//    Console.WriteLine(result);
//}

//int[] nums = { 1, 2, 4, 6, 7, 52 };

//SumOfEvenNumbers(nums,10);






//Console.WriteLine("Add your name:");

//string name = Console.ReadLine();

//Console.WriteLine("Add your surname:");

//string surname = Console.ReadLine();

//Console.WriteLine(name+"-"+surname);








//Console.WriteLine("Add first number:");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Add second number:");
//int num2 = int.Parse(Console.ReadLine());

//int result = num1 + num2;

//Console.WriteLine(result);






//int GetDatas(int num1,int num2, params int[] nums)
//{
//    int sumNumbers = num1 + num2;
//    int sumOfArrayItems = 0;

//    foreach (var item in nums)
//    {
//        sumOfArrayItems += item;
//    }

//    int result = sumNumbers + sumOfArrayItems;

//    return result;
//}

//var result = GetDatas(1,2,3,4,5,6);

//Console.WriteLine(result);







//string GetName(string name = "XXX")
//{
//    return name;
//}

//Name:  string name = Console.ReadLine();

//if(name == "")
//{
//    Console.WriteLine(GetName());
//    goto Name;
//}
//else
//{
//    Console.WriteLine(GetName(name));
//}







//string Login(string username, string password)
//{
//    if(username == "Cavid123" && password == "cavid123_")
//    {
//        return "Login successful";
//    }
//    else
//    {
//        return "Username or password is wrong";
//    }
//}

//Username: Console.WriteLine("Username:");
//string username = Console.ReadLine();

//Console.WriteLine("Password:");
//string password = Console.ReadLine();

//if(!isValid(username,password))
//{
//    Console.WriteLine("Inputs cannot be empty, add username again");
//    goto Username;
//}

//string result = Login(username, password);
//Console.WriteLine(result);

//bool isValid(string username,string password)
//{
//    if(username == "" || password == "")
//    {
//        return false;
//    }
//    return true;
//}




