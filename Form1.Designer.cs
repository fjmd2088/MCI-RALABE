using System;
using System.Drawing;
using System.Windows.Forms;


namespace encriptador_ralabe
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
            tabControl = new TabControl();
            tabEncrypt = new TabPage();
            lblFilePathEncrypt = new Label();
            txtFilePathEncrypt = new TextBox();
            btnSelectFileEncrypt = new Button();
            btnProcessEncrypt = new Button();
            tabDecrypt = new TabPage();
            lblFilePathDecrypt = new Label();
            txtFilePathDecrypt = new TextBox();
            btnSelectFileDecrypt = new Button();
            btnProcessDecrypt = new Button();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl.SuspendLayout();
            tabEncrypt.SuspendLayout();
            tabDecrypt.SuspendLayout();
            statusStrip.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabEncrypt);
            tabControl.Controls.Add(tabDecrypt);
            tabControl.Location = new Point(6, 6);
            tabControl.Margin = new Padding(6);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1813, 387);
            tabControl.TabIndex = 0;
            // 
            // tabEncrypt
            // 
            tabEncrypt.Controls.Add(lblFilePathEncrypt);
            tabEncrypt.Controls.Add(txtFilePathEncrypt);
            tabEncrypt.Controls.Add(btnSelectFileEncrypt);
            tabEncrypt.Controls.Add(btnProcessEncrypt);
            tabEncrypt.Location = new Point(8, 46);
            tabEncrypt.Margin = new Padding(6);
            tabEncrypt.Name = "tabEncrypt";
            tabEncrypt.Padding = new Padding(19, 21, 19, 21);
            tabEncrypt.Size = new Size(1797, 333);
            tabEncrypt.TabIndex = 0;
            tabEncrypt.Text = "Encriptar";
            tabEncrypt.UseVisualStyleBackColor = true;
            // 
            // lblFilePathEncrypt
            // 
            lblFilePathEncrypt.AutoSize = true;
            lblFilePathEncrypt.Location = new Point(37, 31);
            lblFilePathEncrypt.Margin = new Padding(6, 0, 6, 0);
            lblFilePathEncrypt.Name = "lblFilePathEncrypt";
            lblFilePathEncrypt.Size = new Size(148, 32);
            lblFilePathEncrypt.TabIndex = 0;
            lblFilePathEncrypt.Text = "Archivo SQL:";
            // 
            // txtFilePathEncrypt
            // 
            txtFilePathEncrypt.Location = new Point(37, 69);
            txtFilePathEncrypt.Margin = new Padding(6);
            txtFilePathEncrypt.Name = "txtFilePathEncrypt";
            txtFilePathEncrypt.ReadOnly = true;
            txtFilePathEncrypt.Size = new Size(1508, 39);
            txtFilePathEncrypt.TabIndex = 1;
            // 
            // btnSelectFileEncrypt
            // 
            btnSelectFileEncrypt.Location = new Point(1571, 44);
            btnSelectFileEncrypt.Margin = new Padding(6);
            btnSelectFileEncrypt.Name = "btnSelectFileEncrypt";
            btnSelectFileEncrypt.Size = new Size(186, 64);
            btnSelectFileEncrypt.TabIndex = 2;
            btnSelectFileEncrypt.Text = "Seleccionar";
            btnSelectFileEncrypt.UseVisualStyleBackColor = true;
            btnSelectFileEncrypt.Click += BtnSelectFileEncrypt_Click;
            // 
            // btnProcessEncrypt
            // 
            btnProcessEncrypt.Location = new Point(722, 151);
            btnProcessEncrypt.Margin = new Padding(6);
            btnProcessEncrypt.Name = "btnProcessEncrypt";
            btnProcessEncrypt.Size = new Size(279, 85);
            btnProcessEncrypt.TabIndex = 3;
            btnProcessEncrypt.Text = "Procesar (Encriptar)";
            btnProcessEncrypt.UseVisualStyleBackColor = true;
            btnProcessEncrypt.Click += BtnProcessEncrypt_Click;
            // 
            // tabDecrypt
            // 
            tabDecrypt.Controls.Add(lblFilePathDecrypt);
            tabDecrypt.Controls.Add(txtFilePathDecrypt);
            tabDecrypt.Controls.Add(btnSelectFileDecrypt);
            tabDecrypt.Controls.Add(btnProcessDecrypt);
            tabDecrypt.Location = new Point(8, 46);
            tabDecrypt.Margin = new Padding(6);
            tabDecrypt.Name = "tabDecrypt";
            tabDecrypt.Padding = new Padding(19, 21, 19, 21);
            tabDecrypt.Size = new Size(1797, 333);
            tabDecrypt.TabIndex = 1;
            tabDecrypt.Text = "Desencriptar";
            tabDecrypt.UseVisualStyleBackColor = true;
            // 
            // lblFilePathDecrypt
            // 
            lblFilePathDecrypt.AutoSize = true;
            lblFilePathDecrypt.Location = new Point(37, 39);
            lblFilePathDecrypt.Margin = new Padding(6, 0, 6, 0);
            lblFilePathDecrypt.Name = "lblFilePathDecrypt";
            lblFilePathDecrypt.Size = new Size(193, 32);
            lblFilePathDecrypt.TabIndex = 0;
            lblFilePathDecrypt.Text = "Archivo .RALABE:";
            // 
            // txtFilePathDecrypt
            // 
            txtFilePathDecrypt.Location = new Point(37, 77);
            txtFilePathDecrypt.Margin = new Padding(6);
            txtFilePathDecrypt.Name = "txtFilePathDecrypt";
            txtFilePathDecrypt.ReadOnly = true;
            txtFilePathDecrypt.Size = new Size(1510, 39);
            txtFilePathDecrypt.TabIndex = 1;
            // 
            // btnSelectFileDecrypt
            // 
            btnSelectFileDecrypt.Location = new Point(1586, 52);
            btnSelectFileDecrypt.Margin = new Padding(6);
            btnSelectFileDecrypt.Name = "btnSelectFileDecrypt";
            btnSelectFileDecrypt.Size = new Size(186, 64);
            btnSelectFileDecrypt.TabIndex = 2;
            btnSelectFileDecrypt.Text = "Seleccionar";
            btnSelectFileDecrypt.UseVisualStyleBackColor = true;
            btnSelectFileDecrypt.Click += BtnSelectFileDecrypt_Click;
            // 
            // btnProcessDecrypt
            // 
            btnProcessDecrypt.Location = new Point(734, 183);
            btnProcessDecrypt.Margin = new Padding(6);
            btnProcessDecrypt.Name = "btnProcessDecrypt";
            btnProcessDecrypt.Size = new Size(279, 85);
            btnProcessDecrypt.TabIndex = 3;
            btnProcessDecrypt.Text = "Restaurar a SQL";
            btnProcessDecrypt.UseVisualStyleBackColor = true;
            btnProcessDecrypt.Click += BtnProcessDecrypt_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(32, 32);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 578);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 26, 0);
            statusStrip.Size = new Size(1846, 42);
            statusStrip.TabIndex = 1;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(63, 32);
            toolStripStatusLabel.Text = "Listo";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(tabControl);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(12, 142);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1822, 410);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 16);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1822, 120);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.INEGI_Logotipo_5;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(386, 0);
            label1.Name = "label1";
            label1.Size = new Size(1425, 80);
            label1.TabIndex = 1;
            label1.Text = "Encriptador Sistema de Información RALABE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1846, 620);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(statusStrip);
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encriptador RALABE";
            tabControl.ResumeLayout(false);
            tabEncrypt.ResumeLayout(false);
            tabEncrypt.PerformLayout();
            tabDecrypt.ResumeLayout(false);
            tabDecrypt.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabEncrypt;
        private TabPage tabDecrypt;

        private Label lblFilePathEncrypt;
        private TextBox txtFilePathEncrypt;
        private Button btnSelectFileEncrypt;
        private Button btnProcessEncrypt;

        private Label lblFilePathDecrypt;
        private TextBox txtFilePathDecrypt;
        private Button btnSelectFileDecrypt;
        private Button btnProcessDecrypt;

        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
