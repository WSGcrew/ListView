using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace FirstListApp
{
    [Activity(Label = "FirstListApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ListView listaZakupow;
        string[] elementyListy = new string[] { "Chleb", "Masło", "Kawa", "Ciastka", "Mielone", "Ser" };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            listaZakupow = FindViewById<ListView>(Resource.Id.listView1);
            ArrayAdapter adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, elementyListy);
            listaZakupow.Adapter = adapter;
            listaZakupow.ItemClick += listaZakupow_ItemClick;
            SetContentView(Resource.Layout.Main);
        }

        private void listaZakupow_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var item = this.elementyListy.GetValue(e.Id);

            Toast.MakeText(this, "Kliknięto " + item + "!", ToastLength.Short).Show();

            Intent akrywnosc2 = new Intent(this, typeof(DrugaAktywosc));

            akrywnosc2.PutExtra("MojeDane",""+ item);

            StartActivity(akrywnosc2);

        }
    }
}

