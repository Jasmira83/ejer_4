
namespace ejer_4
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
            this.cbx_nomyedad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ascendete = new System.Windows.Forms.Button();
            this.btn_descendete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_nomyedad
            // 
            this.cbx_nomyedad.FormattingEnabled = true;
            this.cbx_nomyedad.Location = new System.Drawing.Point(34, 85);
            this.cbx_nomyedad.Name = "cbx_nomyedad";
            this.cbx_nomyedad.Size = new System.Drawing.Size(362, 34);
            this.cbx_nomyedad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "EDAD:";
            // 
            // btn_agg
            // 
            this.btn_agg.Location = new System.Drawing.Point(6, 27);
            this.btn_agg.Name = "btn_agg";
            this.btn_agg.Size = new System.Drawing.Size(106, 35);
            this.btn_agg.TabIndex = 4;
            this.btn_agg.Text = "AGREGAR";
            this.btn_agg.UseVisualStyleBackColor = true;
            this.btn_agg.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "INGRESE UN NOMBRE PORFAVOR";
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(218, 50);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(329, 28);
            this.txt_nom.TabIndex = 6;
            // 
            // txt_edad
            // 
            this.txt_edad.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad.Location = new System.Drawing.Point(611, 50);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(100, 28);
            this.txt_edad.TabIndex = 7;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(6, 116);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(106, 34);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(6, 68);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(105, 37);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "NOMBRE Y EDADES AGREGADAS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_ascendete);
            this.groupBox1.Controls.Add(this.btn_descendete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_nomyedad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 248);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LISTA ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "ORDENAR LOS DATOS DE MANERA ->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "ORDENAR LOS DATOS DE MANERA ->";
            // 
            // btn_ascendete
            // 
            this.btn_ascendete.Location = new System.Drawing.Point(279, 134);
            this.btn_ascendete.Name = "btn_ascendete";
            this.btn_ascendete.Size = new System.Drawing.Size(106, 37);
            this.btn_ascendete.TabIndex = 13;
            this.btn_ascendete.Text = "ASCENDENTE";
            this.btn_ascendete.UseVisualStyleBackColor = true;
            this.btn_ascendete.Click += new System.EventHandler(this.btn_ascendete_Click);
            // 
            // btn_descendete
            // 
            this.btn_descendete.Location = new System.Drawing.Point(279, 186);
            this.btn_descendete.Name = "btn_descendete";
            this.btn_descendete.Size = new System.Drawing.Size(106, 35);
            this.btn_descendete.TabIndex = 12;
            this.btn_descendete.Text = "DESCENDENTE";
            this.btn_descendete.UseVisualStyleBackColor = true;
            this.btn_descendete.Click += new System.EventHandler(this.btn_descendete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_agg);
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(503, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 177);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(720, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_nomyedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ascendete;
        private System.Windows.Forms.Button btn_descendete;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

