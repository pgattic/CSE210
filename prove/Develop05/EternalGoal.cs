
namespace Develop05 {
    public class EternalGoal: Goal {
        int _timesCompleted;

        public EternalGoal(string name, string description, int points, int timesCompleted = 0): base(name, description, points) {
            _timesCompleted = timesCompleted;
        }

        public override int CalculateScore() {
            return _timesCompleted * _pointsPer;
        }

        public override void Complete() {
            _timesCompleted++;
        }

        public override string GetInfo() {
            return $"[ ] {_name}: {_description} -- Currently completed: {_timesCompleted} time{(_timesCompleted==1?"":"s")}";
        }

        public override string Serialize() {
            return $"EternalGoal:|{_name}|{_description}|{_pointsPer}|{_timesCompleted}";
        }
    }
}
