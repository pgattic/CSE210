
namespace Develop03 {
    public class Word {
        string _text;
        bool _hidden = false;

        public Word(string text) {
            _text = text;
        }

        public string getConditionalWord() {
            /* Returns a ___ the length of the word if it is supposed to be hidden, else the unmodified word */
            if (_hidden) {
                string val;
                for (val = ""; val.Length < _text.Length; val += "_") {} // what the frick
                return val;
            } else {
                return _text;
            }
        }

        public void setHidden() {
            _hidden = true;
        }
    }
}

