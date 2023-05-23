
namespace Develop03 {
    public class Word {
        string _text;
        bool _hidden;


        public Word(string text) {
            this._text = text;
            this._hidden = false;
        }


        public string getConditionalWord() {
            if (this._hidden) {
                string val = "";
                while (val.Length < this._text.Length) {
                    val += "_";
                }
                return val;
            } else {
                return this._text;
            }
        }

        public string getWord() {
            return _text;
        }

        public void setHidden(bool val = true) {
            this._hidden = val;
        }
    }
}

