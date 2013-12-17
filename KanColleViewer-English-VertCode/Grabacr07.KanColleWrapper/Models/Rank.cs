using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabacr07.KanColleWrapper.Models
{
	public static class Rank
	{
		public static string GetName(int rank)
		{
			switch (rank)
			{
                case 1:
                    return "Marshal Admiral";//"元帥";
                case 2:
                    return "Admiral";//"大将";
                case 3:
                    return "Vice-Admiral";//"中将";
                case 4:
                    return "Rear-Admiral";//"少将";
                case 5:
                    return "Captain";//"大佐";
                case 6:
                    return "Commander";//"中佐";
                case 7:
                    return "Rookie Commander";//"新米中佐";
                case 8:
                    return "Lieutenant-Commander";//"少佐";
                case 9:
                    return "Mid Lieutenant";//"中堅少佐";
                case 10:
                default:
                    return "Rookie Lieutenant";//"新米少佐";
			}
		}
	}
}
