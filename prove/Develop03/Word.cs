
namespace Develop03 {
    public class Word {
        string _text;
        bool _hidden = false;

        public Word(string text) {
            _text = text;
        }

        public string getConditionalWord() {
            return _hidden ? new string('_', _text.Length) : _text;
        }

        public void hide() {
            _hidden = true;
        }
    }
}

