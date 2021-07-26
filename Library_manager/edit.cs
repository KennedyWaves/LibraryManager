﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Library_manager
{
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }
        bool copia = false;
        string lcd_path;
        private void edit_Load(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            XmlDocument data = new XmlDocument();
            string path = @"D:\Base\"+MainWindow.name_import+".xml";
            data.Load(path);
            txt_autor.Text = data.SelectSingleNode("/book/livro").Attributes["autor"].Value;
            txt_nome.Text = MainWindow.name_import;
            txt_editora.Text = data.SelectSingleNode("/book/livro").Attributes["editora"].Value;
            txt_ano.Text = data.SelectSingleNode("/book/livro").Attributes["ano"].Value;
            txt_quant.Text = data.SelectSingleNode("/book/livro").Attributes["quant"].Value;
            txt_id.Text = data.SelectSingleNode("/book/livro").Attributes["identify"].Value;
            if (System.IO.File.Exists("D:\\base\\" + MainWindow.name_import + ".capa"))
            {
                Image capa = Image.FromFile("D:\\base\\" + MainWindow.name_import + ".capa");
                img_capa.Image = capa;
            }
            txt_nome.Focus();
        }

        private void cmd_load_Click(object sender, EventArgs e)
        {
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "Todos os arquivos suportados |*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.ico;*.dib;*.jpe;*.tif;*.tiff;*.wsi|Todos os arquivos |*.*|Windows Bitmap |*.bmp|Bitmaps JPEG |*.jpg;*.jpeg|Portable Network Graphics |*.png|Compuserve GIF |*.gif|Windows 3.x/NT Icon Resource |*.ico|DIB Image|*.dib|Bitmap TIFF |*.tif;*.tiff|Waves Software Image File |*.wsi";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lcd_path = openFileDialog.FileNames[0];
                    try
                    {
                        Image capa_bmp = Image.FromFile(lcd_path);
                        img_capa.Image = capa_bmp;
                        copia = true;
                    }
                    catch (Exception ex)
                    {
                        copia = false;
                        MessageBox.Show(ex.Message, "WAVES informática", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void cmd_incr_Click(object sender, EventArgs e)
        {
            int quantInt = Convert.ToInt32(txt_quant.Text) + 1;
            txt_quant.Text = quantInt.ToString();
        }

        private void cmd_decr_Click(object sender, EventArgs e)
        {
            int quantInt = Convert.ToInt32(txt_quant.Text) - 1;
            if (quantInt > -1)
            {
                txt_quant.Text = quantInt.ToString();
            }
        }

        private void cmd_clean_Click(object sender, EventArgs e)
        {
            txt_ano.Text = "";
            txt_autor.Text = "";
            txt_editora.Text = "";
            txt_nome.Text = "";
            txt_quant.Text = "1";
            img_capa.Image = null;
            copia = false;
            Application.EnableVisualStyles();
            XmlDocument data = new XmlDocument();
            string path = @"D:\Base\" + MainWindow.name_import + ".xml";
            data.Load(path);
            txt_autor.Text = data.SelectSingleNode("/book/livro").Attributes["autor"].Value;
            txt_nome.Text = MainWindow.name_import;
            txt_editora.Text = data.SelectSingleNode("/book/livro").Attributes["editora"].Value;
            txt_ano.Text = data.SelectSingleNode("/book/livro").Attributes["ano"].Value;
            txt_quant.Text = data.SelectSingleNode("/book/livro").Attributes["quant"].Value;
            txt_id.Text = data.SelectSingleNode("/book/livro").Attributes["identify"].Value;
            if (System.IO.File.Exists("D:\\base\\" + MainWindow.name_import + ".capa"))
            {
                Image capa = Image.FromFile("D:\\base\\" + MainWindow.name_import + ".capa");
                img_capa.Image = capa;
            }
            txt_nome.Focus();
        }

        private void cmd_add_Click(object sender, EventArgs e)
        {
            bool saved = true;
            try
            {
                XmlDocument data = new XmlDocument();
                XmlNode docNode = data.CreateXmlDeclaration("1.0", "UTF-8", null);
                data.AppendChild(docNode);
                XmlElement book_Elem = data.CreateElement("book");
                data.AppendChild(book_Elem);
                XmlNode livroNode = data.CreateElement("livro");
                book_Elem.AppendChild(livroNode);
                XmlAttribute saving = data.CreateAttribute("identify");
                saving.InnerText = txt_id.Text;
                livroNode.Attributes.Append(saving);
                saving = data.CreateAttribute("nome");
                saving.InnerText = txt_nome.Text;
                livroNode.Attributes.Append(saving);
                saving = data.CreateAttribute("autor");
                saving.InnerText = txt_autor.Text;
                livroNode.Attributes.Append(saving);
                saving = data.CreateAttribute("editora");
                saving.InnerText = txt_editora.Text;
                livroNode.Attributes.Append(saving);
                saving = data.CreateAttribute("ano");
                saving.InnerText = txt_ano.Text;
                livroNode.Attributes.Append(saving);
                saving = data.CreateAttribute("quant");
                saving.InnerText = txt_quant.Text;
                livroNode.Attributes.Append(saving);
                data.Save(@"D:\base\" + txt_nome.Text + ".xml");
                XmlDocument id_next = new XmlDocument();
                string path = @"D:\Base\waves.wlm";
                id_next.Load(path);
                int intID = Convert.ToInt32(id_next.SelectSingleNode("/system/info").Attributes["next_id"].Value) + 1;
                id_next.SelectSingleNode("/system/info").Attributes["next_id"].Value = intID.ToString();
                id_next.Save(path);
                if (copia)
                {
                    System.IO.File.Copy(lcd_path, "D:\\Base\\" + txt_nome.Text + ".capa", true);
                }

            }
            catch
            {
                MessageBox.Show("Erro ao editar livro!", "WAVES Library Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saved = false;
            }
            if (saved)
            {
                MessageBox.Show(txt_nome.Text + " editado com sucesso!", "WAVES Library Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
