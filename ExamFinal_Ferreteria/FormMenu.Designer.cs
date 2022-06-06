namespace ExamFinal_Ferreteria
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInventario = new System.Windows.Forms.Button();
            this.buttonsalir = new System.Windows.Forms.Button();
            this.buttonProveedores = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ferreteria \"El Obrero\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elija una Opción:";
            // 
            // buttonInventario
            // 
            this.buttonInventario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInventario.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventario.Location = new System.Drawing.Point(42, 425);
            this.buttonInventario.Name = "buttonInventario";
            this.buttonInventario.Size = new System.Drawing.Size(231, 72);
            this.buttonInventario.TabIndex = 2;
            this.buttonInventario.Text = "Inventario";
            this.buttonInventario.UseVisualStyleBackColor = false;
            this.buttonInventario.Click += new System.EventHandler(this.buttonInventario_Click);
            // 
            // buttonsalir
            // 
            this.buttonsalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonsalir.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalir.ForeColor = System.Drawing.Color.Brown;
            this.buttonsalir.Location = new System.Drawing.Point(328, 531);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(231, 72);
            this.buttonsalir.TabIndex = 3;
            this.buttonsalir.Text = "Salir";
            this.buttonsalir.UseVisualStyleBackColor = false;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // buttonProveedores
            // 
            this.buttonProveedores.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonProveedores.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProveedores.Location = new System.Drawing.Point(615, 425);
            this.buttonProveedores.Name = "buttonProveedores";
            this.buttonProveedores.Size = new System.Drawing.Size(231, 72);
            this.buttonProveedores.TabIndex = 4;
            this.buttonProveedores.Text = "Proveedores";
            this.buttonProveedores.UseVisualStyleBackColor = false;
            this.buttonProveedores.Click += new System.EventHandler(this.buttonProveedores_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClientes.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.Location = new System.Drawing.Point(328, 425);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(231, 72);
            this.buttonClientes.TabIndex = 5;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(894, 697);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonProveedores);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.buttonInventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInventario;
        private System.Windows.Forms.Button buttonsalir;
        private System.Windows.Forms.Button buttonProveedores;
        private System.Windows.Forms.Button buttonClientes;
    }
}