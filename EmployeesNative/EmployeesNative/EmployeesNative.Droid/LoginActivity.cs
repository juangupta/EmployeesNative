using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace EmployeesNative.Droid
{
    [Activity(Label = "Employees", MainLauncher = true, Icon = "@drawable/icon")]
    public class LoginActivity : Activity

    {
        EditText editTextEmail;
        EditText editTextPassword;
        Button buttonLogin;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);
            editTextEmail = FindViewById<EditText>(Resource.Id.editTextEmail);
            editTextPassword = FindViewById<EditText>(Resource.Id.editTextPassword);
            buttonLogin = FindViewById<Button>(Resource.Id.buttonLogin);
            

            buttonLogin.Click += ButtonLogin_Click;
        }

        async void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(editTextEmail.Text))
            {
                ShowMessage("Error", "Debe ingresar un email.");
                return;
            }

            if (string.IsNullOrEmpty(editTextPassword.Text))
            {
                ShowMessage("Error", "Debe ingresar una contraseña.");
                return;
            }
            // Create your application here
        }

        void ShowMessage(string title, string message)
        {
            var builder = new AlertDialog.Builder(this);
            var alert = builder.Create();
            alert.SetTitle(title);
            alert.SetIcon(Resource.Drawable.Icon);
            alert.SetMessage(message);
            alert.SetButton("Acceptar", (s, ev) => { });
            alert.Show();
        }
    }
}