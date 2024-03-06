using HomeTask_Casting_Operatoroverloding_Indexer;
using Interface_Practice.Controllers;

EmployeeController emplooye = new EmployeeController();
//emplooye.GetById();
//emplooye.SearchByNameOrSurname();

//boxing
//int a = 5;
//object b = a;
//////////////
//unboxing 
//int a = 6;
//object b = a;
//int c =(int) b;//fix etmek ucun (type) yazilir
////////////
///////inplicite
//byte num = 50;
//int num2 = num;
//////////


//explicite
//int a = 10000000;
//byte b =(byte) a;
//Console.WriteLine(b);
//////////////


//upcasting
Fish fish = new Fish();
Animal animal1 = fish;
Animal animal2 = new Animal();

//downcasting
//Fish fish1 =(Fish) animal2;


//Animal animal3 = new Dog();

//Animal animal4 = new Fish();
//Animal animal = new();
////Fish fish1 = (Fish)animal;
//Dog dog=new Dog();

////object[] datas = { 1, 22, true, "salam" };

//object[] animals = {animal1, animal3, animal4,dog,"name"};
//foreach (var item in animals)
//{
//   if(item is Animal a)
//    {
//        a.Name = "Toplan";
//        Console.WriteLine(a.Name);

//        //((Animal)item).Name = "Toplan";

//        //Console.WriteLine(((Animal)item).Name);
//        //  var result = (Animal)item;
//        //Console.WriteLine("yes");
//    }
//    //Console.WriteLine(item is Dog);
//}

//DataList dataList = new DataList();
//dataList[0] = "salam";
//dataList[1] = "sagol";
//Console.WriteLine(dataList[0]);

Player player1 = new Player();
player1.Id = 1;
player1.Age = 25;
Player player2 = new Player();
player1.Id = 2;
player1.Age = 35;
Console.WriteLine(player1>player2);



