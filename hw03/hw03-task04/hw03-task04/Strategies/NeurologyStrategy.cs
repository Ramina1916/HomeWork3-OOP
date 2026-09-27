namespace hw03_task04.Strategies
{
    public class NeurologyStrategy : IDiagnoseStrategy
    {
        // مغز و اعصاب
        public string Diagnose(string symptoms) => $"Diagnosing neurology patient with symptoms: {symptoms}";
    }
}
