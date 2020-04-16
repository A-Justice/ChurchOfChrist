using ShortBody.Models;
using System.Linq;

namespace ShortBody.UViewModels
{
    public class SettingsViewModel
    {

        LocalAppContext db;
        Setting setting;
        public string MaxGroupNumber { get; set; }


        public string MaxClassNumber { get; set; }

        #region Constructor

        public SettingsViewModel()
        {
            db = DashBoardViewModel.db;
            setting = db.Settings.FirstOrDefault();

            MaxGroupNumber = setting.MaxGroupNumber == int.MaxValue ? "Unlimited" : setting.MaxGroupNumber.ToString();
            MaxClassNumber = setting.MaxClassNumber == int.MaxValue ? "Unlimited" : setting.MaxClassNumber.ToString();

        }

        public void ChangeMaxGroupNumber()
        {
            int number;
            if (int.TryParse(MaxGroupNumber, out number))
            {
                setting.MaxGroupNumber = number;
            }
            else
            {
                setting.MaxGroupNumber = int.MaxValue;
            }
            db.SaveChanges();
        }

        public void ChangeMaxClassNumber()
        {
            int number;
            if (int.TryParse(MaxClassNumber, out number))
            {
                setting.MaxClassNumber = number;
            }
            else
            {
                setting.MaxClassNumber = int.MaxValue;
            }
            db.SaveChanges();
        }

        #endregion
    }
}
