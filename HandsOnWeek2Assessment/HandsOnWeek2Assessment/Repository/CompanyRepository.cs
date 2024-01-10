using HandsOnWeek2Assessment.Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace HandsOnWeek2Assessment.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        public List<Company> Companys = new List<Company>();
        public void AddCompany(Company company)
        {
            try
            {
                Companys.Add(company);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteCompany(int companyId)
        {
            try
            {
                foreach (var item in Companys)
                {
                    if (item.companyId == companyId) 
                    {
                        Companys.Remove(item);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Company> GetAllCompany()
        {
            try
            {
                return Companys;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Company> GetCompanyByCity(string city)
        {
            try
            {
                List<Company> list = new List<Company>();
                foreach (var item in Companys)
                {
                    if (item.city == city)
                        list.Add(item);
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Company GetCompanyById(int id)
        {
            try
            {
                foreach (var item in Companys)
                {
                    if (item.companyId==id)
                        return item;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
