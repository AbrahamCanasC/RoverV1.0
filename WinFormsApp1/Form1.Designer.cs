namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            BtnConfiguracion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1346, 702);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnConfiguracion
            // 
            BtnConfiguracion.BackColor = Color.Transparent;
            BtnConfiguracion.BackgroundImage = (Image)resources.GetObject("BtnConfiguracion.BackgroundImage");
            BtnConfiguracion.FlatStyle = FlatStyle.Popup;
            BtnConfiguracion.Location = new Point(1291, 649);
            BtnConfiguracion.Name = "BtnConfiguracion";
            BtnConfiguracion.Size = new Size(41, 41);
            BtnConfiguracion.TabIndex = 2;
            BtnConfiguracion.UseVisualStyleBackColor = false;
            BtnConfiguracion.Click += BtnConfiguracion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1344, 702);
            Controls.Add(BtnConfiguracion);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Rover V1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button BtnConfiguracion;
    }
}