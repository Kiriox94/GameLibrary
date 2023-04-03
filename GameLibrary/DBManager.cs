using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Specialized;
using System.Drawing;
using System.Xml.Linq;

namespace GameLibrary
{
    class DBManager
    {
        private static string _aplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public readonly static string _aplicationPath = Path.Combine(_aplicationDataPath, "GameLibrary");
        public static int curentDBVersion = 1;

        static SQLHelper db = new SQLHelper(Path.Combine(_aplicationPath, "data.db"));
        public static void Init()
        {
            if(!Directory.Exists(_aplicationPath)) Directory.CreateDirectory(_aplicationPath);
            if (!File.Exists(db.DBPath))
            {
                db.InvokeUpdate("create table game (foldername text primary key, executablename text, image blob)");
                db.InvokeUpdate("create table system (name text primary key, value text)");

                ListDictionary param = new ListDictionary
                {
                    { "P1", curentDBVersion }
                };

                db.InvokeUpdate("insert into system values ('version', @P1)", param);
            }
        }

        public static void SetByFolder(string folderName, string exeName, byte[] image = null)
        {
            if(image != null)
            {
                ListDictionary param = new ListDictionary
                {
                    { "P1", folderName },
                    { "P2", exeName },
                    { "P3", image }
                };

                db.InvokeUpdate("insert into game values (@P1, @P2, @P3) on conflict (foldername) do update set executablename = @P2, image = @P3", param);
            }
            else
            {
                ListDictionary param = new ListDictionary
                {
                    { "P1", folderName },
                    { "P2", exeName }
                };

                db.InvokeUpdate("insert into game (foldername, executablename) values (@P1, @P2) on conflict (foldername) do update set executablename = @P2", param);
            }
        }

        public static string GetExeByFolder(string folderName)
        {
            DataTable dt = db.InvokeQuery(string.Format("select * from game where foldername = '{0}'", folderName));
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt.Rows[0][1].ToString();
            }
        }

        public static Image GetImageByFolder(string folderName)
        {
            object blobImage = db.InvokeScalar(string.Format("select image from game where foldername = '{0}'", folderName));

            if (blobImage == DBNull.Value) return null;

            byte[] buff = (byte[])blobImage;

            MemoryStream ms = new MemoryStream();
            ms.Write(buff, 0, buff.Length);

            Image finalImage = Image.FromStream(ms);

            ms.Dispose();

            return finalImage;
        }

        public static void ResetImage(string folderName)
        {
            db.InvokeUpdate(string.Format("UPDATE game SET image = null WHERE foldername = '{0}'", folderName));
        }
    }
}
