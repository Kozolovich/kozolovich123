
namespace kozolovich123
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.localDbDataSet = new kozolovich123.localDbDataSet();
            this.treeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeTableAdapter = new kozolovich123.localDbDataSetTableAdapters.TreeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lifespanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.treetypeDataGridViewTextBoxColumn,
            this.habitatDataGridViewTextBoxColumn,
            this.lifespanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.treeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(216, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // localDbDataSet
            // 
            this.localDbDataSet.DataSetName = "localDbDataSet";
            this.localDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treeBindingSource
            // 
            this.treeBindingSource.DataMember = "Tree";
            this.treeBindingSource.DataSource = this.localDbDataSet;
            // 
            // treeTableAdapter
            // 
            this.treeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treetypeDataGridViewTextBoxColumn
            // 
            this.treetypeDataGridViewTextBoxColumn.DataPropertyName = "tree_type";
            this.treetypeDataGridViewTextBoxColumn.HeaderText = "tree_type";
            this.treetypeDataGridViewTextBoxColumn.Name = "treetypeDataGridViewTextBoxColumn";
            // 
            // habitatDataGridViewTextBoxColumn
            // 
            this.habitatDataGridViewTextBoxColumn.DataPropertyName = "habitat";
            this.habitatDataGridViewTextBoxColumn.HeaderText = "habitat";
            this.habitatDataGridViewTextBoxColumn.Name = "habitatDataGridViewTextBoxColumn";
            // 
            // lifespanDataGridViewTextBoxColumn
            // 
            this.lifespanDataGridViewTextBoxColumn.DataPropertyName = "life_span";
            this.lifespanDataGridViewTextBoxColumn.HeaderText = "life_span";
            this.lifespanDataGridViewTextBoxColumn.Name = "lifespanDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private localDbDataSet localDbDataSet;
        private System.Windows.Forms.BindingSource treeBindingSource;
        private localDbDataSetTableAdapters.TreeTableAdapter treeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lifespanDataGridViewTextBoxColumn;
    }
}

