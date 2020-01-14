using System;
using System.Windows.Forms;

namespace GoatRiderForms {
    public partial class Form12411 : Form {
        public Form12411() {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory="c:\\";
            openFileDialog.Filter="文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.RestoreDirectory=true;
            openFileDialog.FilterIndex=1;
            if (openFileDialog.ShowDialog()==DialogResult.OK){
                textBox1.Text =  openFileDialog.FileName;
            }
        }
    }
}