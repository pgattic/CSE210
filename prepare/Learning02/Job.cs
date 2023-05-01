using System;

namespace Learning02  {

	public class Job {
		public string _company;
		public string _title;
		public int _startYear;
		public int _endYear;

		public void Display() {
			Console.WriteLine($"{_title} ({_company}) {_startYear} - {_endYear}");
		}
	}
}
