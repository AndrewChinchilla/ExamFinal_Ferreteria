namespace ExamFinal_Ferreteria
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonLimpiarDt = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxproducto = new System.Windows.Forms.TextBox();
            this.textBoxPrecioP = new System.Windows.Forms.TextBox();
            this.textBoxcosto = new System.Windows.Forms.TextBox();
            this.textBoxIngreso = new System.Windows.Forms.TextBox();
            this.textBoxexistencias = new System.Windows.Forms.TextBox();
            this.textBoxtipoPro = new System.Windows.Forms.TextBox();
            this.textBoxCODIGO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(58, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 296);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Controles";
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAñadir.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadir.ForeColor = System.Drawing.Color.White;
            this.buttonAñadir.Location = new System.Drawing.Point(39, 367);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(136, 52);
            this.buttonAñadir.TabIndex = 4;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = false;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttoneliminar.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.ForeColor = System.Drawing.Color.White;
            this.buttoneliminar.Location = new System.Drawing.Point(181, 367);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(126, 52);
            this.buttoneliminar.TabIndex = 5;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonLimpiarDt
            // 
            this.buttonLimpiarDt.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonLimpiarDt.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarDt.ForeColor = System.Drawing.Color.White;
            this.buttonLimpiarDt.Location = new System.Drawing.Point(181, 425);
            this.buttonLimpiarDt.Name = "buttonLimpiarDt";
            this.buttonLimpiarDt.Size = new System.Drawing.Size(126, 52);
            this.buttonLimpiarDt.TabIndex = 6;
            this.buttonLimpiarDt.Text = "Limpiar Datos";
            this.buttonLimpiarDt.UseVisualStyleBackColor = false;
            this.buttonLimpiarDt.Click += new System.EventHandler(this.buttonLimpiarDt_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonActualizar.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.Color.White;
            this.buttonActualizar.Location = new System.Drawing.Point(38, 425);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(137, 52);
            this.buttonActualizar.TabIndex = 7;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "DATOS";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxID.Location = new System.Drawing.Point(29, 557);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(115, 25);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxproducto
            // 
            this.textBoxproducto.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproducto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxproducto.Location = new System.Drawing.Point(29, 621);
            this.textBoxproducto.Name = "textBoxproducto";
            this.textBoxproducto.Size = new System.Drawing.Size(452, 25);
            this.textBoxproducto.TabIndex = 10;
            // 
            // textBoxPrecioP
            // 
            this.textBoxPrecioP.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioP.ForeColor = System.Drawing.Color.Red;
            this.textBoxPrecioP.Location = new System.Drawing.Point(194, 683);
            this.textBoxPrecioP.Name = "textBoxPrecioP";
            this.textBoxPrecioP.Size = new System.Drawing.Size(287, 25);
            this.textBoxPrecioP.TabIndex = 11;
            // 
            // textBoxcosto
            // 
            this.textBoxcosto.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcosto.ForeColor = System.Drawing.Color.Red;
            this.textBoxcosto.Location = new System.Drawing.Point(327, 754);
            this.textBoxcosto.Name = "textBoxcosto";
            this.textBoxcosto.Size = new System.Drawing.Size(154, 25);
            this.textBoxcosto.TabIndex = 12;
            // 
            // textBoxIngreso
            // 
            this.textBoxIngreso.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngreso.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxIngreso.Location = new System.Drawing.Point(29, 754);
            this.textBoxIngreso.Name = "textBoxIngreso";
            this.textBoxIngreso.Size = new System.Drawing.Size(136, 25);
            this.textBoxIngreso.TabIndex = 13;
            // 
            // textBoxexistencias
            // 
            this.textBoxexistencias.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxexistencias.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxexistencias.Location = new System.Drawing.Point(29, 683);
            this.textBoxexistencias.Name = "textBoxexistencias";
            this.textBoxexistencias.Size = new System.Drawing.Size(136, 25);
            this.textBoxexistencias.TabIndex = 14;
            // 
            // textBoxtipoPro
            // 
            this.textBoxtipoPro.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtipoPro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxtipoPro.Location = new System.Drawing.Point(345, 557);
            this.textBoxtipoPro.Name = "textBoxtipoPro";
            this.textBoxtipoPro.Size = new System.Drawing.Size(136, 25);
            this.textBoxtipoPro.TabIndex = 15;
            // 
            // textBoxCODIGO
            // 
            this.textBoxCODIGO.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCODIGO.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxCODIGO.Location = new System.Drawing.Point(166, 557);
            this.textBoxCODIGO.Name = "textBoxCODIGO";
            this.textBoxCODIGO.Size = new System.Drawing.Size(158, 25);
            this.textBoxCODIGO.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "CÓDIGO PRODUCTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "TIPO PRODUCTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 594);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "PRODUCTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 660);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "EXISTENCIAS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 660);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "FECHA DE INGRESO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 731);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "COSTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(329, 723);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "PRECIO PÚBLICO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 791);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(471, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(501, 131);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(733, 648);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(313, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 110);
            this.button1.TabIndex = 27;
            this.button1.Text = "VOLVER AL MÉNU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 820);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCODIGO);
            this.Controls.Add(this.textBoxtipoPro);
            this.Controls.Add(this.textBoxexistencias);
            this.Controls.Add(this.textBoxIngreso);
            this.Controls.Add(this.textBoxcosto);
            this.Controls.Add(this.textBoxPrecioP);
            this.Controls.Add(this.textBoxproducto);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonLimpiarDt);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonLimpiarDt;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxproducto;
        private System.Windows.Forms.TextBox textBoxPrecioP;
        private System.Windows.Forms.TextBox textBoxcosto;
        private System.Windows.Forms.TextBox textBoxIngreso;
        private System.Windows.Forms.TextBox textBoxexistencias;
        private System.Windows.Forms.TextBox textBoxtipoPro;
        private System.Windows.Forms.TextBox textBoxCODIGO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
    }
}