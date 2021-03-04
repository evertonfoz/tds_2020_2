using PetCare.Domain.Models;
using PetCare.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            OwnerModel ownerModel = new OwnerModel(
                new Name(tbFirstname.Text, tbLastname.Text), tbEmail.Text
            );

            if (ownerModel.Name.Valid)
            {
                MessageBox.Show("Dados corretos", "Aviso", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            } else
            {
                string errors = "";
                foreach (var n in ownerModel.Name.Notifications)
                {
                    errors += $"{n.Message}\n";
                }
                MessageBox.Show(errors, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }
    }
}
