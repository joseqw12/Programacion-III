using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using static Android.App.ActionBar;

namespace claculadora_Finaciera_Apk
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            SetContentView(Resource.Layout.activity_main);

            EditText inversionInicial = FindViewById<EditText>(Resource.Id.TXTNUMEROP);

            EditText tasa = FindViewById<EditText>(Resource.Id.txttasa);

            Button btnObtener = FindViewById<Button>(Resource.Id.BTNCREAR);
            Button btnCalcula = FindViewById<Button>(Resource.Id.btncalcular);
            LinearLayout textBoxHolder = FindViewById<LinearLayout>(Resource.Id.LBLDINAMICA);

            EditText n = FindViewById<EditText>(Resource.Id.TXTNUMEROP);
            TextView res = FindViewById<TextView>(Resource.Id.txtresultado);


            double[] flujos;

            List<EditText> TextosEdicion1 = new List<EditText>();


            btnObtener.Click += (sender, e) =>
            {
                flujos = new double[int.Parse(n.Text)];
                for (int i = 1; i <= int.Parse(n.Text); i++)
                {
                    var editText = new EditText(this);
                    editText.Tag = $"flujo {i}";

                    var layoutParams = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
           layoutParams.BottomMargin = 2;

                    editText.LayoutParameters = layoutParams;

                    editText.Hint = $"introdusca el flujo # {i}";


                    TextosEdicion1.Add(editText);

                    textBoxHolder.AddView(editText);
                    if (editText.Text == "")
                    {
                        editText.Text = "0";

                    }
                    else
                    {
                        editText.Text = "0";

                    }
                    flujos[i - 1] = double.Parse(editText.Text);
                }

            };

            btnCalcula.Click += (sender, e) =>
            {
                flujos = new double[int.Parse(n.Text)];
                foreach (EditText editor in TextosEdicion1)
                {
                    string valor = editor.Text;
                }
                int num;

                double intereses, IO;
                
                intereses = double.Parse(tasa.Text);


                num = int.Parse(n.Text);
                IO = double.Parse(inversionInicial.Text);

                List<EditText> aux = new List<EditText>();
                aux = TextosEdicion1;

                calculadora cal = new calculadora(num, intereses);
                res.Text = cal.VAN(IO, flujos).ToString();

            };
        }
    }
}