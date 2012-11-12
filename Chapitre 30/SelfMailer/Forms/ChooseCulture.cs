using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace SelfMailer.Forms
{
    public partial class ChooseCulture : Form
    {
        public ChooseCulture()
        {
            InitializeComponent();
        }

        private void ChooseCulture_Load(object sender, EventArgs e)
        {
            this.lblCulture.Text = string.Format("Culture: {0}", CultureInfo.CurrentCulture.Name);
            this.CultureList.Items.Add(CultureInfo.CurrentCulture.Name);
            this.CultureList.Items.Add("fr");
            this.CultureList.Items.Add("fr-FR");
            this.CultureList.Items.Add("fr-CH");
            this.CultureList.Items.Add("en");
            this.CultureList.Items.Add("en-US");
        }

        private void CultureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo(this.CultureList.SelectedItem.ToString());
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            this.lblCulture.Text = string.Format("Culture: {0}", CultureInfo.CurrentCulture.Name);
            this.lblDate.Text = string.Format("Date: {0}", DateTime.Now.ToString());
            this.lblMoney.Text = string.Format("Monnaie: {0}", (5432.1).ToString("C"));
        }
    }
}
