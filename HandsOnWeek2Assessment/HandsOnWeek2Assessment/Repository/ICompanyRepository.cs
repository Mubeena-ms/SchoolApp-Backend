using HandsOnWeek2Assessment.Model;

namespace HandsOnWeek2Assessment.Repository
{
    public interface ICompanyRepository
    {      
        void AddCompany(Company company);
        List<Company> GetAllCompany();
        List<Company> GetCompanyByCity(string city);
        Company GetCompanyById(int companyId);
        void DeleteCompany(int companyId);  
    }
}
