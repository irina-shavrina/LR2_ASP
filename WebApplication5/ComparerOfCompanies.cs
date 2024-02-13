
using System.Collections;

namespace WebApplication5
{
    public class ComparerOfCompanies
    {
        private readonly IConfiguration _configuration;

        public ComparerOfCompanies(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetCompanyWithMoreEmployees()
        {
            int microsoftEmployees = _configuration.GetValue<int>("Microsoft:Employees");
            int appleEmployees = _configuration.GetValue<int>("Apple:Employees");
            int googleEmployees = _configuration.GetValue<int>("Google:Employees");
            

            if (microsoftEmployees>= appleEmployees && microsoftEmployees >= googleEmployees) {
                return "Most employees in Microsoft";
            }
            if (appleEmployees >= googleEmployees)
            {
                return "Most employees in Apple";
            }
            return "Most employees in Google";
        }
    }
}