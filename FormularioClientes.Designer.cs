namespace Inmobiliaria
{
    partial class FormularioClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxNombre = new System.Windows.Forms.TextBox();
            this.textboxDireccion = new System.Windows.Forms.TextBox();
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxNombre
            // 
            this.textboxNombre.Location = new System.Drawing.Point(122, 137);
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.Size = new System.Drawing.Size(100, 20);
            this.textboxNombre.TabIndex = 3;
            // 
            // textboxDireccion
            // 
            this.textboxDireccion.Location = new System.Drawing.Point(608, 126);
            this.textboxDireccion.Name = "textboxDireccion";
            this.textboxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textboxDireccion.TabIndex = 4;
            // 
            // listViewClientes
            // 
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(75, 242);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(353, 155);
            this.listViewClientes.TabIndex = 5;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            // 
            // FormularioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewClientes);
            this.Controls.Add(this.textboxDireccion);
            this.Controls.Add(this.textboxNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormularioClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textboxNombre;
        private System.Windows.Forms.TextBox textboxDireccion;
        private System.Windows.Forms.ListView listViewClientes;
    }
}