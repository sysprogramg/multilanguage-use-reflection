using System;

namespace CultureResources
{
    public class Idioma
    {
        #region Singleton
        private Idioma() { }
        private static Idioma _instance;
        public static Idioma getInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Idioma();
                }
                return _instance;
            }
        }
        #endregion

        #region Propiedades
        public string Aceptar
        {
            get
            {
                return StringResources.Aceptar;
            }
        }
        public string Cancelar
        {
            get
            {
                return StringResources.Cancelar;
            }
        }
        public string ErrorInesperado
        {
            get
            {
                return StringResources.ErrorInesperado;
            }
        }
        public string ErrorLogin
        {
            get
            {
                return StringResources.ErrorLogin;
            }
        }
        public string Login
        {
            get
            {
                return StringResources.Login;
            }
        }
        public string Password
        {
            get
            {
                return StringResources.Password;
            }
        }
        public string Usuario
        {
            get
            {
                return StringResources.Usuario;
            }
        }
        #endregion

        #region Metodos
        public string GetValueProperty(string name)
        {
            try
            {
                return GetType().GetProperty(name).GetValue(this, null).ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
