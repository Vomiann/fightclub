using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Newtonsoft.Json; // Json


namespace _20180917_FC_ASP_Demo_01
{
    
    public partial class Default : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
                        
        }


        //[System.Web.Services.WebMethod]
        //public static string StartGame(string hit, string block)
        //{
        //    string jsonResult;
        //    MainGame.StartGame(hit, block, ref _user, ref _enemy, out jsonResult);
        //    return jsonResult;

        //}


        ////static User _user = new User(100, 2, 5, 0, "User");
        ////static Bot _enemy = new Bot(100, 2, 5, 0, "Angry Bot");
        [System.Web.Services.WebMethod]
        public static void StartGame(string hit, string block)
        {
            

        }




        [System.Web.Services.WebMethod]
        public static string JsonTest(string hit, string block)
        {
            
            JsonDataPlayers data = new JsonDataPlayers() { hpUser = 10, hpBot = 10, log="Test", end = false, winner = string.Empty };

            string jsonData = JsonConvert.SerializeObject(data);
            return jsonData;

        }




    }
}