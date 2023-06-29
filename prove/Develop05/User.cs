using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Develop05 {

    public class User {

        List<Goal> _goals;
        string _filename;

        public User(string filename) {
            _goals = new List<Goal>();
            _filename = filename;

            if (File.Exists(_filename)) {
                ReadFromFile();
            }
        }

        public void CompleteGoal() {
            Console.WriteLine("Select the goal you wish to check off:");
            DisplayGoals();
            Console.Write("Goal: ");

            int input;
            do {
                input = Convert.ToInt32(Console.ReadLine());
            } while (!Enumerable.Range(1, _goals.Count).Contains(input));

            _goals[input - 1].Complete();
        }

        public void CreateGoal() {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");

            string input;

            do {
                Console.Write("Your Choice: ");
                input = Console.ReadLine();
            } while (!new List<String>(){"1", "2", "3"}.Contains(input));

            Console.WriteLine();
            Console.Write("Goal name: ");
            string name = Console.ReadLine().Replace("|", "").Trim();
            Console.Write("Goal Description: ");
            string description = Console.ReadLine().Replace("|", "").Trim();
            Console.Write("Points for each completion of the goal: ");
            int pointsPer = Convert.ToInt32(Console.ReadLine());

            switch (input) {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, pointsPer));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, pointsPer));
                    break;
                case "3":
                    Console.WriteLine("Times to complete the goal: ");
                    int timesToComplete = Convert.ToInt32(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, pointsPer, timesToComplete));
                    break;
            }
        }

        public void DisplayGoals() {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++) {
                Console.WriteLine($"  {i+1}. {_goals[i].GetInfo()}");
            }
            Console.WriteLine();
        }

        public int GetTotalScore() {
            return _goals.Aggregate(0, (total, current) => total + current.CalculateScore());
        }

        private void ReadFromFile() {
            foreach (string line in File.ReadLines(_filename)) {
                string[] contents = line.Split("|");
                switch (contents[0]) {
                    case "SimpleGoal:":
                                     _goals.Add(new SimpleGoal(contents[1], contents[2], Convert.ToInt32(contents[3]), !(contents[4]=="0")));
                                     break;
                    case "EternalGoal:":
                                      _goals.Add(new EternalGoal(contents[1], contents[2], Convert.ToInt32(contents[3]), Convert.ToInt32(contents[4])));
                                      break;
                    case "ChecklistGoal":
                                      _goals.Add(new ChecklistGoal(contents[1], contents[2], Convert.ToInt32(contents[3]), Convert.ToInt32(contents[4]), Convert.ToInt32(contents[5])));
                                      break;
                }
            }
        }

        public void WriteToFile() {
            using (StreamWriter sw = File.CreateText(_filename)) {
                foreach (Goal goal in _goals) {
                    sw.WriteLine(goal.Serialize());
                }
            }
        }
    }
}

