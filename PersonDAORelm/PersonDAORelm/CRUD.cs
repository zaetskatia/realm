using Realms;
using System;
using System.Collections.Generic;

namespace PersonDAORelm
{
    public class CRUD
    {
        private Realm mRealm;
        
        public CRUD()
        {
        }

        public List<Person> Read()
        {
            return null;
        }
        public static void Create(Person p)
        {
            var realm = Realm.GetInstance();
            realm.Write(() =>
            {
                realm.Add(p);
            });
        }
        public static void Update(Person p)
        {
            var realm = Realm.GetInstance();
            using (var trans = realm.BeginWrite())
            {
                p.fname = "Thomas";
                trans.Commit();
            }
        }
        public static void Delete(Person p)
        {
            var realm = Realm.GetInstance();
            using (var trans = realm.BeginWrite())
            {
                realm.Remove(p);
                trans.Commit();
            }
        }

    }
}

