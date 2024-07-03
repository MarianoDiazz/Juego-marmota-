namespace Juego_ardilla
{
    partial class JuegoMarmota
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
            components = new System.ComponentModel.Container();
            panelJuego = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            contadorPuntos = new Label();
            contadorFallas = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelJuego
            // 
            panelJuego.BackColor = Color.Transparent;
            panelJuego.ColumnCount = 3;
            panelJuego.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            panelJuego.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            panelJuego.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            panelJuego.Location = new Point(138, 109);
            panelJuego.Name = "panelJuego";
            panelJuego.RowCount = 3;
            panelJuego.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelJuego.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelJuego.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelJuego.Size = new Size(320, 241);
            panelJuego.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.atrapame;
            pictureBox1.Location = new Point(464, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(12, 160);
            label1.Name = "label1";
            label1.Size = new Size(97, 30);
            label1.TabIndex = 2;
            label1.Text = "PUNTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 260);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 3;
            label2.Text = "FALLAS";
            // 
            // contadorPuntos
            // 
            contadorPuntos.AutoSize = true;
            contadorPuntos.BackColor = Color.Transparent;
            contadorPuntos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            contadorPuntos.ForeColor = SystemColors.Control;
            contadorPuntos.Location = new Point(42, 211);
            contadorPuntos.Name = "contadorPuntos";
            contadorPuntos.Size = new Size(25, 30);
            contadorPuntos.TabIndex = 4;
            contadorPuntos.Text = "0";
            // 
            // contadorFallas
            // 
            contadorFallas.AutoSize = true;
            contadorFallas.BackColor = Color.Transparent;
            contadorFallas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            contadorFallas.ForeColor = SystemColors.Control;
            contadorFallas.Location = new Point(42, 309);
            contadorFallas.Name = "contadorFallas";
            contadorFallas.Size = new Size(25, 30);
            contadorFallas.TabIndex = 5;
            contadorFallas.Text = "0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1100;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 50000;
            timer2.Tick += timer2_Tick;
            // 
            // JuegoMarmota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo__1_;
            ClientSize = new Size(579, 355);
            Controls.Add(contadorFallas);
            Controls.Add(contadorPuntos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panelJuego);
            Name = "JuegoMarmota";
            Text = "Form1";
            Load += JuegoMarmota_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel panelJuego;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label contadorPuntos;
        private Label contadorFallas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
