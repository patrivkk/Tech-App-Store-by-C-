using System;
namespace Persistence{
    public class AppsTrial{
        public string AppTrialId{set;get;}

        public string AppTrialName{set;get;}
        public string AppTrialType{set;get;}
        public DateTime AppTrialDateDebut{set;get;}
        public string AppTrialPaidOrFree{set;get;}
        public string AppTrialVersion{set;get;}
        public AppsTrial(){
        AppTrialId=string.Empty;
        AppTrialName=string.Empty;
        AppTrialType=string.Empty;
         AppTrialPaidOrFree=string.Empty;
         AppTrialVersion=string.Empty;
    }
        public override bool Equals(object? obj)
        {
           if(obj is AppsTrial)
           return ((AppsTrial)obj).AppTrialId.Equals(AppTrialId);
           return false;
        }
        public override int GetHashCode()
        {
            return AppTrialId.GetHashCode();
        }
    }
    
}