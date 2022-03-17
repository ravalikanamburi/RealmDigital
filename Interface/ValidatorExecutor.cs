namespace RealmDigital.Interface
{
    internal class ValidatorExecutor<T>
    {

        protected override bool Execute(IEmployee employee)
        {
            if (employee!.EmploymentEndDate.HasValue
                && employee!.EmploymentStartDate > DateTime.Today)
                return true;

            return false;
        }
    }
}