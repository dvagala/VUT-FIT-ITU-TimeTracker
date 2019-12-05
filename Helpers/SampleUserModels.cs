using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackerITU.Models;

namespace TimeTrackerITU.Helpers
{
    public class SampleUserModels : ObservableCollection<UserModel>
    {
        public SampleUserModels()
        {

            UserModel userModel = new UserModel
            {
                Login = "xdvora2u",
                Password = "heslo"
            };
            this.Add(userModel);


            userModel = new UserModel
            {
                Login = "xvagal00",
                Password = "heslo"
            };
            this.Add(userModel);

            userModel = new UserModel
            {
                Login = "xvinsj00",
                Password = "heslo"
            };
            this.Add(userModel);
        }
    }
}
