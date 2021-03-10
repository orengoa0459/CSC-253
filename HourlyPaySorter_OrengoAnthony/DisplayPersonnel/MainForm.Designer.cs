namespace DisplayPersonnel
{
    partial class displayEmployeeData_button
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
            this.dataGridViewBox = new System.Windows.Forms.DataGridView();
            this.title_label = new System.Windows.Forms.Label();
            this.DisplayTable_button = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelDataSet = new DisplayPersonnel.PersonnelDataSet();
            this.employeeTableAdapter = new DisplayPersonnel.PersonnelDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new DisplayPersonnel.PersonnelDataSetTableAdapters.TableAdapterManager();
            this.showDetails_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.ascendButton = new System.Windows.Forms.Button();
            this.descendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBox
            // 
            this.dataGridViewBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBox.Location = new System.Drawing.Point(16, 71);
            this.dataGridViewBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBox.Name = "dataGridViewBox";
            this.dataGridViewBox.Size = new System.Drawing.Size(589, 414);
            this.dataGridViewBox.TabIndex = 0;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(13, 21);
            this.title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(347, 37);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Display Employee Data";
            // 
            // DisplayTable_button
            // 
            this.DisplayTable_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DisplayTable_button.FlatAppearance.BorderSize = 3;
            this.DisplayTable_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DisplayTable_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.DisplayTable_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayTable_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTable_button.Location = new System.Drawing.Point(16, 491);
            this.DisplayTable_button.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayTable_button.Name = "DisplayTable_button";
            this.DisplayTable_button.Size = new System.Drawing.Size(100, 38);
            this.DisplayTable_button.TabIndex = 2;
            this.DisplayTable_button.Text = "Display";
            this.DisplayTable_button.UseVisualStyleBackColor = true;
            this.DisplayTable_button.Click += new System.EventHandler(this.displayEmployee_button_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.personnelDataSet;
            // 
            // personnelDataSet
            // 
            this.personnelDataSet.DataSetName = "PersonnelDataSet";
            this.personnelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = DisplayPersonnel.PersonnelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // showDetails_button
            // 
            this.showDetails_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showDetails_button.FlatAppearance.BorderSize = 3;
            this.showDetails_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.showDetails_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.showDetails_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showDetails_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetails_button.Location = new System.Drawing.Point(135, 493);
            this.showDetails_button.Margin = new System.Windows.Forms.Padding(4);
            this.showDetails_button.Name = "showDetails_button";
            this.showDetails_button.Size = new System.Drawing.Size(124, 36);
            this.showDetails_button.TabIndex = 7;
            this.showDetails_button.Text = "Add Record";
            this.showDetails_button.UseVisualStyleBackColor = true;
            this.showDetails_button.Click += new System.EventHandler(this.showDetails_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_button.FlatAppearance.BorderSize = 3;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(716, 493);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(84, 36);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // ascendButton
            // 
            this.ascendButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ascendButton.FlatAppearance.BorderSize = 3;
            this.ascendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ascendButton.Location = new System.Drawing.Point(627, 71);
            this.ascendButton.Name = "ascendButton";
            this.ascendButton.Size = new System.Drawing.Size(90, 29);
            this.ascendButton.TabIndex = 10;
            this.ascendButton.Text = "Ascend";
            this.ascendButton.UseVisualStyleBackColor = true;
            this.ascendButton.Click += new System.EventHandler(this.ascendButton_Click);
            // 
            // descendButton
            // 
            this.descendButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.descendButton.FlatAppearance.BorderSize = 3;
            this.descendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descendButton.Location = new System.Drawing.Point(627, 117);
            this.descendButton.Name = "descendButton";
            this.descendButton.Size = new System.Drawing.Size(90, 30);
            this.descendButton.TabIndex = 11;
            this.descendButton.Text = "Descend";
            this.descendButton.UseVisualStyleBackColor = true;
            this.descendButton.Click += new System.EventHandler(this.descendButton_Click);
            // 
            // displayEmployeeData_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 552);
            this.Controls.Add(this.descendButton);
            this.Controls.Add(this.ascendButton);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.showDetails_button);
            this.Controls.Add(this.DisplayTable_button);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.dataGridViewBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "displayEmployeeData_button";
            this.Text = "Employee Form Gridview";
            this.Load += new System.EventHandler(this.displayEmployeeData_button_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBox;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button DisplayTable_button;
        private PersonnelDataSet personnelDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PersonnelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private PersonnelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button showDetails_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button ascendButton;
        private System.Windows.Forms.Button descendButton;
    }
}

