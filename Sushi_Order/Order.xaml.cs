using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MySql;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sushi_Order
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Order : Page
    {
        public Order()
        {
            this.InitializeComponent();
            //CRUD app = new CRUD();
            //app.TestConnection();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            CRUD app = new CRUD();
            //app.TestConnection();
             app.tambahOrder("naa", "Sushi_Order", 12, "Surya", "0812334");
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
