namespace PassGeneratorUI
{
    partial class MainUI
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LowerCheck = new System.Windows.Forms.CheckBox();
            this.UpperCheck = new System.Windows.Forms.CheckBox();
            this.SpecialCheck = new System.Windows.Forms.CheckBox();
            this.NumbersCheck = new System.Windows.Forms.CheckBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.PassLenght = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LowerCheck);
            this.groupBox1.Controls.Add(this.UpperCheck);
            this.groupBox1.Controls.Add(this.SpecialCheck);
            this.groupBox1.Controls.Add(this.NumbersCheck);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(23, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 82);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characters set";
            // 
            // LowerCheck
            // 
            this.LowerCheck.AutoSize = true;
            this.LowerCheck.Checked = true;
            this.LowerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowerCheck.Enabled = false;
            this.LowerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LowerCheck.Location = new System.Drawing.Point(14, 22);
            this.LowerCheck.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.LowerCheck.Name = "LowerCheck";
            this.LowerCheck.Size = new System.Drawing.Size(150, 19);
            this.LowerCheck.TabIndex = 4;
            this.LowerCheck.Text = "lowercase letters [a - z]";
            this.LowerCheck.UseVisualStyleBackColor = true;
            // 
            // UpperCheck
            // 
            this.UpperCheck.AutoSize = true;
            this.UpperCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpperCheck.Location = new System.Drawing.Point(178, 22);
            this.UpperCheck.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.UpperCheck.Name = "UpperCheck";
            this.UpperCheck.Size = new System.Drawing.Size(153, 19);
            this.UpperCheck.TabIndex = 5;
            this.UpperCheck.Text = "uppercase letters [A - Z]";
            this.UpperCheck.UseVisualStyleBackColor = true;
            // 
            // SpecialCheck
            // 
            this.SpecialCheck.AutoSize = true;
            this.SpecialCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpecialCheck.Location = new System.Drawing.Point(178, 52);
            this.SpecialCheck.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SpecialCheck.Name = "SpecialCheck";
            this.SpecialCheck.Size = new System.Drawing.Size(154, 19);
            this.SpecialCheck.TabIndex = 6;
            this.SpecialCheck.Text = "special characters [! - ?]";
            this.SpecialCheck.UseVisualStyleBackColor = true;
            // 
            // NumbersCheck
            // 
            this.NumbersCheck.AutoSize = true;
            this.NumbersCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumbersCheck.Location = new System.Drawing.Point(14, 52);
            this.NumbersCheck.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NumbersCheck.Name = "NumbersCheck";
            this.NumbersCheck.Size = new System.Drawing.Size(108, 19);
            this.NumbersCheck.TabIndex = 7;
            this.NumbersCheck.Text = "numbers [0 - 9]";
            this.NumbersCheck.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(281, 262);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 43);
            this.ExitBtn.TabIndex = 17;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(195, 262);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(80, 43);
            this.CopyBtn.TabIndex = 16;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.UseVisualStyleBackColor = true;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(25, 262);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(164, 43);
            this.GenerateBtn.TabIndex = 15;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            // 
            // PassLenght
            // 
            this.PassLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassLenght.Location = new System.Drawing.Point(143, 132);
            this.PassLenght.Name = "PassLenght";
            this.PassLenght.Size = new System.Drawing.Size(50, 22);
            this.PassLenght.TabIndex = 14;
            this.PassLenght.Text = "10";
            this.PassLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password Lenght :";
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassBox.Location = new System.Drawing.Point(25, 35);
            this.PassBox.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.PassBox.Multiline = true;
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(336, 80);
            this.PassBox.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 322);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.PassLenght);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassBox);
            this.Name = "MainUI";
            this.Text = "Simple Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LowerCheck;
        private System.Windows.Forms.CheckBox UpperCheck;
        private System.Windows.Forms.CheckBox SpecialCheck;
        private System.Windows.Forms.CheckBox NumbersCheck;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.TextBox PassLenght;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

