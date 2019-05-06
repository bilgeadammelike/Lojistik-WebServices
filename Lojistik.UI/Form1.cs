using Lojistik.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojistik.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (LojistikDbEntities db = new LojistikDbEntities())
            {
                db.Gemi.ToList();
                db.Gemi.Add(new Gemi()
                {
                    GemiAdi = "hede",
                    Boyut = 50,
                    AktifMi = true,
                    Tonaj = 1
                });

                db.SaveChanges();
            }
        }
    }
}
