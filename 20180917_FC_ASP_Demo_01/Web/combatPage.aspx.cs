using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20180917_FC_ASP_Demo_01.Web
{
    public partial class combatPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod]
        public static void startGame()
        {
            _user = new User(50, 3, 6, 0, 0, "User_1");
            _enemy = new Bot(50, 3, 6, 0, 0, "Bot_1");
        }


        [System.Web.Services.WebMethod]
        public static string round(string hit, string block)
        {
            MainGame mg = new MainGame();
            mg.StartGame(hit, block, ref _user, ref _enemy, out jsonResult);
            return jsonResult;
        }


        //HttpContext.Current.Session["hpUser"] = sesHpUser;



        static User _user;
        static Bot _enemy;
        static string jsonResult;
    }
}