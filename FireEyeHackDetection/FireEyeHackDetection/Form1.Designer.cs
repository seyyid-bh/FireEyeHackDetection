namespace FireEyeHackDetection
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnabout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblyarar = new System.Windows.Forms.Label();
            this.lbly32 = new System.Windows.Forms.Label();
            this.lblsystem = new System.Windows.Forms.Label();
            this.btnscn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCS = new System.Windows.Forms.Button();
            this.btnCA = new System.Windows.Forms.Button();
            this.lstfile = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnscp = new System.Windows.Forms.Button();
            this.btnlstpr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstproc = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnabout);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblyarar);
            this.groupBox1.Controls.Add(this.lbly32);
            this.groupBox1.Controls.Add(this.lblsystem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection:";
            // 
            // btnabout
            // 
            this.btnabout.Location = new System.Drawing.Point(329, 84);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(75, 23);
            this.btnabout.TabIndex = 12;
            this.btnabout.Text = "About";
            this.btnabout.UseVisualStyleBackColor = true;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update Rule";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblyarar
            // 
            this.lblyarar.AutoSize = true;
            this.lblyarar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblyarar.Location = new System.Drawing.Point(17, 54);
            this.lblyarar.Name = "lblyarar";
            this.lblyarar.Size = new System.Drawing.Size(42, 16);
            this.lblyarar.TabIndex = 7;
            this.lblyarar.Text = "label3";
            // 
            // lbly32
            // 
            this.lbly32.AutoSize = true;
            this.lbly32.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbly32.Location = new System.Drawing.Point(17, 20);
            this.lbly32.Name = "lbly32";
            this.lbly32.Size = new System.Drawing.Size(42, 16);
            this.lbly32.TabIndex = 6;
            this.lbly32.Text = "label3";
            // 
            // lblsystem
            // 
            this.lblsystem.AutoSize = true;
            this.lblsystem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblsystem.Location = new System.Drawing.Point(17, 87);
            this.lblsystem.Name = "lblsystem";
            this.lblsystem.Size = new System.Drawing.Size(32, 16);
            this.lblsystem.TabIndex = 4;
            this.lblsystem.Text = "ssss";
            // 
            // btnscn
            // 
            this.btnscn.Location = new System.Drawing.Point(188, 359);
            this.btnscn.Name = "btnscn";
            this.btnscn.Size = new System.Drawing.Size(166, 52);
            this.btnscn.TabIndex = 10;
            this.btnscn.Text = "Scan";
            this.btnscn.UseVisualStyleBackColor = true;
            this.btnscn.Click += new System.EventHandler(this.btnscn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Select Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCS);
            this.groupBox2.Controls.Add(this.btnscn);
            this.groupBox2.Controls.Add(this.btnCA);
            this.groupBox2.Controls.Add(this.lstfile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(629, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 421);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File List:";
            // 
            // btnCS
            // 
            this.btnCS.Location = new System.Drawing.Point(97, 388);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(85, 23);
            this.btnCS.TabIndex = 3;
            this.btnCS.Text = "Clear Selected";
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // btnCA
            // 
            this.btnCA.Location = new System.Drawing.Point(9, 388);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(82, 23);
            this.btnCA.TabIndex = 2;
            this.btnCA.Text = "Clear All";
            this.btnCA.UseVisualStyleBackColor = true;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // lstfile
            // 
            this.lstfile.FormattingEnabled = true;
            this.lstfile.HorizontalScrollbar = true;
            this.lstfile.Location = new System.Drawing.Point(6, 37);
            this.lstfile.Name = "lstfile";
            this.lstfile.ScrollAlwaysVisible = true;
            this.lstfile.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstfile.Size = new System.Drawing.Size(348, 316);
            this.lstfile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "List Of the File To Scan:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 294);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resualt:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(398, 263);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnscp);
            this.groupBox4.Controls.Add(this.btnlstpr);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lstproc);
            this.groupBox4.Location = new System.Drawing.Point(428, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 421);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proccess";
            // 
            // btnscp
            // 
            this.btnscp.Location = new System.Drawing.Point(101, 390);
            this.btnscp.Name = "btnscp";
            this.btnscp.Size = new System.Drawing.Size(88, 23);
            this.btnscp.TabIndex = 3;
            this.btnscp.Text = "Scan Process";
            this.btnscp.UseVisualStyleBackColor = true;
            this.btnscp.Click += new System.EventHandler(this.btnscp_Click);
            // 
            // btnlstpr
            // 
            this.btnlstpr.Location = new System.Drawing.Point(10, 390);
            this.btnlstpr.Name = "btnlstpr";
            this.btnlstpr.Size = new System.Drawing.Size(91, 23);
            this.btnlstpr.TabIndex = 2;
            this.btnlstpr.Text = "List of Proccess";
            this.btnlstpr.UseVisualStyleBackColor = true;
            this.btnlstpr.Click += new System.EventHandler(this.btnlstpr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of the Process";
            // 
            // lstproc
            // 
            this.lstproc.FormattingEnabled = true;
            this.lstproc.Location = new System.Drawing.Point(10, 36);
            this.lstproc.Name = "lstproc";
            this.lstproc.Size = new System.Drawing.Size(185, 342);
            this.lstproc.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FireEyeHack Detection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsystem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnCA;
        private System.Windows.Forms.Label lblyarar;
        private System.Windows.Forms.Label lbly32;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnscn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnscp;
        private System.Windows.Forms.Button btnlstpr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstproc;
        private System.Windows.Forms.Button btnabout;
    }
}

