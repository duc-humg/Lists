using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Lists
{
    class Class2
    {
        public ObservableCollection<Class1> Danhsach { get; set; }
        public Class2()
        {
            Danhsach = new ObservableCollection<Class1>();
            Danhsach.Add(new Class1 { text = "song phuong hoai duc ha noi", time = "ngay 1/1 - 31/12" });
            Danhsach.Add(new Class1 { text = "song phuong hoai duc ha noi", time = "ngay 1/1 - 31/12" });
            Danhsach.Add(new Class1 { text = "song phuong hoai duc ha noi", time = "ngay 1/1 - 31/12" });
            Danhsach.Add(new Class1 { text = "song phuong hoai duc ha noi", time = "ngay 1/1 - 31/12" });
        }
    }
   

}
