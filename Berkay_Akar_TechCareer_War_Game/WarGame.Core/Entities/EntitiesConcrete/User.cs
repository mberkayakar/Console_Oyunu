using System;
using System.Collections.Generic;
using System.Linq;
using WarGame.Core.Concrete;
using WarGame.Entities.Abstract;

namespace WarGame.Entities.Concrete
{
    public class User : IEntity
    {
        public User(string username, string name, string surname)
        {
            _ıd = "WarGame" + username + Guid.NewGuid().ToString();
            _weaphones = new List<BaseWeaphoneRepository>();
            Username = username;
            Name = name;
            Surname = surname;
            _health = 100;
        }



        private readonly string _ıd;  // üretilme esnasında her user in benzersiz bir id si olması gerektiği düşünüğlerek bu şekilde bir tasarım gerçekleştirilmiştir.
        private string _username;
        private string _name;
        private string _surname;
        private int _health;

        private List<BaseWeaphoneRepository> _weaphones;


        public string Id { get {return _ıd; } }
        public string Username { get { return _username; } set { if (value.Trim().ToUpper().Length > 5) { _username = value.Trim().ToUpper(); } } }
        public string Name { get { return _name; } set { if (value.Trim().ToUpper().Length > 5) { _name = value.Trim().ToUpper(); } } }
        public string Surname { get { return _surname; } set { if (value.Trim().ToUpper().Length > 5) { _surname = value.Trim().ToUpper(); } } }
        public int Health { get { return _health; } set { _health -= value; } }
        public List<BaseWeaphoneRepository> silahlar { get { return _weaphones; } }
        public BaseWeaphoneRepository SilahEkle { set { if (_weaphones.Count<4) { _weaphones.Add(value); } else { throw new ArgumentOutOfRangeException("Maksimum 3 silaha kadar seçim yapabilirsiniz"); } } }

        public void Envanterden_Silah_Cikarma(string marka)
        {
            if (_weaphones != null || _weaphones.Count!= 0)
            {
                this._weaphones.Remove(_weaphones.FirstOrDefault(x => x.Marka == marka));
            }
        }
    }
}

