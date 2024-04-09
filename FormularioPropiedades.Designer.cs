namespace Inmobiliaria
{
    partial class FormularioPropiedades
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
            this.Cargar = new System.Windows.Forms.Button();
            this.textBoxPrecioPorDia = new System.Windows.Forms.TextBox();
            this.listViewPropiedades = new System.Windows.Forms.ListView();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio por dia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(597, 354);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(92, 23);
            this.Cargar.TabIndex = 3;
            this.Cargar.Text = "Cargar Datos";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // textBoxPrecioPorDia
            // 
            this.textBoxPrecioPorDia.Location = new System.Drawing.Point(434, 172);
            this.textBoxPrecioPorDia.Name = "textBoxPrecioPorDia";
            this.textBoxPrecioPorDia.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioPorDia.TabIndex = 4;
            // 
            // listViewPropiedades
            // 
            this.listViewPropiedades.HideSelection = false;
            this.listViewPropiedades.Location = new System.Drawing.Point(86, 266);
            this.listViewPropiedades.Name = "listViewPropiedades";
            this.listViewPropiedades.Size = new System.Drawing.Size(437, 172);
            this.listViewPropiedades.TabIndex = 5;
            this.listViewPropiedades.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(86, 170);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 6;
            // 
            // FormularioPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.listViewPropiedades);
            this.Controls.Add(this.textBoxPrecioPorDia);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioPropiedades";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Propiedades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.TextBox textBoxPrecioPorDia;
        private System.Windows.Forms.ListView listViewPropiedades;
        private System.Windows.Forms.ComboBox comboBoxTipo;
    }
}

