using Stock.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec2_UnitTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime Date = DateTime.Now; //把時間設為現在
			var obj = new TaiwainStockUtility();

			bool testresult = obj.IsTradingTime(Date); //把現在時間拿去IsTradingTime裡run一次 // 並把布林值的結果設為testresult
			Console.WriteLine(testresult); //印出測試結果(testresult) 判斷今天是否為股票交易日
			
		}
	}
}
