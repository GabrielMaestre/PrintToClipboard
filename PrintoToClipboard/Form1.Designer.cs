namespace PrintoToClipboard
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackbarOpacity = new System.Windows.Forms.TrackBar();
            this.lblValueOpacity = new System.Windows.Forms.Label();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.btnPrintFullScreen = new System.Windows.Forms.Button();
            this.btnPrintArea = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarOpacity)).BeginInit();
            this.grpConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackbarOpacity
            // 
            this.trackbarOpacity.LargeChange = 1;
            this.trackbarOpacity.Location = new System.Drawing.Point(8, 35);
            this.trackbarOpacity.Maximum = 100;
            this.trackbarOpacity.Minimum = 50;
            this.trackbarOpacity.Name = "trackbarOpacity";
            this.trackbarOpacity.Size = new System.Drawing.Size(210, 45);
            this.trackbarOpacity.SmallChange = 0;
            this.trackbarOpacity.TabIndex = 0;
            this.trackbarOpacity.TickFrequency = 5;
            this.trackbarOpacity.Value = 100;
            this.trackbarOpacity.Scroll += new System.EventHandler(this.trackbarOpacity_Scroll);
            // 
            // lblValueOpacity
            // 
            this.lblValueOpacity.AutoSize = true;
            this.lblValueOpacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueOpacity.ForeColor = System.Drawing.Color.White;
            this.lblValueOpacity.Location = new System.Drawing.Point(63, 12);
            this.lblValueOpacity.Name = "lblValueOpacity";
            this.lblValueOpacity.Size = new System.Drawing.Size(93, 16);
            this.lblValueOpacity.TabIndex = 1;
            this.lblValueOpacity.Text = "Opacity: 100%";
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.trackbarOpacity);
            this.grpConfig.Controls.Add(this.lblValueOpacity);
            this.grpConfig.ForeColor = System.Drawing.Color.White;
            this.grpConfig.Location = new System.Drawing.Point(107, 49);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(228, 85);
            this.grpConfig.TabIndex = 2;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "Config";
            // 
            // btnPrintFullScreen
            // 
            this.btnPrintFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintFullScreen.ForeColor = System.Drawing.Color.White;
            this.btnPrintFullScreen.Location = new System.Drawing.Point(3, 76);
            this.btnPrintFullScreen.Name = "btnPrintFullScreen";
            this.btnPrintFullScreen.Size = new System.Drawing.Size(98, 45);
            this.btnPrintFullScreen.TabIndex = 3;
            this.btnPrintFullScreen.Text = "Print FullScreen";
            this.btnPrintFullScreen.UseVisualStyleBackColor = true;
            this.btnPrintFullScreen.Click += new System.EventHandler(this.btnPrintFullScreen_Click);
            // 
            // btnPrintArea
            // 
            this.btnPrintArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintArea.ForeColor = System.Drawing.Color.White;
            this.btnPrintArea.Location = new System.Drawing.Point(3, 25);
            this.btnPrintArea.Name = "btnPrintArea";
            this.btnPrintArea.Size = new System.Drawing.Size(98, 45);
            this.btnPrintArea.TabIndex = 4;
            this.btnPrintArea.Text = "Print Area";
            this.btnPrintArea.UseVisualStyleBackColor = true;
            this.btnPrintArea.Click += new System.EventHandler(this.btnPrintArea_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(173, 8);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(98, 35);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "how to use Area";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(342, 141);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPrintArea);
            this.Controls.Add(this.btnPrintFullScreen);
            this.Controls.Add(this.grpConfig);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintToClipboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackbarOpacity)).EndInit();
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackbarOpacity;
        private System.Windows.Forms.Label lblValueOpacity;
        private System.Windows.Forms.GroupBox grpConfig;
        private System.Windows.Forms.Button btnPrintFullScreen;
        private System.Windows.Forms.Button btnPrintArea;
        private System.Windows.Forms.Button btnHelp;
    }
}

