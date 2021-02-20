namespace ProyectoBibliosoft
{
    partial class ListaPrestamos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPrestamos));
            this.Ver = new System.Windows.Forms.DataGridView();
            this.libroBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioPresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.libroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioPresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ver
            // 
            this.Ver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Ver.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Ver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ver.Location = new System.Drawing.Point(12, 179);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(749, 181);
            this.Ver.TabIndex = 0;
            this.Ver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ver_CellContentClick);
            this.Ver.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Ver_MouseDoubleClick);
            // 
            // libroBindingSource2
            // 
            this.libroBindingSource2.DataMember = "Libro";
            // 
            // prestamoBindingSource1
            // 
            this.prestamoBindingSource1.DataMember = "Prestamo";
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "Prestamo";
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataMember = "Libro";
            // 
            // usuarioPresBindingSource
            // 
            this.usuarioPresBindingSource.DataMember = "UsuarioPres";
            // 
            // prestamoBindingSource2
            // 
            this.prestamoBindingSource2.DataMember = "Prestamo";
            // 
            // libroBindingSource1
            // 
            this.libroBindingSource1.DataMember = "Libro";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(635, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 28);
            this.button4.TabIndex = 137;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(702, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 28);
            this.button5.TabIndex = 136;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(10, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 28);
            this.button9.TabIndex = 135;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 31);
            this.label5.TabIndex = 138;
            this.label5.Text = "Lista de libros prestado";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Location = new System.Drawing.Point(517, 91);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 55);
            this.button6.TabIndex = 139;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ListaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(785, 372);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Ver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioPresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Ver;
     //   private ProyectoDataSet proyectoDataSet;
        private System.Windows.Forms.BindingSource usuarioPresBindingSource;
     //   private ProyectoDataSetTableAdapters.UsuarioPresTableAdapter usuarioPresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yabeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoIdentidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
//        private BiblioSoftDataSet1 biblioSoftDataSet1;
        private System.Windows.Forms.BindingSource libroBindingSource;
//        private BiblioSoftDataSet1TableAdapters.LibroTableAdapter libroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPaginasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaImpresionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEditorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
//        private PruebaProyectoDataSet pruebaProyectoDataSet;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
//        private PruebaProyectoDataSetTableAdapters.PrestamoTableAdapter prestamoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
//        private BiblioSoftDataSet biblioSoftDataSet;
        private System.Windows.Forms.BindingSource prestamoBindingSource1;
//        private BiblioSoftDataSetTableAdapters.PrestamoTableAdapter prestamoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
 //       private BiblioSoftDataSet biblioSoftDataSet;
        private System.Windows.Forms.BindingSource prestamoBindingSource2;
//        private BiblioSoftDataSetTableAdapters.PrestamoTableAdapter prestamoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
 //       private BiblioSoftDataSet1 biblioSoftDataSet1;
        private System.Windows.Forms.BindingSource libroBindingSource1;
  //      private BiblioSoftDataSet1TableAdapters.LibroTableAdapter libroTableAdapter;
 //       private BiblioSoftDataSet2 biblioSoftDataSet2;
        private System.Windows.Forms.BindingSource libroBindingSource2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        //       private BiblioSoftDataSet2TableAdapters.LibroTableAdapter libroTableAdapter1;
    }
}