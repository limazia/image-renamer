namespace Rename_Images
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.whileStatus = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.whileContent = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // whileStatus
            // 
            this.whileStatus.FormattingEnabled = true;
            this.whileStatus.ItemHeight = 16;
            this.whileStatus.Location = new System.Drawing.Point(12, 355);
            this.whileStatus.Name = "whileStatus";
            this.whileStatus.Size = new System.Drawing.Size(776, 292);
            this.whileStatus.TabIndex = 21;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Audio (*.cs,*.acc,*wma)|*.cs;*.mp3;*.wma|All Files (*.*)|*.*";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(535, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(253, 39);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Limpar Lista";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(276, 310);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(253, 39);
            this.btnSaveImage.TabIndex = 20;
            this.btnSaveImage.Text = "Renomear e Salvar";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 310);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(253, 39);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "Adicionar Imagens e Videos";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // whileContent
            // 
            this.whileContent.ContextMenuStrip = this.contextMenuStrip1;
            this.whileContent.FormattingEnabled = true;
            this.whileContent.HorizontalScrollbar = true;
            this.whileContent.ItemHeight = 16;
            this.whileContent.Location = new System.Drawing.Point(12, 12);
            this.whileContent.Name = "whileContent";
            this.whileContent.Size = new System.Drawing.Size(776, 292);
            this.whileContent.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 28);
            // 
            // deletarItemToolStripMenuItem
            // 
            this.deletarItemToolStripMenuItem.Name = "deletarItemToolStripMenuItem";
            this.deletarItemToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.deletarItemToolStripMenuItem.Text = "Deletar Item";
            this.deletarItemToolStripMenuItem.Click += new System.EventHandler(this.deletarItemToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 658);
            this.Controls.Add(this.whileStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.whileContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lima Renomeador (Imagens & Videos)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox whileStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox whileContent;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletarItemToolStripMenuItem;
    }
}

