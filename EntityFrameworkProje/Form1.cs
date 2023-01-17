using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProje
{
    public partial class Form1 : Form
    {
        ProductDal _prodcutDal = new ProductDal();

        private void LoadProdcut()
        {
            dgwProduct.DataSource = _prodcutDal.GetAllProducts();
        }

        private void LoadCategory()
        {
            cbxCategory.DataSource = _prodcutDal.GetAllCategories();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void SearchByName(string key)
        {
            if (String.IsNullOrEmpty(key))
            {
                LoadProdcut();
            }
            else
            {
                dgwProduct.DataSource = _prodcutDal.ListByProductName(key);
            }
            
        }

        private void SearchByCategory(int id)
        {
            dgwProduct.DataSource = _prodcutDal.ListByCategory(id);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProdcut();
            
            cbxCategory.
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //try
            //{
                SearchByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            //}
            //catch
            //{

            //}
            
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            SearchByName(tbxName.Text);
        }
    }
}
