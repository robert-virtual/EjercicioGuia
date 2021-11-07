
namespace EjercicioGuia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_piezas_aptas = new System.Windows.Forms.DataGridView();
            this.dgv_piezas_inaptas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.n_cantidad_procesar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.n_longuitud_pieza = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_empezar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.gb_agregar = new System.Windows.Forms.GroupBox();
            this.txt_nombre_pieza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre_lote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_piezas_aptas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_piezas_inaptas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cantidad_procesar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_longuitud_pieza)).BeginInit();
            this.gb_agregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_piezas_aptas
            // 
            this.dgv_piezas_aptas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_piezas_aptas.Location = new System.Drawing.Point(32, 306);
            this.dgv_piezas_aptas.Name = "dgv_piezas_aptas";
            this.dgv_piezas_aptas.RowHeadersWidth = 51;
            this.dgv_piezas_aptas.RowTemplate.Height = 29;
            this.dgv_piezas_aptas.Size = new System.Drawing.Size(514, 267);
            this.dgv_piezas_aptas.TabIndex = 0;
            // 
            // dgv_piezas_inaptas
            // 
            this.dgv_piezas_inaptas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_piezas_inaptas.Location = new System.Drawing.Point(642, 306);
            this.dgv_piezas_inaptas.Name = "dgv_piezas_inaptas";
            this.dgv_piezas_inaptas.RowHeadersWidth = 51;
            this.dgv_piezas_inaptas.RowTemplate.Height = 29;
            this.dgv_piezas_inaptas.Size = new System.Drawing.Size(514, 267);
            this.dgv_piezas_inaptas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Piezas Aptas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Piezas No Aptas";
            // 
            // n_cantidad_procesar
            // 
            this.n_cantidad_procesar.Location = new System.Drawing.Point(339, 95);
            this.n_cantidad_procesar.Name = "n_cantidad_procesar";
            this.n_cantidad_procesar.Size = new System.Drawing.Size(150, 27);
            this.n_cantidad_procesar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad de Piezas a Procesar";
            // 
            // n_longuitud_pieza
            // 
            this.n_longuitud_pieza.Location = new System.Drawing.Point(189, 52);
            this.n_longuitud_pieza.Name = "n_longuitud_pieza";
            this.n_longuitud_pieza.Size = new System.Drawing.Size(150, 27);
            this.n_longuitud_pieza.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Longuitud Pieza ";
            // 
            // btn_empezar
            // 
            this.btn_empezar.Location = new System.Drawing.Point(339, 140);
            this.btn_empezar.Name = "btn_empezar";
            this.btn_empezar.Size = new System.Drawing.Size(94, 29);
            this.btn_empezar.TabIndex = 3;
            this.btn_empezar.Text = "Empezar";
            this.btn_empezar.UseVisualStyleBackColor = true;
            this.btn_empezar.Click += new System.EventHandler(this.btn_empezar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(19, 98);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(94, 29);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // gb_agregar
            // 
            this.gb_agregar.Controls.Add(this.txt_nombre_pieza);
            this.gb_agregar.Controls.Add(this.btn_agregar);
            this.gb_agregar.Controls.Add(this.n_longuitud_pieza);
            this.gb_agregar.Controls.Add(this.label5);
            this.gb_agregar.Controls.Add(this.label4);
            this.gb_agregar.Location = new System.Drawing.Point(601, 43);
            this.gb_agregar.Name = "gb_agregar";
            this.gb_agregar.Size = new System.Drawing.Size(345, 161);
            this.gb_agregar.TabIndex = 5;
            this.gb_agregar.TabStop = false;
            this.gb_agregar.Text = "Agregar";
            this.gb_agregar.Visible = false;
            // 
            // txt_nombre_pieza
            // 
            this.txt_nombre_pieza.Location = new System.Drawing.Point(19, 52);
            this.txt_nombre_pieza.Name = "txt_nombre_pieza";
            this.txt_nombre_pieza.Size = new System.Drawing.Size(125, 27);
            this.txt_nombre_pieza.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre de Pieza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre de Lote";
            // 
            // txt_nombre_lote
            // 
            this.txt_nombre_lote.Location = new System.Drawing.Point(192, 95);
            this.txt_nombre_lote.Name = "txt_nombre_lote";
            this.txt_nombre_lote.Size = new System.Drawing.Size(125, 27);
            this.txt_nombre_lote.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 711);
            this.Controls.Add(this.txt_nombre_lote);
            this.Controls.Add(this.gb_agregar);
            this.Controls.Add(this.btn_empezar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.n_cantidad_procesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_piezas_inaptas);
            this.Controls.Add(this.dgv_piezas_aptas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_piezas_aptas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_piezas_inaptas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cantidad_procesar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_longuitud_pieza)).EndInit();
            this.gb_agregar.ResumeLayout(false);
            this.gb_agregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_piezas_aptas;
        private System.Windows.Forms.DataGridView dgv_piezas_inaptas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown n_cantidad_procesar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown n_longuitud_pieza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_empezar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.GroupBox gb_agregar;
        private System.Windows.Forms.TextBox txt_nombre_pieza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombre_lote;
    }
}

