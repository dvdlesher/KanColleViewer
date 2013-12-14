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
                    return "M. Adm. ";//"元帥";
                case 2:
                    return "Adm. ";//"大将";
                case 3:
                    return "V. Adm. ";//"中将";
                case 4:
                    return "R. Adm. ";//"少将";
                case 5:
                    return "Cpt. ";//"大佐";
                case 6:
                    return "Cmd. ";//"中佐";
                case 7:
                    return "R. Cmd. ";//"新米中佐";
                case 8:
                    return "Ltn. Cmd. ";//"少佐";
                case 9:
                    return "M. Ltn. ";//"中堅少佐";
                case 10:
                default:
                    return "R. Ltn. ";//"新米少佐";
			}
		}
	}
}
