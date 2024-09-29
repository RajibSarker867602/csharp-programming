//using CSharp_Practice;

//FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
//{
//    Id = 1,
//    FirstName = "Rajib",
//    LastName = "Sarker",
//    Email = "Rajib@gmail.com",
//    YearlySalary = 50000
//};

//PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
//{
//    Id = 1,
//    FirstName = "Raju",
//    LastName = "Sarker",
//    Email = "Raju@gmail.com",
//    HourlyPay = 50,
//    TotalHour = 40
//};


//Console.WriteLine(fullTimeEmployee);
//Console.WriteLine(partTimeEmployee);

//Console.WriteLine($"Salary: {fullTimeEmployee.GetMonthlySalary()}");
//Console.WriteLine($"Salary: {partTimeEmployee.GetMonthlySalary()}");

#region reverse word

//string word = Console.ReadLine();
//string charactersInReverse = string.Join(" ",
//    word.Split(' ')
//    .Select(c =>
//    new String(c.Reverse().ToArray())));

//string wordInReverse = string.Join(" ", new String(word.Reverse().ToArray()));

//Console.WriteLine($"Characters in reverse: {charactersInReverse}");
//Console.WriteLine($"Word in reverse: {wordInReverse}");


#endregion


using CSharp_Practice;
using System.Reflection;

//Circle circle = new Circle(5);
//Console.WriteLine($"Area of the circle is: {circle.GetArea()}");


// check the default constructor access modifier
//ConstructorInfo con = typeof(Circle).GetConstructor(BindingFlags.Instance 
//    | BindingFlags.NonPublic, null, new Type[] {typeof(float)}, null);

//Console.WriteLine($"Is Public: {con.IsPublic}");
//Console.WriteLine($"Is Private: {con.IsPrivate}");
//Console.WriteLine($"Is Protected: {con.IsFamily}");


//Person aPerson = new PersonA();
//aPerson.PrintFullName();

#region destructor example
//Customer aCustomer = new Customer();
//aCustomer.ShowFullName();
//aCustomer = null;
//GC.Collect();
//GC.WaitForPendingFinalizers();

//// Creating an instance of class  
//// Complex C invokes constructor 
//Complex C = new Complex();

//// Calling SetValue method using 
//// instance C Setting values of  
//// real to 2 and img to 3 
//C.SetValue(2, 3);

//// Displaying values of real 
//// and imaginary parts 
//C.DisplayValue();

//// Instance is no longer needed 
//// Destructor will be called 

//GC.Collect();
//Console.ReadLine();

#endregion


#region struct example
//Console.WriteLine("---------------CLASS----------------------");
//Console.WriteLine("PET-------------------");
//Animal pet = new Animal("Red", 5, "Meo");
//pet.GetAnimalDetails();
//Console.WriteLine("CAT-------------------");
//Animal cat = pet;
//cat.Height = 3;
//cat.GetAnimalDetails();

//pet.GetAnimalDetails();

//Console.WriteLine("---------------Struct----------------------");

//Console.WriteLine("PET-------------------");
//AnimalStruct petStruct = new AnimalStruct("Red", 5, "Meo");
//petStruct.GetAnimalDetails();
//Console.WriteLine("CAT-------------------");
//AnimalStruct catStruct = petStruct;
//catStruct.Height = 3;
//catStruct.GetAnimalDetails();

//petStruct.GetAnimalDetails();

#endregion

#region delegate example

//List<DelegateEmployee> _employees = new List<DelegateEmployee>()
//{
//    new DelegateEmployee
//    {
//        Id = 1,
//        Name = "Rajib",
//        Salary = 20000,
//    },
//    new DelegateEmployee
//    {
//        Id = 2,
//        Name = "Raju",
//        Salary = 2000,
//    },
//    new DelegateEmployee
//    {
//        Id = 3,
//        Name = "Diman",
//        Salary = 3000,
//    },
//    new DelegateEmployee
//    {
//        Id = 4,
//        Name = "Sajib",
//        Salary = 140000,
//    }
//};
//DelegateEmployee.PromoteEmployee(_employees);
////IsPromotedDelegate isPromote = new IsPromotedDelegate(IsPromoteDelegateFunc);
//DelegateEmployee.PromoteEmployeesWithDelegate(_employees, emp => emp.Salary > 10000);

////static bool IsPromoteDelegateFunc(DelegateEmployee employee)
////    => employee.Salary > 10000;
#endregion

#region reflection example
//Type T = Type.GetType("CSharp_Practice.ReflectionClass");
//Console.WriteLine($"Full Name - {T.FullName}");
//Console.WriteLine($"Name - {T.Name}");
//Console.WriteLine($"Namespace - {T.Namespace}");

//Console.WriteLine("Properties.......................");
//// properties
//PropertyInfo[] properties = T.GetProperties();
//foreach (PropertyInfo property in properties)
//{
//    Console.WriteLine($"{property.PropertyType} - {property.Name}");
//}

//Console.WriteLine("methods.......................");
//// methods
//MethodInfo[] methods = T.GetMethods();
//foreach (MethodInfo method in methods)
//{
//    Console.WriteLine($"{method.ReturnParameter} - {method.Name}");
//}

//Console.WriteLine("fields.......................");
//// fields
//FieldInfo[] fields = T.GetFields();
//foreach (FieldInfo field in fields)
//{
//    Console.WriteLine($"{field.FieldType} - {field.Name}");
//}

//Console.WriteLine("constructors.......................");
//// constructors
//ConstructorInfo[] constructors = T.GetConstructors();
//foreach (ConstructorInfo constructor in constructors)
//{
//    Console.WriteLine($"{constructor.ToString()}");
//}

//Console.WriteLine("Late binding.......");
//Assembly currentAssembly = Assembly.GetExecutingAssembly();
//Type refType = currentAssembly.GetType("CSharp_Practice.ReflectionClass");
//object obj = Activator.CreateInstance(refType);
//MethodInfo methodInfo = obj.GetType().GetMethod("GetData");
//string[] param = new string[2];
//param[0] = "1";
//param[1] = "Rajib";
//object returnData = methodInfo.Invoke(obj, param);
//Console.WriteLine(returnData);
#endregion

#region indexer example
//IndexerClass indexerClass = new IndexerClass();
//Console.WriteLine(indexerClass[1]);
//indexerClass[1] = "Rajib Sarker";
//Console.WriteLine(indexerClass[1]);
//Console.WriteLine(indexerClass["R"]);
#endregion

#region multithreading example
//DoSomething();
Thread workerThread = new Thread(DoSomething);
workerThread.Start();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

static void DoSomething()
{
    Thread.Sleep(5000);
    Console.WriteLine("Hey wake up!!!");
}

#endregion


