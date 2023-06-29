
namespace Develop05 {
    public class ChecklistGoal: Goal {
        int _timesCompleted;
        int _timesToComplete;

        public ChecklistGoal(string name, string description, int pointsPer, int timesToComplete, int timesCompleted = 0): base(name, description, pointsPer) {
            _timesCompleted = timesCompleted;
            _timesToComplete = timesToComplete;
        }

        public override int CalculateScore() {
            return _timesCompleted * _pointsPer;
        }

        public override void Complete() {
            _timesCompleted++;
        }

        public override string GetInfo() {
            return $"[{(_timesCompleted >= _timesToComplete?"X": " ")}] {_name}: {_description} -- Currently completed: {_timesCompleted}/{_timesToComplete} time{(_timesToComplete==1?"":"s")}";
        }

        public override string Serialize() {
            return $"ChecklistGoal:|{_name}|{_description}|{_pointsPer}|{_timesToComplete}|{_timesCompleted}";
        }
    }
}
