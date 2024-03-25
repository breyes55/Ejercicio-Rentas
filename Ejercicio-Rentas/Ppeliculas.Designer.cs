
namespace Ejercicio_Rentas
{
    partial class Ppeliculas
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpeliculaid = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lblpeliculaid = new System.Windows.Forms.Label();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.dgpeliculas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtautores = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgpeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(404, 397);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 48);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(291, 397);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(96, 48);
            this.BtnGuardar.TabIndex = 34;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(188, 210);
            this.txtgenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(389, 26);
            this.txtgenero.TabIndex = 33;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(188, 155);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(389, 26);
            this.txtnombre.TabIndex = 32;
            // 
            // txtpeliculaid
            // 
            this.txtpeliculaid.Location = new System.Drawing.Point(188, 96);
            this.txtpeliculaid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpeliculaid.Name = "txtpeliculaid";
            this.txtpeliculaid.ReadOnly = true;
            this.txtpeliculaid.Size = new System.Drawing.Size(112, 26);
            this.txtpeliculaid.TabIndex = 31;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.Location = new System.Drawing.Point(724, 98);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(84, 24);
            this.cbEstado.TabIndex = 30;
            this.cbEstado.Text = "Activo";
            this.cbEstado.UseVisualStyleBackColor = true;
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre";
            // 
            // Lblpeliculaid
            // 
            this.Lblpeliculaid.AutoSize = true;
            this.Lblpeliculaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpeliculaid.Location = new System.Drawing.Point(41, 100);
            this.Lblpeliculaid.Name = "Lblpeliculaid";
            this.Lblpeliculaid.Size = new System.Drawing.Size(111, 25);
            this.Lblpeliculaid.TabIndex = 27;
            this.Lblpeliculaid.Text = "Pelicula id";
            // 
            // cbActivos
            // 
            this.cbActivos.AutoSize = true;
            this.cbActivos.Location = new System.Drawing.Point(66, 421);
            this.cbActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(175, 24);
            this.cbActivos.TabIndex = 26;
            this.cbActivos.Text = "Mostrar solo activas";
            this.cbActivos.UseVisualStyleBackColor = true;
            // 
            // dgpeliculas
            // 
            this.dgpeliculas.AllowUserToAddRows = false;
            this.dgpeliculas.AllowUserToDeleteRows = false;
            this.dgpeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpeliculas.Location = new System.Drawing.Point(46, 477);
            this.dgpeliculas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgpeliculas.Name = "dgpeliculas";
            this.dgpeliculas.ReadOnly = true;
            this.dgpeliculas.RowHeadersWidth = 51;
            this.dgpeliculas.RowTemplate.Height = 24;
            this.dgpeliculas.Size = new System.Drawing.Size(1120, 354);
            this.dgpeliculas.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Catalogo de Peliculas";
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(188, 312);
            this.txtexistencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(389, 26);
            this.txtexistencia.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Existencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Autores";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(188, 363);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(389, 26);
            this.txtprecio.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Precio";
            // 
            // txtautores
            // 
            this.txtautores.Location = new System.Drawing.Point(188, 257);
            this.txtautores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtautores.Name = "txtautores";
            this.txtautores.Size = new System.Drawing.Size(389, 26);
            this.txtautores.TabIndex = 38;
            // 
            // Ppeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 1050);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.txtautores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtpeliculaid);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lblpeliculaid);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.dgpeliculas);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "Ppeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ppeliculas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgpeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpeliculaid;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lblpeliculaid;
        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.DataGridView dgpeliculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtautores;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}