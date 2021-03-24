using System;
using System.Collections.Generic;

namespace Algoritmi1
{
	class Program
	{
		static void Main(string[] args)
		{
			//ZadatakBA1C
			Console.WriteLine("Unesite proizvoljni DNA string ");
			string s = Console.ReadLine();
			string sk = "";
			for (int i = s.Length - 1; i >= 0; i--)
			{
				if (s.Substring(i, 1) == "A")
				{
					sk += "T";
				}
				else if (s.Substring(i, 1) == "T")
				{
					sk += "A";
				}
				else if (s.Substring(i, 1) == "G")
				{
					sk += "C";
				}
				else
				{
					sk += "G";
				}




			}
			Console.WriteLine("Dani inverz od DNA je:");
			Console.WriteLine(sk);

			//ZADATAK BA1D
			Console.WriteLine("Unesite pattern kojeg želite da trazimo u genomu");
			string p = Console.ReadLine();
			Console.WriteLine("Unesite proizvoljan genom");
			string g = Console.ReadLine();
			List<int> lista = new List<int>();
			for (int i = 0; i < g.Length-p.Length; i++)
			{
				if (g.Substring(i, p.Length) == p)
				{
					lista.Add(i);
				}
			}
			Console.WriteLine("Dani pattern pocinje u genomu na sljedecim pozicijama");
			
			for (int i = 0; i < lista.Count; i++)
			{
				Console.WriteLine(lista[i]+" ");
			}

		}
	}
}
