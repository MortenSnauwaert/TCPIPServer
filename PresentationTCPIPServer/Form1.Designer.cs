namespace PresentationTCPIPServer
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
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            listBox1 = new ListBox();
            splitContainer2 = new SplitContainer();
            label3 = new Label();
            textBox1 = new TextBox();
            splitContainer3 = new SplitContainer();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBox1);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(numericUpDown1);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(531, 794);
            splitContainer1.SplitterDistance = 148;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "IP-adres:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 66);
            button1.Name = "button1";
            button1.Size = new Size(151, 50);
            button1.TabIndex = 2;
            button1.Text = "Start Server";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 9);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "Poort-nummer:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(171, 33);
            numericUpDown1.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(170, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new Point(169, 66);
            button2.Name = "button2";
            button2.Size = new Size(172, 62);
            button2.TabIndex = 5;
            button2.Text = "Verbreek verbinding geselecteerde client";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(347, 7);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 124);
            listBox1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(textBox1);
            splitContainer2.Panel1.Controls.Add(label3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(531, 642);
            splitContainer2.SplitterDistance = 229;
            splitContainer2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Meldingen:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 183);
            textBox1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(textBox2);
            splitContainer3.Panel1.Controls.Add(label4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(textBox3);
            splitContainer3.Panel2.Controls.Add(comboBox2);
            splitContainer3.Panel2.Controls.Add(button4);
            splitContainer3.Panel2.Controls.Add(button3);
            splitContainer3.Panel2.Controls.Add(label5);
            splitContainer3.Size = new Size(531, 409);
            splitContainer3.SplitterDistance = 199;
            splitContainer3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 0;
            label4.Text = "Berichten:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 32);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(507, 163);
            textBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 10);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 0;
            label5.Text = "Verstuur bericht:";
            // 
            // button3
            // 
            button3.Location = new Point(12, 130);
            button3.Name = "button3";
            button3.Size = new Size(507, 29);
            button3.TabIndex = 3;
            button3.Text = "Stuur bericht naar deselcteerde client";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 165);
            button4.Name = "button4";
            button4.Size = new Size(507, 29);
            button4.TabIndex = 4;
            button4.Text = "Stuur bericht naar alle clients";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 96);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(507, 28);
            comboBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 33);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(507, 57);
            textBox3.TabIndex = 6;
            textBox3.Text = "Bericht van Server";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 794);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button2;
        private SplitContainer splitContainer2;
        private TextBox textBox1;
        private Label label3;
        private SplitContainer splitContainer3;
        private TextBox textBox2;
        private Label label4;
        private Button button3;
        private Label label5;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private Button button4;
    }
}
