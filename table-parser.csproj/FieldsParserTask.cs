using System.Collections.Generic;

namespace TableParser
{
	public class FieldsParserTask
	{
		// При решении этой задаче постарайтесь избежать создания методов, длиннее 10 строк.
		// Ниже есть метод ReadField — это подсказка. Найдите класс Token и изучите его.
		// Подумайте как можно использовать ReadField и Token в этой задаче.
		public static List<string> ParseLine(string line)
		{
			return new List<string> {line}; // сокращенный синтаксис для инициализации коллекции.
		}

		
		private static Token ReadField(string line, int startIndex)
		{
			return new Token(line, 0, line.Length);
		}
	}
}