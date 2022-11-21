using App1.Servicio;
using App1.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        private static PersonaServicio personaServicio;
        public static PersonaServicio PersonaServicio
        {
            get
            {
                if (personaServicio == null)
                {
                    personaServicio = new PersonaServicio();
                }
                return personaServicio;
            }
            //en dado caso que ya exista una instacia de la clase vamos a regresar el campo estatico atravez del return
            //ya con esto se podrá acceder desde caulquier lugar de la aplicación a la propiedad Personaservicio
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
