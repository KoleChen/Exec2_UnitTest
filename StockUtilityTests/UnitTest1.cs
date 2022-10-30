using Stock.Utility;

namespace StockUtilityTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase("2022/10/31 13:05",true)]
		[TestCase("2022/11/1 13:05", true)]
		[TestCase("2022/11/2 13:05", true)]
		[TestCase("2022/11/3 13:05", true)]
		[TestCase("2022/11/4 13:05", true)]
		public void Test1_�g�@��g��(DateTime dt,bool excepted)
		{
			var obj = new TaiwainStockUtility();
			bool test = obj.IsTradingTime(dt);

			Assert.AreEqual(excepted, test);
		}

		[TestCase("2022/10/31 13:45", false)]
		[TestCase("2022/11/1 13:45", false)]
		[TestCase("2022/11/2 13:45", false)]
		[TestCase("2022/11/3 13:45", false)]
		[TestCase("2022/11/4 13:45", false)]
		public void Test2_�g�@��g�����ɶ��~(DateTime dt, bool excepted)
		{
			var obj = new TaiwainStockUtility();
			bool test = obj.IsTradingTime(dt);

			Assert.AreEqual(excepted, test);
		}

		[TestCase("2022/11/5 13:05", false)]
		[TestCase("2022/11/6 13:05", false)]
		public void Test3_�g�����ɶ���(DateTime dt, bool excepted)
		{
			var obj = new TaiwainStockUtility();
			bool test = obj.IsTradingTime(dt);

			Assert.AreEqual(excepted, test);
		}

		[TestCase("2022/11/5 13:45", false)]
		[TestCase("2022/11/6 13:45", false)]
		public void Test4_�g�����ɶ��~(DateTime dt, bool excepted)
		{
			var obj = new TaiwainStockUtility();
			bool test = obj.IsTradingTime(dt);

			Assert.AreEqual(excepted, test);
		}
	}
}