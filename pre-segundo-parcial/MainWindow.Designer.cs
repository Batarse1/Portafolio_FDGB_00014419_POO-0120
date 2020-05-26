namespace pre_segundo_parcial
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lnlTitle = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.tableLayoutMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.tableLayoutMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnlTitle
            // 
            this.lnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutMenu.SetColumnSpan(this.lnlTitle, 6);
            this.lnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnlTitle.Font = new System.Drawing.Font("Microsoft JhengHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lnlTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lnlTitle.Location = new System.Drawing.Point(3, 66);
            this.lnlTitle.Name = "lnlTitle";
            this.lnlTitle.Size = new System.Drawing.Size(794, 90);
            this.lnlTitle.TabIndex = 0;
            this.lnlTitle.Text = "Los Pollos Hermanos";
            this.lnlTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSlogan
            // 
            this.tableLayoutMenu.SetColumnSpan(this.lblSlogan, 6);
            this.lblSlogan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSlogan.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSlogan.Location = new System.Drawing.Point(3, 380);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(794, 45);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "\"Los Pollos Hermanos, donde algo delicioso siempre se está cocinando\"";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutMenu
            // 
            this.tableLayoutMenu.ColumnCount = 6;
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutMenu.Controls.Add(this.lblSlogan, 0, 7);
            this.tableLayoutMenu.Controls.Add(this.pictureBox1, 2, 5);
            this.tableLayoutMenu.Controls.Add(this.lnlTitle, 0, 3);
            this.tableLayoutMenu.Controls.Add(this.btnInicioSesion, 4, 1);
            this.tableLayoutMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMenu.Name = "tableLayoutMenu";
            this.tableLayoutMenu.RowCount = 9;
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutMenu.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutMenu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInicioSesion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInicioSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInicioSesion.FlatAppearance.BorderSize = 0;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnInicioSesion.Location = new System.Drawing.Point(640, 22);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(120, 22);
            this.btnInicioSesion.TabIndex = 4;
            this.btnInicioSesion.Text = "Inicio de Sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click_2);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutMenu);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(19, 19);
            this.Name = "MainWindow";
            this.Text = "Los pollos hermanos";
            this.tableLayoutMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lnlTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMenu;

        #endregion
    }
}