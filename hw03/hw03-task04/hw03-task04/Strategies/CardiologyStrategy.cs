namespace hw03_task04.Strategies
{
    //writing one class for per specialization, but in real life we can have many more classes for different specializations
    public class CardiologyStrategy : IDiagnoseStrategy
    {
        // قلب و عروق
        public string Diagnose(string symptoms) => $"Diagnosing cardiology patient with symptoms: {symptoms}";
    }
}
