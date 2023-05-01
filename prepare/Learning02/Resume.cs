using System;
using System.Collections.Generic;

namespace Learning02  {

	public class Resume {
		public string _name;
		public List<Job> _jobs;

		public void Display() {
			Console.WriteLine($"Name: {_name}\nJobs:");
			foreach (Job j in _jobs) {
				j.Display();
			}
		}
	}
}
