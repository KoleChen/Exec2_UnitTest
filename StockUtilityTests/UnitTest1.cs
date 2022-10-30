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
		public void Test1_週一到週五(DateTime dt,bool excepted)
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
		public void Test2_週一到週五的時間外(DateTime dt, bool excepted)
		{
			var obj = new TaiwainStockUtility();
			bool test = obj.IsTradingTime(dt);

			Assert.AreEqual(excepted, test);
		}

		[TestCase("2022/11/5 13:05", false)]
		[TestCase("2022/11/6 13:05", false)]
		public void Test3_週末的時間內(DateTime dt, bool excepted)
		{
			var obj = new TaiwainStockUtility();
			bool test = obj.IsTradingTime(dt);

			Assert.AreEqual(excepted, test);
		}

		[TestCase("2022/11/5 13:45", false)]
		[TestCase("2022/11/6 13:45", false)]
		public void Test4_週末的時間外(DateTime dt, bool excepted)
		{
			var obj = new TaiwainStockUtility();
			bool test = obj.IsTradingTime(dt);

			Assert.AreEqual(excepted, test);
		}
	}
}