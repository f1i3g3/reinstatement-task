using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public static class Checker
    {
        public static bool CheckForSymmetry(string filePath)
        {
            FileList? list = Load(filePath);

			if (list == null)
			{
				Console.WriteLine("Some error has happened earlier.");
				return false;
			}

			return list.IsSymmetrical();
        }

        private static FileList? Load(string filePath)
        {
			FileList? list = new();
			try
			{
				string[] lines = File.ReadAllLines(filePath);

				if (lines.Length == 0)
				{
					return null;
				}

				foreach (string line in lines)
				{
					string[] numbers = line.Split(new char[] { ' ', '\t' },
											StringSplitOptions.RemoveEmptyEntries);

					foreach (string numberStr in numbers)
					{
						if (int.TryParse(numberStr, out int number))
						{
							list.Add(number);
						}
					}
				}

				return list;
			}
			catch
			{
				list = null;
			}
			finally
			{
				
			}

			return list;
		}


    }
}
