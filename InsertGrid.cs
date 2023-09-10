using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingForm
{
    public partial class InsertGridForm : Form
    {
        #region Ctor

        public InsertGridForm()
        {
            InitializeComponent();
            SubscribeToEvents();
        }
        #endregion

        #region Private Methods

       private void SubscribeToEvents()
        {
            btnCancel.Click += BtnCancel_Click;
            btnSubmitForm.Click += BtnSubmitForm_Click;

        }
        #endregion

        #region Events
        private void BtnSubmitForm_Click(object sender, EventArgs e)
        {
            var gridSpacingForXDirection = txtAxisSpacingDir1.Text.Split('*')[0];
            var totalOfGridsForXDirection = txtAxisSpacingDir1.Text.Split('*')[1];

            var gridSpacingForYDirection = txtAxisSpacingDir2.Text.Split('*')[0];
            var totalOfGridsForYDirection = txtAxisSpacingDir2.Text.Split('*')[1];



        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }
        #endregion


    }
}
