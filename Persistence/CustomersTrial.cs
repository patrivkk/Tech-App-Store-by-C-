using System;
namespace Persistence
{
    public class CustomerTrial{
        public string CustomerTrialId{set;get;}
        public string CustomerTrialName{set;get;}
        public string CustomerTrialEmail{set;get;}
        public DateTime CustomerTrialBirthDate {set;get;}
        public string IdApp{set;get;}
        public string CustomerTrialGender{set;get;}
        public DateTime CustomerTrialSubDate{set;get;}
        public string CustomerAddress{set;get;}
        public CustomerTrial(){
            CustomerTrialId=string.Empty;
            CustomerTrialName=string.Empty;
            CustomerTrialEmail=string.Empty;
            CustomerTrialGender=string.Empty;
            IdApp=string.Empty;
            CustomerAddress=string.Empty;
        }
        public override bool Equals(object obj)
        {
            if(obj is CustomerTrial)
            return ((CustomerTrial)obj).CustomerTrialId.Equals(CustomerTrialId);
           return false; 
        }
        public override int GetHashCode()
        {
            return CustomerTrialId.GetHashCode();
        }

    }
}