namespace OpenApps
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnDelete = new Button();
            btnOpenAll = new Button();
            listViewFiles = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 367);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(279, 367);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpenAll
            // 
            btnOpenAll.Location = new Point(149, 476);
            btnOpenAll.Name = "btnOpenAll";
            btnOpenAll.Size = new Size(100, 40);
            btnOpenAll.TabIndex = 3;
            btnOpenAll.Text = "Abrir todos";
            btnOpenAll.UseVisualStyleBackColor = true;
            btnOpenAll.Click += btnOpenAll_Click;
            // 
            // listViewFiles
            // 
            listViewFiles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewFiles.FullRowSelect = true;
            listViewFiles.GridLines = true;
            listViewFiles.LabelEdit = true;
            listViewFiles.Location = new Point(12, 12);
            listViewFiles.Name = "listViewFiles";
            listViewFiles.Size = new Size(367, 349);
            listViewFiles.TabIndex = 4;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            listViewFiles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Caminho";
            columnHeader2.Width = 210;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 549);
            Controls.Add(listViewFiles);
            Controls.Add(btnOpenAll);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Arquivos";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Button btnDelete;
        private Button btnOpenAll;
        private ListView listViewFiles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
