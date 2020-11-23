using System;
using System.Collections.Generic;
using System.Text;
using SQLite; // importamos  la libreria del sqlite

namespace Semana7Sqlite
{
    public interface DataBase
    {
        // CREAMOS EL METODO ACCEDO AL PROYECTO
        SQLiteAsyncConnection GetConnection();
    }
}
