using DAL;
using Persistence;
namespace BL;
public class CustomerBL
{
  private CustomerDAL cdal=new CustomerDAL();
  public Customer GetbyId(string customerId){
    return cdal.GetById(customerId);
  }
  public int AddCustomer(Customer customer){
    return cdal.AddCustomer(customer)?? 0;
  }
}
                        