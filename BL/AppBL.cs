using DAL;
using Persistence;
namespace BL;
public class AppBL{
    private AppsDAL cdal=new AppsDAL();
    public App GetById(string idApp){
        return cdal.GetById(idApp);
    }
    public int AddApp(App app){
        return cdal.AddApp(app)?? 0 ;
    }
    public List<App> GetAllApps(){
        return cdal.GetAllApps();
    }
}