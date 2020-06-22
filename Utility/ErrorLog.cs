using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Utility
{
    public static class ErrorLog
    {
        private static int errorlineNo;
        private static string errormsg;
        private static string extype;
        private static string fileName;
        private static string methodsName;
        private static string errorLocation;
        private static int columnNumber;
        private static readonly string line = Environment.NewLine;

        public static string dir;

        public static void SendErrorToText(Exception ex)
        {
            //string filepath = Path.Combine(Environment.CurrentDirectory,"LOGS","Smart Gowala Logs");
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOGS");
            FindAllInformations(ex);
            try
            {
                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }
                filepath = Path.Combine(filepath, DateTime.Today.ToString("dd-MM-yy") + ".txt");   //Text File Name
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Dispose();
                }
                using var sw = File.AppendText(filepath);
                SetTheMessage(sw);
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {
                SaveOptionsInOther(e);
                e.ToString();
            }
        }

        private static void SaveOptionsInOther(Exception e)
        {
            Directory.SetCurrentDirectory(@"D:\");
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "LOGS", "SG Admin Panel Logs");
            FindAllInformations(e);
            try
            {
                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }
                filepath = Path.Combine(filepath, DateTime.Today.ToString("dd-MM-yy") + ".txt");   //Text File Name
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Dispose();
                }
                using var sw = File.AppendText(filepath);
                SetTheMessage(sw);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private static void FindAllInformations(Exception ex)
        {
            var st = new StackTrace(ex, true);
            var frame = st.GetFrame(st.FrameCount - 1);
            errorlineNo = frame.GetFileLineNumber();
            errormsg = ex.GetType().Name;
            extype = ex.GetType().ToString();
            errorLocation = ex.Message;
            fileName = frame.GetFileName();
            methodsName = frame.GetMethod().Name;
            columnNumber = frame.GetFileColumnNumber();
        }

        private static void SetTheMessage(StreamWriter sw)
        {
            string space = "  ";
            string error =
                "Log Written Date:" + space + DateTime.Now + line + line +
                "File Name       :" + space + fileName + line +
                "Methods Name    :" + space + methodsName + line +
                "Error Line No   :" + space + errorlineNo + line +
                "Coulumn Number  :" + space + columnNumber + line +
                "Error Message   :" + space + errormsg + line +
                "Exception Type  :" + space + extype + line +
                "Error Location  :" + space + errorLocation + line;

            sw.WriteLine("-----------Exception Details on " + " " + DateTime.Now + "-----------------");
            sw.WriteLine("-------------------------------------------------------------------------------------");
            sw.WriteLine(Environment.NewLine);
            sw.WriteLine(error);
            sw.WriteLine("--------------------------------*End*------------------------------------------");
            sw.WriteLine(Environment.NewLine);
        }
        /*

        public static void SaveErrorInDatabase(Exception ex)
        {
            FindAllInformations(ex);
            try
            {
                connection = new SqlConnection(connectionString);
                using (connection)
                {
                    using (cmd = new SqlCommand(sp_SaveErrorLogs, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        ;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Utility.Log.SendErrorToText(e);
                e.ToString();
            }
        }
        */

    }
}
