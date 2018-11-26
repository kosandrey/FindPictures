namespace FindPic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Folder = new System.Windows.Forms.TextBox();
            this.PicturesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(422, 37);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(36, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "...";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button3_Click);
            // 
            // Folder
            // 
            this.Folder.Location = new System.Drawing.Point(56, 37);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(321, 22);
            this.Folder.TabIndex = 4;
            this.Folder.TextChanged += new System.EventHandler(this.Folder_TextChanged);
            // 
            // PicturesPanel
            // 
            this.PicturesPanel.AutoScroll = true;
            this.PicturesPanel.ColumnCount = 4;
            this.PicturesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PicturesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PicturesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PicturesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PicturesPanel.Location = new System.Drawing.Point(16, 75);
            this.PicturesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PicturesPanel.Name = "PicturesPanel";
            this.PicturesPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PicturesPanel.RowCount = 1;
            this.PicturesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PicturesPanel.Size = new System.Drawing.Size(458, 164);
            this.PicturesPanel.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 260);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(12, 17);
            this.label.TabIndex = 6;
            this.label.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(502, 326);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PicturesPanel);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox Folder;
        private System.Windows.Forms.TableLayoutPanel PicturesPanel;
        private System.Windows.Forms.Label label;
    }
}

