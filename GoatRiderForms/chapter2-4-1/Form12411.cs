using System;
using System.Windows.Forms;

namespace GoatRiderForms {
    public partial class Form12411 : Form {
        public Form12411() {
            InitializeComponent();
        }

        // 选择文件对话框
        private void btn1_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // 指定 对话框打开后的初始化目录
            openFileDialog.InitialDirectory="c:\\";
            openFileDialog.Filter="文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.RestoreDirectory=true;
            openFileDialog.Multiselect=false;//该值确定是否可以选择多个文件
            openFileDialog.FilterIndex=1;
            if (openFileDialog.ShowDialog()==DialogResult.OK){
                textBox1.Text =  openFileDialog.FileName;
            }
        }

        // 选择文件夹/目录对话框
        private void btn2_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK){
                textBox1.Text = dialog.SelectedPath;
            }
        }
    }
}