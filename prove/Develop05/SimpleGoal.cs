namespace Develop05 {
    public class SimpleGoal: Goal {
        bool _status;

        public SimpleGoal(string name, string description, int points, bool status = false): base(name, description, points) {
            _status = status;
        }

        public override int CalculateScore() {
            return _status? _pointsPer : 0;
        }

        public override void Complete() {
            _status = true;
        }

        public override string GetInfo() {
            return $"[{(_status?"X":" ")}] {_name}: {_description}";
        }

        public override string Serialize() {
            return $"SimpleGoal:|{_name}|{_description}|{_pointsPer}|{(_status?"1":"0")}";
        }
    }
}
