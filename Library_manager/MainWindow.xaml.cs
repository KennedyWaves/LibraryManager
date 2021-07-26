using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.IO;
namespace Library_manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();          
        }
        bool change = false;
        public static string name_import = "";
        string name_str;
        int name_index;
        void Update_list()
        {
            lsb_books.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(@"D:\Projects\base");
            FileInfo[] Files = d.GetFiles("*.xml");
            foreach (FileInfo file in Files)
            {
                lsb_books.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file.Name));
            }
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Update_list();
        }

        private void lsb_books_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var name = (lsb_books.SelectedItem);
            name_str = name.ToString();
            name_index = (lsb_books.SelectedIndex);
            XmlDocument data = new XmlDocument();
            string path = @"D:\Projects\Base\"+name+".xml";
            data.Load(path);
            txb_autor.Text = data.SelectSingleNode("/book/livro").Attributes["autor"].Value;
            txb_nome1.Text = name.ToString();
            txb_editora.Text = data.SelectSingleNode("/book/livro").Attributes["editora"].Value;
            txb_ano.Text = data.SelectSingleNode("/book/livro").Attributes["ano"].Value;
            txb_quant.Text = data.SelectSingleNode("/book/livro").Attributes["quant"].Value;
            txb_id.Text = data.SelectSingleNode("/book/livro").Attributes["identify"].Value;
            if (System.IO.File.Exists("D:\\base\\" + name + ".capa"))
            {
                BitmapImage capa = new BitmapImage(new Uri("D:\\base\\"+name + ".capa"));
                img_capa.Source = capa;
            }
            else
            {
                img_capa.Source = null;
            }
            
        }

        private void Window_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            img_bar.Width = this.Width;
        }

        private void cmd_edit_Click(object sender, RoutedEventArgs e)
        {
            img_bar.Width = this.Width;
        }

        private void Window_LayoutUpdated(object sender, EventArgs e)
        {
            /*img_bar.Width = this.Width;
            lsb_books.Height = this.Height - 330;
            lsb_books.Width = this.Width - 35;
            txt_search.Width = this.Width - 70;
            txb_ano.Width = this.Width - 280;
            txb_nome1.Width = this.Width - 256;
            txb_autor.Width = this.Width - 256;
            txb_editora.Width = this.Width - 250;
            txb_quant.Width = this.Width - 260;*/
        }

        private void cmd_add_Click(object sender, RoutedEventArgs e)
        {
            add add_book = new add();
            add_book.ShowDialog();
            Update_list();
        }

        private void lsb_books_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            lsb_books.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(@"D:\base");
            FileInfo[] Files = d.GetFiles("*"+txt_search.Text+"*.xml");
            foreach (FileInfo file in Files)
            {
                lsb_books.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file.Name));
            }
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lsb_books.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(@"D:\base");
            FileInfo[] Files = d.GetFiles("*.xml");
            foreach (FileInfo file in Files)
            {
                XmlDocument data = new XmlDocument();
                string path = @"D:\Base\" + file.Name;
                data.Load(path);
                if (txt_search.Text == data.SelectSingleNode("/book/livro").Attributes["identify"].Value)
                {
                    lsb_books.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file.Name));
                }
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
        }

        private void cmd_edit_Click_1(object sender, RoutedEventArgs e)
        {
            var name = (lsb_books.SelectedItem);
            name_import = name.ToString();
            edit open_edit = new edit();
            open_edit.Show();
        }

        private void cmd_del_Click(object sender, RoutedEventArgs e)
        {
            var name = (lsb_books.SelectedItem);
            string get_name = name.ToString();
            DirectoryInfo d = new DirectoryInfo(@"D:\base");
            FileInfo[] Files = d.GetFiles(get_name + ".*");
            foreach (FileInfo file in Files)
            {
                System.IO.File.Delete("D:\\base\\" + file.Name);
            }
            Update_list();
        }
    }
}
