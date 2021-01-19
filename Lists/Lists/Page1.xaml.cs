using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {

        public Page1()
        {
            InitializeComponent();
            xuat();
        }
        public ObservableCollection<Class1> Danhsach { get; set; }
        public void xuat()
        {
            Danhsach = new ObservableCollection<Class1>();
            Danhsach.Add(new Class1 { text = "song phuong hoai duc ha noi", time = "ngay 1/1 - 31/12" });
            Danhsach.Add(new Class1 { text = "van con hoai duc ha noi", time = "ngay 1/1 - 31/12" });
            Danhsach.Add(new Class1 { text = "son dong hoai duc ha noi", time = "ngay 1/1 - 31/12" });
            Danhsach.Add(new Class1 { text = "di trach hoai duc ha noi", time = "ngay 1/1 - 31/12" });
            List.ItemsSource = Danhsach;
        }

        private void searchlist_TextChanged(object sender, TextChangedEventArgs e)
        {
            var vm = Danhsach;
            var lms = vm.Where(c => c.text.ToLower().Contains(searchlist.Text.ToLower()));
            List.ItemsSource = lms;
        }
    }
}