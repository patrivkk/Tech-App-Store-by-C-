using System;
namespace Persistence
{
    // public static class AppStatus
    // {
    //     public const int NOT_ACTIVE = 0;
    //     public const int ACTIVE = 1;
    // }
    public class App
    {
        public string AppId { set; get; }
        public string AppName { set; get; }
        public string AppVersion { set; get; }
        public DateOnly AppDateDebut { set; get; }
        public string AppType { set; get; }
        public Double AppPrice { set; get; }
        public App()
        {
            AppId = string.Empty;
            AppName = string.Empty;
            AppVersion = string.Empty;
            AppType = string.Empty;


        }
        public override bool Equals(object? obj)
        {
            if (obj is App)
                return ((App)obj).AppId.Equals(AppId);
            return false;
        }
        public override int GetHashCode()
        {
            return AppId.GetHashCode();
        }
    }
}