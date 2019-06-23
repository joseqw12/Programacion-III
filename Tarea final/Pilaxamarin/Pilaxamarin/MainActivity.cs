using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Pilaxamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Pila<string> pi = new Pila<string>();
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button Insertar = FindViewById<Button>(Resource.Id.btningresar);
            EditText numero = FindViewById<EditText>(Resource.Id.txtnumero);
            Button Eliminar = FindViewById<Button>(Resource.Id.btneliminar);
            EditText elimnum = FindViewById<EditText>(Resource.Id.txteliminar);
            Button Mostrar = FindViewById<Button>(Resource.Id.btnmostar);
            LinearLayout mostrra = FindViewById<LinearLayout>(Resource.Id.lnlmostrar);

            Insertar.Click += (sender, e) =>
            {
                pi.push(numero.Text);
            };
            Eliminar.Click += (sender, e) =>
              {
                  elimnum.Text = pi.pop();
                  
              };
            mostrra.Click += (sender, e) =>
              {
                  ListView li = new ListView();
              };
        }
        class mostrar
        {
          

            Pila<string> pi = new Pila<string>();
          
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