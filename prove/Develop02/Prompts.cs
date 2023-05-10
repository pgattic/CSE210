using System;

namespace Develop02 {
	///<summary>
	///The responsibility of Prompts is to generate a prompt.
	///</summary>
	public class Prompts {
		string[] prompts = {
			"What was your favorite thing about today?",
			"What was your first thought when you woke up this morning?",
			"What were your goals for today?"
		};

		public string GetRandomPrompt() {
			return prompts[new Random().Next(0, prompts.Length)];
		}
	}
}
