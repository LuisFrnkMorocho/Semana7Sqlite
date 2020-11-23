using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.IO;
using SQLite;
using Xamarin.Forms; // IMPLEMENTAMOS LA LIBRERIA 
using Semana7Sqlite.iOS;


[assembly:Dependency(typeof(SqliteClient))]
namespace Semana7Sqlite.iOS
{
    public class SqliteClient : DataBase { 
    
        public SQLite.SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            // //se crea la base de datos 
            var path = Path.Combine(documentsPath, "uisrael.db3");
            return new SQLiteAsyncConnection(path);
        }

    }
}