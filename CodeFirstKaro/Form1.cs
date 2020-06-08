using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstKaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataContext db = new DataContext();
            generateInitialProducts(db);
        }

        private void generateInitialProducts(DataContext db)
        {
            // создаем два объекта person
            product p1 = new product(
                1,
                "Limon",
                "grade1"
                );
            product p2 = new product(
               2,
               "Apelsin",
               "grade1"
               );

            db.products.Add(p1);
            db.products.Add(p2);
            db.SaveChanges();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
