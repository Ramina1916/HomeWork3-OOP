using hw03_task04.Strategies;
namespace hw03_task04.Factories
{
    // implementation of factory pattern for creating doctors with different specializations automatically
    public static class DoctorFactory
    {
        public static Doctor Create(string name, int age, string nationalId, int doctorId, string specialization)
        {
            IDiagnoseStrategy strategy = specialization.Trim().ToLower() switch
            {
                "cardiology" => new CardiologyStrategy(),
                "neurology" => new NeurologyStrategy(),
                "pediatrics" => new PediatricsStrategy(),
                "dermatology" => new DermatologyStrategy(),
                "psychiatry" => new PsychiatryStrategy(),
                _ => new GeneralStrategy()
            };
            return new Doctor(name, age, nationalId, doctorId, specialization,strategy);
        }
    }
}
