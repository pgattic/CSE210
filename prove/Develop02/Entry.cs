namespace Develop02 {
	///<summary>
	///The responsibility of an Entry is to record (or store) a prompt,
	///response, and date.
	///</summary>
	public class Entry {
		string date;
		string prompt;
		string response;

		public string GetAsString() {
			return $"{date}\n{prompt}\n{response}\n";
		}

		public void Store(string prompt, string response, string date) {
			this.prompt = prompt;
			this.response = response;
			this.date = date;
		}
	}
}
