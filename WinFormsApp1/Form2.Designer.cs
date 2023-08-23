namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            BtnRegresar = new Button();
            BtnGamePad = new Button();
            BtnCamara = new Button();
            BtnServidor = new Button();
            PBImagenRover = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBImagenRover).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(BtnRegresar);
            panel1.Controls.Add(BtnGamePad);
            panel1.Controls.Add(BtnCamara);
            panel1.Controls.Add(BtnServidor);
            panel1.Controls.Add(PBImagenRover);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 441);
            panel1.TabIndex = 0;
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = Color.FromArgb(39, 39, 59);
            BtnRegresar.Dock = DockStyle.Top;
            BtnRegresar.FlatAppearance.BorderColor = Color.DarkSlateGray;
            BtnRegresar.FlatAppearance.BorderSize = 0;
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRegresar.ForeColor = SystemColors.InactiveCaption;
            BtnRegresar.Location = new Point(0, 295);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Padding = new Padding(15, 0, 0, 0);
            BtnRegresar.Size = new Size(150, 65);
            BtnRegresar.TabIndex = 4;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.TextAlign = ContentAlignment.MiddleLeft;
            BtnRegresar.UseVisualStyleBackColor = false;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // BtnGamePad
            // 
            BtnGamePad.BackColor = Color.FromArgb(39, 39, 59);
            BtnGamePad.Dock = DockStyle.Top;
            BtnGamePad.FlatAppearance.BorderColor = Color.DarkSlateGray;
            BtnGamePad.FlatAppearance.BorderSize = 0;
            BtnGamePad.FlatStyle = FlatStyle.Flat;
            BtnGamePad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGamePad.ForeColor = SystemColors.InactiveCaption;
            BtnGamePad.Location = new Point(0, 230);
            BtnGamePad.Name = "BtnGamePad";
            BtnGamePad.Padding = new Padding(15, 0, 0, 0);
            BtnGamePad.Size = new Size(150, 65);
            BtnGamePad.TabIndex = 3;
            BtnGamePad.Text = "Control";
            BtnGamePad.TextAlign = ContentAlignment.MiddleLeft;
            BtnGamePad.UseVisualStyleBackColor = false;
            // 
            // BtnCamara
            // 
            BtnCamara.BackColor = Color.FromArgb(39, 39, 59);
            BtnCamara.Dock = DockStyle.Top;
            BtnCamara.FlatAppearance.BorderColor = Color.DarkSlateGray;
            BtnCamara.FlatAppearance.BorderSize = 0;
            BtnCamara.FlatStyle = FlatStyle.Flat;
            BtnCamara.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCamara.ForeColor = SystemColors.InactiveCaption;
            BtnCamara.Location = new Point(0, 165);
            BtnCamara.Name = "BtnCamara";
            BtnCamara.Padding = new Padding(15, 0, 0, 0);
            BtnCamara.Size = new Size(150, 65);
            BtnCamara.TabIndex = 2;
            BtnCamara.Text = "Cámara";
            BtnCamara.TextAlign = ContentAlignment.MiddleLeft;
            BtnCamara.UseVisualStyleBackColor = false;
            // 
            // BtnServidor
            // 
            BtnServidor.BackColor = Color.FromArgb(39, 39, 59);
            BtnServidor.Dock = DockStyle.Top;
            BtnServidor.FlatAppearance.BorderColor = Color.DarkSlateGray;
            BtnServidor.FlatAppearance.BorderSize = 0;
            BtnServidor.FlatStyle = FlatStyle.Flat;
            BtnServidor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnServidor.ForeColor = SystemColors.InactiveCaption;
            BtnServidor.Location = new Point(0, 100);
            BtnServidor.Name = "BtnServidor";
            BtnServidor.Padding = new Padding(15, 0, 0, 0);
            BtnServidor.Size = new Size(150, 65);
            BtnServidor.TabIndex = 1;
            BtnServidor.Text = "Servidor";
            BtnServidor.TextAlign = ContentAlignment.MiddleLeft;
            BtnServidor.UseVisualStyleBackColor = false;
            // 
            // PBImagenRover
            // 
            PBImagenRover.Dock = DockStyle.Top;
            PBImagenRover.Location = new Point(0, 0);
            PBImagenRover.Name = "PBImagenRover";
            PBImagenRover.Size = new Size(150, 100);
            PBImagenRover.TabIndex = 1;
            PBImagenRover.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(804, 441);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuracion de conexion";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBImagenRover).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnRegresar;
        private Button BtnGamePad;
        private Button BtnCamara;
        private Button BtnServidor;
        private PictureBox PBImagenRover;
    }
}