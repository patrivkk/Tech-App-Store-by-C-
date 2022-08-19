using System;
namespace Persistence
{
    public class Customer
    {
        public string CustomerId { set; get; }
        public string CustomerName { set; get; }
        public string CustomerGender { set; get; }
        public DateTime CustomerBirthDate { set; get; }
        public double? CustomerCardId { set; get; }
        public double? CustomerPhoneNumber { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerEmail{set;get;}
        public string IdApp{set;get;}
        public Customer(){
            CustomerId=string.Empty;
            CustomerName=string.Empty;
            CustomerGender=string.Empty;
            CustomerAddress=string.Empty;
            IdApp=string.Empty;
            CustomerEmail=string.Empty;
        }
        public override bool Equals(object obj)
        {
            if (obj is Customer)
               return ((Customer)obj).CustomerId.Equals(CustomerId);        
            return false;
        }
        public override int GetHashCode()
        {
            return CustomerId.GetHashCode();
        }
    }
}
