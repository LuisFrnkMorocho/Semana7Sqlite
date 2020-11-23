using Semana7Sqlite.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana7Sqlite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private SQLiteAsyncConnection _conn;

        public Registro()
        {
            InitializeComponent();
            _conn = DependencyService.Get<DataBase>().GetConnection(); // inicializo la variable
        }

        private void btn_agregar_Clicked(object sender, EventArgs e)
        {
            var DatosRegistro = new Estudiante { Nombre = Nombre.Text, Usuario = Usuario.Text, Contrasenia = Contrasenia.Text };
            _conn.InsertAsync(DatosRegistro);
            limpiarFormulario();
        }

        void limpiarFormulario() // creamos el metodo
        {
            Nombre.Text = "";
            Usuario.Text = "";
            Contrasenia.Text = "";
            DisplayAlert("Alerta", "Se agrego correctamente","OK");
        }
    }
}