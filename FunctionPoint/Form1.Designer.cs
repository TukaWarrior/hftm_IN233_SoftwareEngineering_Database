namespace FunctionPoint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_name = new TextBox();
            txt_vorname = new TextBox();
            txt_geburtsdatum = new TextBox();
            txt_heimatort = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 49);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Person";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(262, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(856, 550);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 23);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(531, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_heimatort);
            groupBox1.Controls.Add(txt_geburtsdatum);
            groupBox1.Controls.Add(txt_vorname);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 205);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Person";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 32);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 66);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Vorname";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Geburtsdatum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 131);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Heimatort";
            label3.Click += label3_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(92, 29);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(146, 23);
            txt_name.TabIndex = 4;
            // 
            // txt_vorname
            // 
            txt_vorname.Location = new Point(92, 63);
            txt_vorname.Name = "txt_vorname";
            txt_vorname.Size = new Size(146, 23);
            txt_vorname.TabIndex = 5;
            // 
            // txt_geburtsdatum
            // 
            txt_geburtsdatum.Location = new Point(92, 101);
            txt_geburtsdatum.Name = "txt_geburtsdatum";
            txt_geburtsdatum.Size = new Size(146, 23);
            txt_geburtsdatum.TabIndex = 6;
            txt_geburtsdatum.TextChanged += textBox4_TextChanged;
            // 
            // txt_heimatort
            // 
            txt_heimatort.Location = new Point(92, 128);
            txt_heimatort.Name = "txt_heimatort";
            txt_heimatort.Size = new Size(146, 23);
            txt_heimatort.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(76, 176);
            button3.Name = "button3";
            button3.Size = new Size(103, 23);
            button3.TabIndex = 8;
            button3.Text = "Add Person";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 600);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txt_vorname;
        private TextBox txt_name;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_heimatort;
        private TextBox txt_geburtsdatum;
        private Button button3;
    }
}