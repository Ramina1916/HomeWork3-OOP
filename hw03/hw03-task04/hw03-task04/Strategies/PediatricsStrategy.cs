namespace hw03_task04.Strategies
{
    public class PediatricsStrategy : IDiagnoseStrategy
    {
        // اطفال
        public string Diagnose(string symptoms) => $"Diagnosing pediatrics patient with symptoms: {symptoms}";
    }
}
