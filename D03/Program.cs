
namespace D03;

class Program
{
	static void Main(string[] args)
	{
		#region Casting Built in Value Types
		//int x = 50;
		//long y = 5000;

		////y = x;
		///// Implicit Casting 
		///// Int64 = Int32
		///// Safe Casting , No RunTime Errors
		//y = long.MaxValue;
		//x = (int) y;
  //      ///Int32 = Int64
  //      ///UnSafe Casting
  //      ///Explicit Casting
  //      ///Default behavior for CLR , will not Throw OverflowExceprion when overflow happens
		

		/////CLR will throw OverFlowException
		//checked
		//{
		//	x = (int)y;
		//}


  //      Console.WriteLine($"X = {x}");
		//Console.WriteLine($"y = {y}");

	#endregion

		int x = 5;
		int y = 10;
		object O1 = new object();
		object O2 = new object();
		O1 = x;
		///Base Ref = Child
		///Safe
		///Boxing

		y =(int) O2;
		///Derived = Base
		///UnSafe , Explicite
		///UnBoxing

	}

}