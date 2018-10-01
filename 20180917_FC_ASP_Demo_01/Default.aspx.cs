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


                       
        [System.Web.Services.WebMethod]
        public static void startGame()
        {
            // Добавить реализацию класса, который сгенерирует 3х игроков и 3х ботов
            // Изменить интерфейс лога

            _user = new User(10, 3, 4, 0, 0, "User_1");
            _enemy = new Bot(10, 3, 4, 0, 0, "Bot_1");            
        }


        // Метод обработки атаки и защиты
        [System.Web.Services.WebMethod]
        public static string round(string hit, string block)
        {
            MainGame mg = new MainGame();
            mg.StartGame(hit, block, ref _user, ref _enemy, out jsonResult);

            
            //HttpContext.Current.Session["hpUser"] = sesHpUser;


            return jsonResult;
        }
        




        // TODO: Тестовый метод, в финальной версии не будет
        //[System.Web.Services.WebMethod]
        //public static string JsonTest(string hit, string block)
        //{

        //    JsonDataPlayers data = new JsonDataPlayers() { hpUser = 10, hpBot = 10, log = "Test", endFight = false, winner = string.Empty };

        //    string jsonData = JsonConvert.SerializeObject(data);
        //    return jsonData;
        //}


       
        static User _user;
        static Bot _enemy;
        static string jsonResult;
    }
}