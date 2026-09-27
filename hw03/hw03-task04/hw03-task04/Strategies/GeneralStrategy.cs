namespace hw03_task04.Strategies
{
    public class GeneralStrategy : IDiagnoseStrategy
    {
        // عمومی
        public string Diagnose(string symptoms) => $"Diagnosing general patient with symptoms: {symptoms}";
    }
}
