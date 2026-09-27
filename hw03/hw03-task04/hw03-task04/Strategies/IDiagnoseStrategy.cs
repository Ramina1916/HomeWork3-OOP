namespace hw03_task04.Strategies
{
    // implementation of Strategy pattern for diagnosing patients
    public interface IDiagnoseStrategy
    {
        string Diagnose(string symptoms); // return string because we want to add it to the patient's medical history
    }
}
