using System;
using System.Threading;

namespace Develop04 {
    public abstract class Activity {

        private int _time;
        private string _startMsg;
        private string _type;
        private char[] _animationString = {
            '-',
            '\\',
            '|',
            '/',
        };

        public Activity(int time) {
            _time = time;
        }

        public char[] GetAnimationString () {
            return _animationString;
        }

        public int GetTime() {
            return _time; // seconds
        }

        public void SetStartMsg(string message) {
            _startMsg = message;
        }

        public void SetType(string type) {
            _type = type;
        }

        public void DisplayStartMsg() {
            Console.WriteLine(_startMsg);
        }

        public void DisplayEndMsg() {
            Console.WriteLine($"You have completed {_time} seconds of {_type} Activity!");
        }

        public void BeginPrep() {
            Console.WriteLine($"You have chosen the {_type} Activity.");
            Console.WriteLine("Get ready...");
            for (int i = 0; i < 5*10; i++) {
                Console.Write(_animationString[i % _animationString.Length]);
                Thread.Sleep(1000/10);
                Console.Write("\b");
            }
            Console.Clear();
        }

        public abstract void Start();
    }
}
