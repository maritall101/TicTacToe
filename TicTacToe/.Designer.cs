namespace TicTacToe
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GameButton1 = new System.Windows.Forms.Button();
            this.GameButton2 = new System.Windows.Forms.Button();
            this.GameButton3 = new System.Windows.Forms.Button();
            this.GameButton4 = new System.Windows.Forms.Button();
            this.GameButton5 = new System.Windows.Forms.Button();
            this.GameButton6 = new System.Windows.Forms.Button();
            this.GameButton7 = new System.Windows.Forms.Button();
            this.GameButton8 = new System.Windows.Forms.Button();
            this.GameButton9 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Restart = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.GameButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameButton3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameButton4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GameButton5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GameButton6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.GameButton7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.GameButton8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.GameButton9, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 315);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GameButton1
            // 
            this.GameButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameButton1.Location = new System.Drawing.Point(3, 3);
            this.GameButton1.Name = "GameButton1";
            this.GameButton1.Size = new System.Drawing.Size(260, 99);
            this.GameButton1.TabIndex = 0;
            this.GameButton1.Tag = "0";
            this.GameButton1.UseVisualStyleBackColor = false;
            this.GameButton1.Click += new System.EventHandler(this.button_click);
            // 
            // GameButton2
            // 
            this.GameButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameButton2.Location = new System.Drawing.Point(269, 3);
            this.GameButton2.Name = "GameButton2";
            this.GameButton2.Size = new System.Drawing.Size(260, 99);
            this.GameButton2.TabIndex = 1;
            this.GameButton2.Tag = "1";
            this.GameButton2.UseVisualStyleBackColor = false;
            this.GameButton2.Click += new System.EventHandler(this.button_click);
            // 
            // GameButton3
            // 
            this.GameButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameButton3.Location = new System.Drawing.Point(535, 3);
            this.GameButton3.Name = "GameButton3";
            this.GameButton3.Size = new System.Drawing.Size(262, 99);
            this.GameButton3.TabIndex = 2;
            this.GameButton3.Tag = "2";
            this.GameButton3.UseVisualStyleBackColor = false;
            this.GameButton3.Click += new System.EventHandler(this.button_click);
            // 
            // GameButton4
            // 
            this.GameButton4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameButton4.Location = new System.Drawing.Point(3, 108);
            this.GameButton4.Name = "GameButton4";
            this.GameButton4.Size = new System.Drawing.Size(260, 99);
            this.GameButton4.TabIndex = 3;
            this.GameButton4.Tag = "3";
            this.GameButton4.UseVisualStyleBackColor = false;
            this.GameButton4.Click += new System.EventHandler(this.button_click);
            // 
            // GameButton5
            // 
            this.GameButton5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameButton5.Location = new System.Drawing.Point(269, 108);
            this.GameButton5.Name = "GameButton5";
            this.GameButton5.Size = new System.Drawing.Size(260, 99);
            this.GameButton5.TabIndex = 4;
            this.GameButton5.Tag = "4";
            this.GameButton5.UseVisualStyleBackColor = false;
            this.GameButton5.Click += new System.EventHandler(this.button_click);
            // 
            // GameButton6
            // 
            this.GameButton6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameButton6.Location = new System.Drawing.Point(535, 108);
            this.GameButton6.Name = "GameButton6";
            this.GameButton6.Size = new System.Drawing.Size(262, 99);
            this.GameButton6.TabIndex = 5;
            this.GameButton6.Tag = "5";
            this.GameButton6.UseVisualStyleBackColor = false;
            this.GameButton6.Click += new System.EventHandler(this.button_click);
            // 
            // GameButton7
            // 
            this.GameButton7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameButton7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameButton7.Location = new System.Drawing.Point(3, 213);
            this.GameButton7.Name = "GameButton7";
            this.GameButton7.Size = new System.Drawing.Size(260, 99);
            this.GameButton7.TabIndex = 6;
            this.GameButton7.Tag = "6";
            this.GameButton7.UseVisualStyleBackColor = false;
            this.GameButton7.Click += new System.EventHandler(this.button_click);
            // 
            // GameButton8
            // 
            this.GameButton8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameButton8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameButton8.Location = new System.Drawing.Point(269, 213);
            this.GameButton8.Name = "GameButton8";
            this.GameButton8.Size = new System.Drawing.Size(260, 99);
            this.GameButton8.TabIndex = 7;
            this.GameButton8.Tag = "7";
            this.GameButton8.UseVisualStyleBackColor = false;
            this.GameButton8.Click += new System.EventHandler(this.button_click);
            // 
            // GameButton9
            // 
            this.GameButton9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameButton9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameButton9.Location = new System.Drawing.Point(535, 213);
            this.GameButton9.Name = "GameButton9";
            this.GameButton9.Size = new System.Drawing.Size(262, 99);
            this.GameButton9.TabIndex = 8;
            this.GameButton9.Tag = "8";
            this.GameButton9.UseVisualStyleBackColor = false;
            this.GameButton9.Click += new System.EventHandler(this.button_click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Restart, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 131);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Restart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Restart.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Restart.Location = new System.Drawing.Point(535, 35);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(262, 50);
            this.Restart.TabIndex = 9;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(269, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2:";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "View";
            this.Text = "Tic Tac Toe";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GameButton1;
        private System.Windows.Forms.Button GameButton2;
        private System.Windows.Forms.Button GameButton3;
        private System.Windows.Forms.Button GameButton4;
        private System.Windows.Forms.Button GameButton5;
        private System.Windows.Forms.Button GameButton6;
        private System.Windows.Forms.Button GameButton7;
        private System.Windows.Forms.Button GameButton8;
        private System.Windows.Forms.Button GameButton9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

