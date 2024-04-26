// See https://aka.ms/new-console-template for more information
using Netcore8;


//primaryConstructor obj = new primaryConstructor(89);
//ref readonly parameter
//int num = 23;
//obj.display(ref num);

//Console.WriteLine(num);


//collection Expression:

////var a = new int[]{ 1, 2, 3, 4, 4 };

////foreach (int i in a) { 
////Console.WriteLine(i);

////}

////int [] ne = [1, 2, 3, 4, 5];
////foreach (int i in ne)
////{
////    Console.WriteLine(i);

////}
//int[] row = [7,8,9];
//int[] row2 = [10, 11, 12];
//int[] row3= [13,14,15];
////Spread Operator Used To Join The Three Arrays into One
//int[] totalRows = [..row,..row2,..row3];
//foreach (int i in totalRows) { 
//Console.WriteLine(i);
//}
//Span<char> span = ['a', 'b'];
//foreach (char i in span) {
//Console.WriteLine(i);

//}
//defalut lamda Expression
//var lamda = (int age) => { return $"My Age is {age}"; };
//Console.WriteLine(lamda(90));
//Inline Array

//var ele = new inlineArray();
//for (int i = 0; i < 5; i++)
//{

//    ele[i] = i;
//    Console.WriteLine(ele[i]);

//}


#pragma warning disable RiskyArea // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
var a = new ExperimentalAttr();
#pragma warning restore RiskyArea // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

// Inspectors
example obj= new example();
obj.method2("Joey");
obj.method1();
