namespace Simon
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox_1
            // 
            this.pictureBox_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_1.Image = global::Simon.Properties.Resources.cr1;
            this.pictureBox_1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_1.Name = "pictureBox_1";
            this.pictureBox_1.Size = new System.Drawing.Size(201, 185);
            this.pictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_1.TabIndex = 0;
            this.pictureBox_1.TabStop = false;
            this.pictureBox_1.Click += new System.EventHandler(this.pb1_Click);
            this.pictureBox_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox_2
            // 
            this.pictureBox_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_2.Image = global::Simon.Properties.Resources.cam1;
            this.pictureBox_2.Location = new System.Drawing.Point(210, 3);
            this.pictureBox_2.Name = "pictureBox_2";
            this.pictureBox_2.Size = new System.Drawing.Size(201, 185);
            this.pictureBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_2.TabIndex = 1;
            this.pictureBox_2.TabStop = false;
            this.pictureBox_2.Click += new System.EventHandler(this.pb1_Click);
            this.pictureBox_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // pictureBox_3
            // 
            this.pictureBox_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_3.Image = global::Simon.Properties.Resources.cv1;
            this.pictureBox_3.Location = new System.Drawing.Point(3, 194);
            this.pictureBox_3.Name = "pictureBox_3";
            this.pictureBox_3.Size = new System.Drawing.Size(201, 186);
            this.pictureBox_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_3.TabIndex = 2;
            this.pictureBox_3.TabStop = false;
            this.pictureBox_3.Click += new System.EventHandler(this.pb1_Click);
            this.pictureBox_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pictureBox_4
            // 
            this.pictureBox_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_4.Image = global::Simon.Properties.Resources.ca1;
            this.pictureBox_4.Location = new System.Drawing.Point(210, 194);
            this.pictureBox_4.Name = "pictureBox_4";
            this.pictureBox_4.Size = new System.Drawing.Size(201, 186);
            this.pictureBox_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_4.TabIndex = 3;
            this.pictureBox_4.TabStop = false;
            this.pictureBox_4.Click += new System.EventHandler(this.pb1_Click);
            this.pictureBox_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            this.pictureBox_4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(527, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 102);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(527, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 102);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simon";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(827, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Points: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(827, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox_1;
        private System.Windows.Forms.PictureBox pictureBox_2;
        private System.Windows.Forms.PictureBox pictureBox_3;
        private System.Windows.Forms.PictureBox pictureBox_4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

