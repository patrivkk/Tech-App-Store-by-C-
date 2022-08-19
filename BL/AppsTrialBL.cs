using DAL;
using Persistence;
namespace BL;
public class AppsTrialBL{
    private AppsTrialDAL cdal=new AppsTrialDAL();
    public AppsTrial GetById(string idApp){
        return cdal.GetById(idApp);
    }
    public int AddAppsTrial(AppsTrial app){
        return cdal.AddApp(app)?? 0;
    }
}