using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftServerLauncher
{
    class LogMsg
    {

        public static string ErrorLogMsg(string Case)
        {
            string msg = "[" + DateTimeString() + " ERROR] : {1}";
            msg = msg.Replace("{1}",Case);
            return msg;
        }

        public static string InfoLogMsg(string Case)
        {
            string msg = "["+ DateTimeString() + " INFO] : {1}";
            msg = msg.Replace("{1}", Case);
            return msg;
        }


        private static string DateTimeString()
        {
            string time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            return time;
        }







    }
}
