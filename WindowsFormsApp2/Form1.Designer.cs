namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonSpeak = new System.Windows.Forms.Button();
            this.botonStop = new System.Windows.Forms.Button();
            this.botonBandeja = new System.Windows.Forms.Button();
            this.botonPausa = new System.Windows.Forms.Button();
            this.botonplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.botonSpeak);
            this.panel1.Controls.Add(this.botonStop);
            this.panel1.Controls.Add(this.botonBandeja);
            this.panel1.Controls.Add(this.botonPausa);
            this.panel1.Controls.Add(this.botonplay);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 115);
            this.panel1.TabIndex = 0;
            // 
            // botonSpeak
            // 
            this.botonSpeak.BackColor = System.Drawing.Color.Transparent;
            this.botonSpeak.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.conversacion;
            this.botonSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSpeak.Location = new System.Drawing.Point(509, 29);
            this.botonSpeak.Name = "botonSpeak";
            this.botonSpeak.Size = new System.Drawing.Size(80, 54);
            this.botonSpeak.TabIndex = 4;
            this.botonSpeak.UseVisualStyleBackColor = false;
            this.botonSpeak.Click += new System.EventHandler(this.botonSpeak_Click);
            // 
            // botonStop
            // 
            this.botonStop.BackColor = System.Drawing.Color.Transparent;
            this.botonStop.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.boton_detener;
            this.botonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonStop.Location = new System.Drawing.Point(397, 29);
            this.botonStop.Name = "botonStop";
            this.botonStop.Size = new System.Drawing.Size(80, 54);
            this.botonStop.TabIndex = 3;
            this.botonStop.UseVisualStyleBackColor = false;
            this.botonStop.Click += new System.EventHandler(this.botonStop_Click);
            // 
            // botonBandeja
            // 
            this.botonBandeja.BackColor = System.Drawing.Color.Transparent;
            this.botonBandeja.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.bandeja_de_entrada;
            this.botonBandeja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBandeja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBandeja.Location = new System.Drawing.Point(160, 29);
            this.botonBandeja.Name = "botonBandeja";
            this.botonBandeja.Size = new System.Drawing.Size(80, 54);
            this.botonBandeja.TabIndex = 2;
            this.botonBandeja.UseVisualStyleBackColor = false;
            this.botonBandeja.Click += new System.EventHandler(this.botonBandeja_Click);
            // 
            // botonPausa
            // 
            this.botonPausa.BackColor = System.Drawing.Color.Transparent;
            this.botonPausa.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.boton_de_pausa_de_video;
            this.botonPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPausa.Location = new System.Drawing.Point(279, 29);
            this.botonPausa.Name = "botonPausa";
            this.botonPausa.Size = new System.Drawing.Size(80, 54);
            this.botonPausa.TabIndex = 1;
            this.botonPausa.UseVisualStyleBackColor = false;
            this.botonPausa.Click += new System.EventHandler(this.botonPausa_Click);
            // 
            // botonplay
            // 
            this.botonplay.BackColor = System.Drawing.Color.Transparent;
            this.botonplay.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.boton_de_play;
            this.botonplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonplay.Location = new System.Drawing.Point(34, 29);
            this.botonplay.Name = "botonplay";
            this.botonplay.Size = new System.Drawing.Size(80, 54);
            this.botonplay.TabIndex = 0;
            this.botonplay.UseVisualStyleBackColor = false;
            this.botonplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DomBold BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lector de Texto Avanzado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(613, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonplay;
        private System.Windows.Forms.Button botonSpeak;
        private System.Windows.Forms.Button botonStop;
        private System.Windows.Forms.Button botonBandeja;
        private System.Windows.Forms.Button botonPausa;
        private System.Windows.Forms.Label label1;
    }
}

