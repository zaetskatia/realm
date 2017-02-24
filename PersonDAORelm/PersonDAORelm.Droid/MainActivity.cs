using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PersonDAORelm.Droid
{
    [Activity(Label = "PersonDAORelm.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, View.IOnClickListener 
    {
        EditText etFname;
        EditText etLname;
        EditText etId;
        EditText etAge;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);            
            SetContentView(Resource.Layout.Main);

            Button btnCreate = FindViewById<Button>(Resource.Id.btnCreate);
            Button btnUpdate = FindViewById<Button>(Resource.Id.btnUpdate);
            Button btnRead = FindViewById<Button>(Resource.Id.btnRead);
            Button btnDelete = FindViewById<Button>(Resource.Id.btnDelete);

            etFname = FindViewById<EditText>(Resource.Id.etFname);
            etLname = FindViewById<EditText>(Resource.Id.etLname);
            etId    = FindViewById<EditText>(Resource.Id.etId);
            etAge   = FindViewById<EditText>(Resource.Id.etAge);


            btnCreate.SetOnClickListener(this);
            btnUpdate.SetOnClickListener(this);
            btnRead.SetOnClickListener(this);
            btnDelete.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.btnRead:
                    break;
                case Resource.Id.btnCreate:
                    CRUD.Create(new Person(etFname.Text, etLname.Text, etId.Text, etAge.Text));
                    break;
                case Resource.Id.btnUpdate:
                    CRUD.Update(new Person(etFname.Text, etLname.Text,etId.Text, etAge.Text));
                    break;
                case Resource.Id.btnDelete:
                    CRUD.Delete(new Person(etFname.Text, etLname.Text, etId.Text,etAge.Text));
                    break;

            }
        }
    }
}



