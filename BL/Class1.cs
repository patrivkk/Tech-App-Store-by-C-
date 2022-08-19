using DAL;
using Persistence;
namespace BL;

public class CustomerTrialBL
{
    private CustomerTrialDAL cdal=new CustomerTrialDAL();
    public CustomerTrial GetbyId(string customerId){
        return cdal.GetById(customerId);
    }
    public int AddCustomer(CustomerTrial customer){
        return cdal.AddCustomer(customer)?? 0;
    }
}
