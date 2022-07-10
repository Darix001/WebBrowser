using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using CefSharp.Web;
using Newtonsoft.Json;
using System.IO;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        int index = 0;
        readonly string home = "www.Google.com";
        List<ChromiumWebBrowser> browsers = new List<ChromiumWebBrowser>();
        List<string> favs = new List<string>();
        string file = "Favoritos.txt";
        public Form1()
        {
            InitializeComponent();
            browsers.Add(new ChromiumWebBrowser(home));
            browsers[0].Dock = DockStyle.Fill;
            tabPage1.Controls.Add(browsers[0]);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txturl.Text = home;
            btnhome_Click(sender, e);
            favs.Clear();
            if (File.Exists(file))
            {
                favs.AddRange(File.ReadAllLines(file));
                foreach (var fav in favs)
                {
                    cmbfav.Items.Add(fav);
                }
                
            }
            else
            {
                File.Create(file);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txturl.Text.Trim().Length!=0)
            {
                browsers[index].Load(txturl.Text);
                txturl.Text = browsers[index].Address;
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            browsers[index].LoadUrlAsync(home);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (browsers[index].CanGoBack)
            {
                browsers[index].Back();
            }
        }

        private void btnforward_Click(object sender, EventArgs e)
        {
            if (browsers[index].CanGoForward)
            {
                browsers[index].Forward();
            }
        }

        private void Save_Favs()
        {
            foreach (var item in cmbfav.Items)
            {
                favs.Add(item.ToString());
            }
            File.WriteAllLines(file, favs);
            favs.Clear();
        }
        private void btnfav_Click(object sender, EventArgs e)
        {
            if (txturl.Text.Trim().Length!=0)
            {
                cmbfav.Items.Add(txturl.Text);
                Save_Favs();
                MessageBox.Show("Página añadida a favoritos.");
            }
            
        }

        private void btndelfav_Click(object sender, EventArgs e)
        {
            if (cmbfav.Text.Trim().Length != 0)
            {
                cmbfav.Items.Remove(txturl.Text);
                Save_Favs();
                MessageBox.Show("Página eliminada de favoritos.");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

       
        private void txturl_Click(object sender, EventArgs e)
        {
            txturl.Text = browsers[index].Address;
        }


        private void txturl_Enter(object sender, EventArgs e)
        {
            
        }

        private void txturl_DoubleClick(object sender, EventArgs e)
        {
            txturl.SelectAll();
        }

        private void Form1_Move(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
            {
                index = tabControl1.SelectedIndex;
                txturl.Text = browsers[index].Address;
            }
            
        }

        private void btnaddtab_Click(object sender, EventArgs e)
        {   
            index++;
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            browsers.Add(new ChromiumWebBrowser(home));
            browsers[index].Dock = DockStyle.Fill;
            tab.Controls.Add(browsers[index]);
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectTab(index);
        }

        private void btndeltab_Click(object sender, EventArgs e)
        {
            browsers.RemoveAt(index);
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void cmbfav_Click(object sender, EventArgs e)
        {

        }

        private void cmbfav_TextChanged(object sender, EventArgs e)
        {
            cmbfav.Text = txturl.Text;
            browsers[index].Load(txturl.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            int x = 0;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(tab);
                browsers[x].Hide();
                x++;
            }
        }

        private void btndelfav_Click_1(object sender, EventArgs e)
        {
            if (cmbfav.Text.Trim().Length != 0)
            {
                cmbfav.Items.Remove(txturl.Text);
                favs.Remove(txturl.Text);
                Save_Favs();
                MessageBox.Show("Página eliminada de favoritos.");
            }
        }
    }
}
