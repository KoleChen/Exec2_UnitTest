using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Utility
{
    public class TaiwainStockUtility
	{
		public bool IsTradingTime(DateTime dt)
		{
			if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)//如果傳入的日期(今天)是週六或是週日 布林值傳回false
			{
				return false;
			}
			else if (9 <= dt.Hour && dt.Hour <= 13)//如果日期(現在)的小時介於9~13的話
			{
				if (dt.Hour == 13)//如果小時是13
				{
					if (0 <= dt.Minute && dt.Minute <= 30)//分鐘介於0~30 傳回true 否則false
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else//其餘9~13小時傳回true
				{
					return true;
				}
			}
			else//除了9~13小時之外 傳回false
			{
				return false;
			}
		}
	}
}
