namespace Archiver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cansel = new System.Windows.Forms.Button();
            this.Pack_File_Path_IN = new System.Windows.Forms.Button();
            this.UnPack_File_Path_IN = new System.Windows.Forms.Button();
            this.Pack_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Pack_IN = new System.Windows.Forms.TextBox();
            this.textBox_UnPack_IN = new System.Windows.Forms.TextBox();
            this.Pack = new System.Windows.Forms.Button();
            this.Unpack = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear_Pack = new System.Windows.Forms.Button();
            this.textBox_Pack_OUT = new System.Windows.Forms.TextBox();
            this.Pack_File_Path_OUT = new System.Windows.Forms.Button();
            this.textBox_UnPack_OUT = new System.Windows.Forms.TextBox();
            this.UnPack_File_Path_Out = new System.Windows.Forms.Button();
            this.Clear_UnPack = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cansel
            // 
            this.Cansel.Location = new System.Drawing.Point(543, 351);
            this.Cansel.Name = "Cansel";
            this.Cansel.Size = new System.Drawing.Size(159, 23);
            this.Cansel.TabIndex = 0;
            this.Cansel.Text = "Отмена";
            this.Cansel.UseVisualStyleBackColor = true;
            this.Cansel.Click += new System.EventHandler(this.Cansel_Click);
            // 
            // Pack_File_Path_IN
            // 
            this.Pack_File_Path_IN.Location = new System.Drawing.Point(581, 57);
            this.Pack_File_Path_IN.Name = "Pack_File_Path_IN";
            this.Pack_File_Path_IN.Size = new System.Drawing.Size(123, 29);
            this.Pack_File_Path_IN.TabIndex = 1;
            this.Pack_File_Path_IN.Text = "Обзор";
            this.Pack_File_Path_IN.UseVisualStyleBackColor = true;
            this.Pack_File_Path_IN.Click += new System.EventHandler(this.Pack_File_Path_Click);
            // 
            // UnPack_File_Path_IN
            // 
            this.UnPack_File_Path_IN.Location = new System.Drawing.Point(581, 215);
            this.UnPack_File_Path_IN.Name = "UnPack_File_Path_IN";
            this.UnPack_File_Path_IN.Size = new System.Drawing.Size(123, 29);
            this.UnPack_File_Path_IN.TabIndex = 2;
            this.UnPack_File_Path_IN.Text = "Обзор";
            this.UnPack_File_Path_IN.UseVisualStyleBackColor = true;
            this.UnPack_File_Path_IN.Click += new System.EventHandler(this.UnPack_File_Path_Click);
            // 
            // Pack_Label
            // 
            this.Pack_Label.AutoSize = true;
            this.Pack_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pack_Label.Location = new System.Drawing.Point(16, 20);
            this.Pack_Label.Name = "Pack_Label";
            this.Pack_Label.Size = new System.Drawing.Size(688, 24);
            this.Pack_Label.TabIndex = 3;
            this.Pack_Label.Text = "◞◜◝ ◟◞◜◝ ◟◞◜◝ ◟◞◜◝ ◟◞◜◝ ◟◞ Архивация ◜◝ ◟◞◜◝ ◟◞◜◝ ◟◞◜◝ ◟◞◜◝ ◟";
            this.Pack_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "◟◞◜◝ ◟◞◜◝ ◟◞◜◝ ◟◞◜◝ ◟◞◜◝  Разархивация ◜◝ ◟◞◜◝ ◟◞◜◝ ◟◞◜◝ ◟◞◜◝ ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_Pack_IN
            // 
            this.textBox_Pack_IN.Location = new System.Drawing.Point(20, 61);
            this.textBox_Pack_IN.Name = "textBox_Pack_IN";
            this.textBox_Pack_IN.Size = new System.Drawing.Size(514, 20);
            this.textBox_Pack_IN.TabIndex = 5;
            this.textBox_Pack_IN.Text = "Путь к файлу";
            // 
            // textBox_UnPack_IN
            // 
            this.textBox_UnPack_IN.Location = new System.Drawing.Point(20, 220);
            this.textBox_UnPack_IN.Name = "textBox_UnPack_IN";
            this.textBox_UnPack_IN.Size = new System.Drawing.Size(514, 20);
            this.textBox_UnPack_IN.TabIndex = 6;
            this.textBox_UnPack_IN.Text = "Путь к файлу";
            // 
            // Pack
            // 
            this.Pack.Location = new System.Drawing.Point(314, 136);
            this.Pack.Name = "Pack";
            this.Pack.Size = new System.Drawing.Size(119, 29);
            this.Pack.TabIndex = 7;
            this.Pack.Text = "Архивировать";
            this.Pack.UseVisualStyleBackColor = true;
            this.Pack.Click += new System.EventHandler(this.Pack_Click);
            // 
            // Unpack
            // 
            this.Unpack.Location = new System.Drawing.Point(314, 299);
            this.Unpack.Name = "Unpack";
            this.Unpack.Size = new System.Drawing.Size(119, 29);
            this.Unpack.TabIndex = 8;
            this.Unpack.Text = "Разархивировать";
            this.Unpack.UseVisualStyleBackColor = true;
            this.Unpack.Click += new System.EventHandler(this.Unpack_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 351);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(514, 23);
            this.progressBar.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(215, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Процесс выполнения";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Clear_Pack
            // 
            this.Clear_Pack.Location = new System.Drawing.Point(581, 136);
            this.Clear_Pack.Name = "Clear_Pack";
            this.Clear_Pack.Size = new System.Drawing.Size(121, 29);
            this.Clear_Pack.TabIndex = 11;
            this.Clear_Pack.Text = "Очистить";
            this.Clear_Pack.UseVisualStyleBackColor = true;
            this.Clear_Pack.Click += new System.EventHandler(this.Clear_Pack_Click);
            // 
            // textBox_Pack_OUT
            // 
            this.textBox_Pack_OUT.Location = new System.Drawing.Point(20, 100);
            this.textBox_Pack_OUT.Name = "textBox_Pack_OUT";
            this.textBox_Pack_OUT.Size = new System.Drawing.Size(514, 20);
            this.textBox_Pack_OUT.TabIndex = 12;
            this.textBox_Pack_OUT.Text = "Путь сохранения файла";
            // 
            // Pack_File_Path_OUT
            // 
            this.Pack_File_Path_OUT.Location = new System.Drawing.Point(581, 98);
            this.Pack_File_Path_OUT.Name = "Pack_File_Path_OUT";
            this.Pack_File_Path_OUT.Size = new System.Drawing.Size(123, 29);
            this.Pack_File_Path_OUT.TabIndex = 13;
            this.Pack_File_Path_OUT.Text = "Обзор";
            this.Pack_File_Path_OUT.UseVisualStyleBackColor = true;
            this.Pack_File_Path_OUT.Click += new System.EventHandler(this.Pack_File_Path_OUT_Click);
            // 
            // textBox_UnPack_OUT
            // 
            this.textBox_UnPack_OUT.Location = new System.Drawing.Point(20, 263);
            this.textBox_UnPack_OUT.Name = "textBox_UnPack_OUT";
            this.textBox_UnPack_OUT.Size = new System.Drawing.Size(514, 20);
            this.textBox_UnPack_OUT.TabIndex = 14;
            this.textBox_UnPack_OUT.Text = "Путь сохранения файла";
            // 
            // UnPack_File_Path_Out
            // 
            this.UnPack_File_Path_Out.Location = new System.Drawing.Point(580, 258);
            this.UnPack_File_Path_Out.Name = "UnPack_File_Path_Out";
            this.UnPack_File_Path_Out.Size = new System.Drawing.Size(123, 29);
            this.UnPack_File_Path_Out.TabIndex = 15;
            this.UnPack_File_Path_Out.Text = "Обзор";
            this.UnPack_File_Path_Out.UseVisualStyleBackColor = true;
            this.UnPack_File_Path_Out.Click += new System.EventHandler(this.UnPack_File_Path_Out_Click);
            // 
            // Clear_UnPack
            // 
            this.Clear_UnPack.Location = new System.Drawing.Point(581, 299);
            this.Clear_UnPack.Name = "Clear_UnPack";
            this.Clear_UnPack.Size = new System.Drawing.Size(121, 29);
            this.Clear_UnPack.TabIndex = 16;
            this.Clear_UnPack.Text = "Очистить";
            this.Clear_UnPack.UseVisualStyleBackColor = true;
            this.Clear_UnPack.Click += new System.EventHandler(this.Clear_UnPack_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(543, 380);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(159, 23);
            this.CheckButton.TabIndex = 17;
            this.CheckButton.Text = "Проверка файлов";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(744, 457);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.Clear_UnPack);
            this.Controls.Add(this.UnPack_File_Path_Out);
            this.Controls.Add(this.textBox_UnPack_OUT);
            this.Controls.Add(this.Pack_File_Path_OUT);
            this.Controls.Add(this.textBox_Pack_OUT);
            this.Controls.Add(this.Clear_Pack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Unpack);
            this.Controls.Add(this.Pack);
            this.Controls.Add(this.textBox_UnPack_IN);
            this.Controls.Add(this.textBox_Pack_IN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pack_Label);
            this.Controls.Add(this.UnPack_File_Path_IN);
            this.Controls.Add(this.Pack_File_Path_IN);
            this.Controls.Add(this.Cansel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Архиватор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cansel;
        private System.Windows.Forms.Button Pack_File_Path_IN;
        private System.Windows.Forms.Button UnPack_File_Path_IN;
        private System.Windows.Forms.Label Pack_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Pack_IN;
        private System.Windows.Forms.TextBox textBox_UnPack_IN;
        private System.Windows.Forms.Button Pack;
        private System.Windows.Forms.Button Unpack;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear_Pack;
        private System.Windows.Forms.TextBox textBox_Pack_OUT;
        private System.Windows.Forms.Button Pack_File_Path_OUT;
        private System.Windows.Forms.TextBox textBox_UnPack_OUT;
        private System.Windows.Forms.Button UnPack_File_Path_Out;
        private System.Windows.Forms.Button Clear_UnPack;
        private System.Windows.Forms.Button CheckButton;
    }
}

