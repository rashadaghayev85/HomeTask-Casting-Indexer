using HomeTask_Casting_Operatoroverloding_Indexer.Helpers.Responses.Constants;
using Interface_Practice.Services.Interfaces;

namespace Interface_Practice.Controllers
{
    internal class EmployeeController
    {
        EmployeeService _employeeSevice;
        public EmployeeController()
        {
            _employeeSevice = new();
        }
        public void GetAll()
        {
            var employee = _employeeSevice.GetAll();
            foreach (var employe in employee)
            {
                Console.WriteLine(employe.Name + employe.Surname + employe.Email + employe.Birthday + employe.Age);
            }

        }
        public void GetById()
        {
            int? id = 100;
            //Console.WriteLine("id daxil edin");
            //int? id = int.Parse(Console.ReadLine());

            var result = _employeeSevice.GetById(id, _employeeSevice.GetAll());
            if (result.ErrorMessage is null)
            {
                Console.WriteLine(result.Employee.Name + result.Employee.Surname);
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }




        }
        public void SearchByNameOrSurname()
        {
            Console.WriteLine(" Add Searchtext ");
            string searchText = Console.ReadLine();


            var response = _employeeSevice.SearchByNameOrSurname(_employeeSevice.GetAll(), searchText);

            if (response.Length != 0)
            {
                foreach (var employe in response)
                {
                    Console.WriteLine(employe.Name + employe.Surname);
                }

            }

            else
            {
                Console.WriteLine(EmployeeResponseMessages.NotFound);
                //Console.WriteLine("User not found");
            }
        }
    }
}
