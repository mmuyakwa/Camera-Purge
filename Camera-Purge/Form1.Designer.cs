namespace Camera_Purge
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.source_txt = new System.Windows.Forms.TextBox();
            this.source_btn = new System.Windows.Forms.Button();
            this.destinationFoto_txt = new System.Windows.Forms.TextBox();
            this.destinationFoto_btn = new System.Windows.Forms.Button();
            this.run_btn = new System.Windows.Forms.Button();
            this.info_lbl = new System.Windows.Forms.Label();
            this.destinationVideo_txt = new System.Windows.Forms.TextBox();
            this.destinationVideo_btn = new System.Windows.Forms.Button();
            this.ausgabe_txt = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // source_txt
            // 
            this.source_txt.Location = new System.Drawing.Point(13, 13);
            this.source_txt.Name = "source_txt";
            this.source_txt.Size = new System.Drawing.Size(333, 20);
            this.source_txt.TabIndex = 0;
            // 
            // source_btn
            // 
            this.source_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source_btn.Location = new System.Drawing.Point(352, 12);
            this.source_btn.Name = "source_btn";
            this.source_btn.Size = new System.Drawing.Size(121, 23);
            this.source_btn.TabIndex = 1;
            this.source_btn.Text = "&Source";
            this.source_btn.UseVisualStyleBackColor = true;
            this.source_btn.Click += new System.EventHandler(this.source_btn_Click);
            // 
            // destinationFoto_txt
            // 
            this.destinationFoto_txt.Location = new System.Drawing.Point(13, 65);
            this.destinationFoto_txt.Name = "destinationFoto_txt";
            this.destinationFoto_txt.Size = new System.Drawing.Size(333, 20);
            this.destinationFoto_txt.TabIndex = 2;
            // 
            // destinationFoto_btn
            // 
            this.destinationFoto_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationFoto_btn.Location = new System.Drawing.Point(352, 64);
            this.destinationFoto_btn.Name = "destinationFoto_btn";
            this.destinationFoto_btn.Size = new System.Drawing.Size(121, 23);
            this.destinationFoto_btn.TabIndex = 3;
            this.destinationFoto_btn.Text = "&Foto Destination";
            this.destinationFoto_btn.UseVisualStyleBackColor = true;
            this.destinationFoto_btn.Click += new System.EventHandler(this.destination_btn_Click);
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(352, 159);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(75, 23);
            this.run_btn.TabIndex = 4;
            this.run_btn.Text = "Copy Files";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Location = new System.Drawing.Point(13, 168);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(25, 13);
            this.info_lbl.TabIndex = 5;
            this.info_lbl.Text = "Info";
            // 
            // destinationVideo_txt
            // 
            this.destinationVideo_txt.Location = new System.Drawing.Point(13, 112);
            this.destinationVideo_txt.Name = "destinationVideo_txt";
            this.destinationVideo_txt.Size = new System.Drawing.Size(333, 20);
            this.destinationVideo_txt.TabIndex = 6;
            // 
            // destinationVideo_btn
            // 
            this.destinationVideo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationVideo_btn.Location = new System.Drawing.Point(352, 111);
            this.destinationVideo_btn.Name = "destinationVideo_btn";
            this.destinationVideo_btn.Size = new System.Drawing.Size(121, 23);
            this.destinationVideo_btn.TabIndex = 7;
            this.destinationVideo_btn.Text = "&Video Destination";
            this.destinationVideo_btn.UseVisualStyleBackColor = true;
            this.destinationVideo_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ausgabe_txt
            // 
            this.ausgabe_txt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ausgabe_txt.Location = new System.Drawing.Point(0, 188);
            this.ausgabe_txt.Multiline = true;
            this.ausgabe_txt.Name = "ausgabe_txt";
            this.ausgabe_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ausgabe_txt.Size = new System.Drawing.Size(483, 331);
            this.ausgabe_txt.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 519);
            this.Controls.Add(this.ausgabe_txt);
            this.Controls.Add(this.destinationVideo_btn);
            this.Controls.Add(this.destinationVideo_txt);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.run_btn);
            this.Controls.Add(this.destinationFoto_btn);
            this.Controls.Add(this.destinationFoto_txt);
            this.Controls.Add(this.source_btn);
            this.Controls.Add(this.source_txt);
            this.Name = "Form1";
            this.Text = "Camera-Purge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox source_txt;
        private System.Windows.Forms.Button source_btn;
        private System.Windows.Forms.TextBox destinationFoto_txt;
        private System.Windows.Forms.Button destinationFoto_btn;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.TextBox destinationVideo_txt;
        private System.Windows.Forms.Button destinationVideo_btn;
        private System.Windows.Forms.TextBox ausgabe_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

