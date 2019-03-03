namespace ProjektCsharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NameOfLine = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NumberOfLine = new System.Windows.Forms.Button();
            this.NameofRoad = new System.Windows.Forms.Button();
            this.TimeToArrive = new System.Windows.Forms.TextBox();
            this.InvalidButton = new System.Windows.Forms.Button();
            this.StationList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchRoad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71486F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.28514F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Controls.Add(this.NameOfLine, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.NumberOfLine, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameofRoad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TimeToArrive, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.InvalidButton, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(92, 187);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // NameOfLine
            // 
            this.NameOfLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameOfLine.Location = new System.Drawing.Point(3, 3);
            this.NameOfLine.Name = "NameOfLine";
            this.NameOfLine.Size = new System.Drawing.Size(155, 36);
            this.NameOfLine.TabIndex = 0;
            this.NameOfLine.Text = "Linia";
            this.NameOfLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(164, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 36);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Przystanek docelowy";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox2.Location = new System.Drawing.Point(564, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 36);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Przyjazd";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberOfLine
            // 
            this.NumberOfLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumberOfLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumberOfLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NumberOfLine.Location = new System.Drawing.Point(56, 57);
            this.NumberOfLine.Name = "NumberOfLine";
            this.NumberOfLine.Size = new System.Drawing.Size(49, 40);
            this.NumberOfLine.TabIndex = 3;
            this.NumberOfLine.Text = "7";
            this.NumberOfLine.UseVisualStyleBackColor = true;
            // 
            // NameofRoad
            // 
            this.NameofRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameofRoad.Location = new System.Drawing.Point(164, 57);
            this.NameofRoad.Name = "NameofRoad";
            this.NameofRoad.Size = new System.Drawing.Size(394, 40);
            this.NameofRoad.TabIndex = 4;
            this.NameofRoad.Text = "Prószkowska-Politechnika";
            this.NameofRoad.UseVisualStyleBackColor = true;
            // 
            // TimeToArrive
            // 
            this.TimeToArrive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TimeToArrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TimeToArrive.Location = new System.Drawing.Point(564, 57);
            this.TimeToArrive.Name = "TimeToArrive";
            this.TimeToArrive.Size = new System.Drawing.Size(162, 36);
            this.TimeToArrive.TabIndex = 5;
            this.TimeToArrive.Text = "7 min";
            this.TimeToArrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeToArrive.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // InvalidButton
            // 
            this.InvalidButton.Image = ((System.Drawing.Image)(resources.GetObject("InvalidButton.Image")));
            this.InvalidButton.Location = new System.Drawing.Point(730, 54);
            this.InvalidButton.Margin = new System.Windows.Forms.Padding(0);
            this.InvalidButton.Name = "InvalidButton";
            this.InvalidButton.Size = new System.Drawing.Size(35, 42);
            this.InvalidButton.TabIndex = 6;
            this.InvalidButton.UseVisualStyleBackColor = true;
            // 
            // StationList
            // 
            this.StationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.StationList.Location = new System.Drawing.Point(129, 85);
            this.StationList.Name = "StationList";
            this.StationList.Size = new System.Drawing.Size(206, 36);
            this.StationList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(177, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Przystanek";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(429, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz godzine";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(427, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "21 05";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchRoad
            // 
            this.SearchRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchRoad.Location = new System.Drawing.Point(683, 85);
            this.SearchRoad.Margin = new System.Windows.Forms.Padding(0);
            this.SearchRoad.Name = "SearchRoad";
            this.SearchRoad.Size = new System.Drawing.Size(174, 36);
            this.SearchRoad.TabIndex = 6;
            this.SearchRoad.Text = "Wyszukaj";
            this.SearchRoad.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(912, 511);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 42);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(964, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "-Pojazd niskopodłogowy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 802);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchRoad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StationList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox NameOfLine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button NumberOfLine;
        private System.Windows.Forms.Button NameofRoad;
        private System.Windows.Forms.TextBox TimeToArrive;
        private System.Windows.Forms.Button InvalidButton;
        private System.Windows.Forms.TextBox StationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SearchRoad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

