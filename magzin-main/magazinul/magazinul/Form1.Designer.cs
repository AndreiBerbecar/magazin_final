
namespace magazinul
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnCos = new System.Windows.Forms.Button();
            this.lstProdus = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lstProduse = new System.Windows.Forms.ListBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnGoleste = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPretAdidas = new System.Windows.Forms.Label();
            this.lblPretTricou = new System.Windows.Forms.Label();
            this.btnAdidas = new System.Windows.Forms.Button();
            this.pbAdidas = new System.Windows.Forms.PictureBox();
            this.btnTricou = new System.Windows.Forms.Button();
            this.pbTricou = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal.SuspendLayout();
            this.lstProdus.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTricou)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPrincipal.BackgroundImage")));
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrincipal.Controls.Add(this.btnCos);
            this.pnlPrincipal.Controls.Add(this.lstProdus);
            this.pnlPrincipal.Location = new System.Drawing.Point(309, -2);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(805, 585);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // btnCos
            // 
            this.btnCos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCos.BackgroundImage")));
            this.btnCos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCos.Location = new System.Drawing.Point(719, 0);
            this.btnCos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(85, 70);
            this.btnCos.TabIndex = 3;
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // lstProdus
            // 
            this.lstProdus.BackColor = System.Drawing.Color.Tan;
            this.lstProdus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lstProdus.Controls.Add(this.lblTotal);
            this.lstProdus.Controls.Add(this.lblPret);
            this.lstProdus.Controls.Add(this.lstProduse);
            this.lstProdus.Controls.Add(this.btnElimina);
            this.lstProdus.Controls.Add(this.btnGoleste);
            this.lstProdus.Location = new System.Drawing.Point(734, 512);
            this.lstProdus.Margin = new System.Windows.Forms.Padding(4);
            this.lstProdus.Name = "lstProdus";
            this.lstProdus.Size = new System.Drawing.Size(70, 67);
            this.lstProdus.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotal.Location = new System.Drawing.Point(485, 513);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(132, 38);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblPret
            // 
            this.lblPret.BackColor = System.Drawing.Color.Transparent;
            this.lblPret.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPret.Location = new System.Drawing.Point(659, 513);
            this.lblPret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(103, 38);
            this.lblPret.TabIndex = 4;
            // 
            // lstProduse
            // 
            this.lstProduse.BackColor = System.Drawing.Color.Linen;
            this.lstProduse.FormattingEnabled = true;
            this.lstProduse.ItemHeight = 16;
            this.lstProduse.Location = new System.Drawing.Point(348, 214);
            this.lstProduse.Margin = new System.Windows.Forms.Padding(4);
            this.lstProduse.Name = "lstProduse";
            this.lstProduse.Size = new System.Drawing.Size(165, 180);
            this.lstProduse.TabIndex = 2;
            // 
            // btnElimina
            // 
            this.btnElimina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnElimina.BackgroundImage")));
            this.btnElimina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElimina.Location = new System.Drawing.Point(737, 4);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(68, 58);
            this.btnElimina.TabIndex = 0;
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnGoleste
            // 
            this.btnGoleste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoleste.BackgroundImage")));
            this.btnGoleste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoleste.Location = new System.Drawing.Point(0, 4);
            this.btnGoleste.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoleste.Name = "btnGoleste";
            this.btnGoleste.Size = new System.Drawing.Size(68, 58);
            this.btnGoleste.TabIndex = 1;
            this.btnGoleste.UseVisualStyleBackColor = true;
            this.btnGoleste.Click += new System.EventHandler(this.btnGoleste_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.lblPretAdidas);
            this.panel2.Controls.Add(this.lblPretTricou);
            this.panel2.Controls.Add(this.btnAdidas);
            this.panel2.Controls.Add(this.pbAdidas);
            this.panel2.Controls.Add(this.btnTricou);
            this.panel2.Controls.Add(this.pbTricou);
            this.panel2.Location = new System.Drawing.Point(-3, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 583);
            this.panel2.TabIndex = 1;
            // 
            // lblPretAdidas
            // 
            this.lblPretAdidas.AutoSize = true;
            this.lblPretAdidas.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretAdidas.Location = new System.Drawing.Point(100, 477);
            this.lblPretAdidas.Name = "lblPretAdidas";
            this.lblPretAdidas.Size = new System.Drawing.Size(125, 20);
            this.lblPretAdidas.TabIndex = 5;
            this.lblPretAdidas.Text = "PRET:700 RON";
            // 
            // lblPretTricou
            // 
            this.lblPretTricou.AutoSize = true;
            this.lblPretTricou.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretTricou.Location = new System.Drawing.Point(100, 193);
            this.lblPretTricou.Name = "lblPretTricou";
            this.lblPretTricou.Size = new System.Drawing.Size(125, 20);
            this.lblPretTricou.TabIndex = 4;
            this.lblPretTricou.Text = "PRET:200 RON";
            // 
            // btnAdidas
            // 
            this.btnAdidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdidas.Location = new System.Drawing.Point(79, 519);
            this.btnAdidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdidas.Name = "btnAdidas";
            this.btnAdidas.Size = new System.Drawing.Size(159, 60);
            this.btnAdidas.TabIndex = 3;
            this.btnAdidas.Text = "ADAUGA IN COS";
            this.btnAdidas.UseVisualStyleBackColor = true;
            this.btnAdidas.Click += new System.EventHandler(this.btnAdidas_Click);
            // 
            // pbAdidas
            // 
            this.pbAdidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAdidas.BackgroundImage")));
            this.pbAdidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdidas.Location = new System.Drawing.Point(17, 306);
            this.pbAdidas.Margin = new System.Windows.Forms.Padding(4);
            this.pbAdidas.Name = "pbAdidas";
            this.pbAdidas.Size = new System.Drawing.Size(281, 167);
            this.pbAdidas.TabIndex = 2;
            this.pbAdidas.TabStop = false;
            this.pbAdidas.Click += new System.EventHandler(this.pbAdidas_Click);
            // 
            // btnTricou
            // 
            this.btnTricou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTricou.Location = new System.Drawing.Point(79, 238);
            this.btnTricou.Margin = new System.Windows.Forms.Padding(4);
            this.btnTricou.Name = "btnTricou";
            this.btnTricou.Size = new System.Drawing.Size(159, 60);
            this.btnTricou.TabIndex = 1;
            this.btnTricou.Text = "ADAUGA IN COS";
            this.btnTricou.UseVisualStyleBackColor = true;
            this.btnTricou.Click += new System.EventHandler(this.btnTricou_Click);
            // 
            // pbTricou
            // 
            this.pbTricou.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTricou.BackgroundImage")));
            this.pbTricou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTricou.Location = new System.Drawing.Point(17, 22);
            this.pbTricou.Margin = new System.Windows.Forms.Padding(4);
            this.pbTricou.Name = "pbTricou";
            this.pbTricou.Size = new System.Drawing.Size(281, 167);
            this.pbTricou.TabIndex = 0;
            this.pbTricou.TabStop = false;
            this.pbTricou.Click += new System.EventHandler(this.pbTricou_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.lstProdus.ResumeLayout(false);
            this.lstProdus.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTricou)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdidas;
        private System.Windows.Forms.PictureBox pbAdidas;
        private System.Windows.Forms.Button btnTricou;
        private System.Windows.Forms.PictureBox pbTricou;
        private System.Windows.Forms.Panel lstProdus;
        private System.Windows.Forms.ListBox lstProduse;
        private System.Windows.Forms.Button btnGoleste;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Label lblPretAdidas;
        private System.Windows.Forms.Label lblPretTricou;
    }
}

