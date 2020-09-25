using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rename_Images{
    public partial class Main : Form{

        string[] files, paths;
        string extension;

        public string newFileName(string input){
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++){
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public Main(){
            InitializeComponent();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            contextMenuStrip1.Enabled = false;
        }

        private void Main_Load(object sender, EventArgs e){
        }

        private void btnSelect_Click(object sender, EventArgs e){
            openFileDialog1.Filter = "Arquivos de imagem & Video (*.jpg, *.jpeg, *.png, *.gif, *.mp4) | *.jpg; *.jpeg; *.png; *.gif; *.mp4";
            openFileDialog1.AutoUpgradeEnabled = false;
            openFileDialog1.Title = "";
            openFileDialog1.Multiselect = true;

            contextMenuStrip1.Enabled = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                files = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;

                for (int i = 0; i < files.Length; i++){
                    int j = i + 1;
                    extension = Path.GetExtension(files[i]);
                    if (j < 10){
                        whileContent.Items.Add("[0" + j + "] " + files[i] + " ➤ " + newFileName(files[i]) + extension);
                    }else{
                        whileContent.Items.Add("[" + j + "] " + files[i] + " ➤ " + newFileName(files[i]) + extension);
                    }
                }
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e){
            files = openFileDialog1.SafeFileNames;
            paths = openFileDialog1.FileNames;

            for (int v = 0; v < files.Length; v++){
                int s = v + 1;
                extension = Path.GetExtension(files[v]);
                if (s < 10){
                    //if (extension == ".mp4"){
                    //whileStatus.Items.Add("[0" + s + "] " + newFileName(files[v]) + ".mp4 renomeado e salvo com sucesso.");
                    //}else if (extension == ".gif"){
                    //whileStatus.Items.Add("[0" + s + "] " + newFileName(files[v]) + ".gif renomeado e salvo com sucesso.");
                    //}else{
                    //whileStatus.Items.Add("[0" + s + "] " + newFileName(files[v]) + ".jpg renomeado e salvo com sucesso.");
                    //}
                    whileStatus.Items.Add("[0" + s + "] " + newFileName(files[v]) + extension + " renomeado e salvo com sucesso.");
                }else{
                    //if (extension == ".mp4"){
                    //whileStatus.Items.Add("[" + s + "] " + newFileName(files[v]) + ".mp4 renomeado e salvo com sucesso.");
                    //}else if (extension == ".gif"){
                    //whileStatus.Items.Add("[" + s + "] " + newFileName(files[v]) + ".gif renomeado e salvo com sucesso.");
                    //}else{
                    //whileStatus.Items.Add("[" + s + "] " + newFileName(files[v]) + ".jpg renomeado e salvo com sucesso.");
                    //}
                    whileStatus.Items.Add("[" + s + "] " + newFileName(files[v]) + extension + " renomeado e salvo com sucesso.");
                }

                //if (extension == ".mp4"){
                //File.Move(files[v], newFileName(files[v]) + ".mp4");
                //}else if(extension == ".gif"){
                //File.Move(files[v], newFileName(files[v]) + ".gif");
                //}else{
                //File.Move(files[v], newFileName(files[v]) + ".jpg");
                //}
                File.Move(files[v], newFileName(files[v]) + extension);
            }
        }

        private void deletarItemToolStripMenuItem_Click(object sender, EventArgs e){
            if (whileContent.SelectedIndex == -1){
                return;
            }

            whileContent.Items.RemoveAt(whileContent.SelectedIndex);
        }

        private void btnClear_Click(object sender, EventArgs e){
            whileContent.Items.Clear();
            whileStatus.Items.Clear();
        }
    }
}
