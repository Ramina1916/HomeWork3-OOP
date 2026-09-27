namespace hw03_task04.Strategies
{
    public class PsychiatryStrategy : IDiagnoseStrategy
    {
        // روانپزشکی
        public string Diagnose(string symptoms) => $"Diagnosing psychiatry patient with symptoms: {symptoms}";
    }
}
