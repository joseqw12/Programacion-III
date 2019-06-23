using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static Android.App.ActionBar;

namespace AndoridPila
{
    [Activity(Label = "MOSTRAR")]
    public class MOSTRAR : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ActivityListItem);

            ListView lista = FindViewById<ListView>(Resource.Id.lis);
            Button Mostrar = FindViewById<Button>(Resource.Id.);


            Pila<string> pi = new Pila<string>();
            Mostrar.Click += mostrar;
            void mostrar(object sender, System.EventArgs e)
            {
                string[] array = pi.mostrar();
                for (int i = 0; i < array.Length; i++)
                {
                    var editText = new EditText(this);

                    var layoutParams = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
                    layoutParams.BottomMargin = 6;

                    editText.LayoutParameters = layoutParams;

                    editText.Hint = array[i];

                    lista.AddView(editText);

                }
            }
        }
    }
}