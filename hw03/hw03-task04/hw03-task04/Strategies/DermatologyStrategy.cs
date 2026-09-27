namespace hw03_task04.Strategies
{
    public class DermatologyStrategy : IDiagnoseStrategy
    {
        // پوست و مو
        public string Diagnose(string symptoms) => $"Diagnosing dermatology patient with symptoms: {symptoms}";
    }
}
