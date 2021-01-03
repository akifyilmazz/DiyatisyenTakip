using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diesta.MVC.Class
{
    public class GirisModel
    {
        public string kullaniciAdi { get; set; }

        public string eposta { get; set; }

        public string password { get; set; }

        public bool thisNull
        {
            get
            {
                return string.IsNullOrEmpty(eposta) ? true : string.IsNullOrEmpty(password) ? true : false;
            }
        }
    }
}