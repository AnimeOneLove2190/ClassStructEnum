using System;

namespace TemporaryXyita
{
    class Program
    {
        static void Main(string[] args)
        {
            Company CompanyOne = new Company();
            CompanyOne.name = "Want2Learn";
            CompanyOne.description = "Young";
            CompanyOne.numbers = 34;
            Company CompanyTwo = new Company();
            CompanyTwo.name = "Want2Learn";
            CompanyTwo.description = "Large";
            CompanyTwo.numbers = 567;
            Company CompanyThree = new Company();
            CompanyThree.name = "Want2Learn";
            CompanyThree.description = "Conservative";
            CompanyThree.numbers = 5493857;
            Company CompanyFour = new Company();
            CompanyFour.name = "Want2Learn";
            CompanyFour.description = "Я хуй знает чо писать";
            CompanyFour.numbers = 1;
            double resultNumbers = 0;
            double resultCompanies = 0;
            if (CompanyOne.name == "Want2Learn")
            {
                resultCompanies = resultCompanies + 1;
                resultNumbers = resultNumbers + CompanyOne.numbers;
            }
            if (CompanyTwo.name == "Want2Learn")
            {
                resultCompanies = resultCompanies + 1;
                resultNumbers = resultNumbers + CompanyTwo.numbers;
            }
            if (CompanyThree.name == "Want2Learn")
            {
                resultCompanies = resultCompanies + 1;
                resultNumbers = resultNumbers + CompanyThree.numbers;
            }
            if (CompanyFour.name == "Want2Learn")
            {
                resultCompanies = resultCompanies + 1;
                resultNumbers = resultNumbers + CompanyFour.numbers;
            }
            double resultXyi = resultNumbers / resultCompanies;
            Console.WriteLine($"{resultXyi}");
        }
    }
}
