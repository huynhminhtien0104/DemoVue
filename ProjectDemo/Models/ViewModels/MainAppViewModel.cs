using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDemo.Models.ViewModels
{
    public class MainAppViewModel
    {
        public Person person { get; set; }

        public MainAppViewModel()
        {
            person = new Person("Tien","Minh");
        }
    }
}