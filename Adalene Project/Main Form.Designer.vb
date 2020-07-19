<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OwnershipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdaleneDataSet = New Adalene_Project.AdaleneDataSet()
        Me.radAll = New System.Windows.Forms.RadioButton()
        Me.radCompany = New System.Windows.Forms.RadioButton()
        Me.radFranchisee = New System.Windows.Forms.RadioButton()
        Me.StoresTableAdapter = New Adalene_Project.AdaleneDataSetTableAdapters.StoresTableAdapter()
        Me.TableAdapterManager = New Adalene_Project.AdaleneDataSetTableAdapters.TableAdapterManager()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdaleneDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StoreDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.SalesDataGridViewTextBoxColumn, Me.OwnershipDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(399, 355)
        Me.DataGridView1.TabIndex = 0
        '
        'StoreDataGridViewTextBoxColumn
        '
        Me.StoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.StoreDataGridViewTextBoxColumn.DataPropertyName = "Store"
        Me.StoreDataGridViewTextBoxColumn.HeaderText = "Store"
        Me.StoreDataGridViewTextBoxColumn.Name = "StoreDataGridViewTextBoxColumn"
        Me.StoreDataGridViewTextBoxColumn.ReadOnly = True
        Me.StoreDataGridViewTextBoxColumn.Width = 59
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        Me.CityDataGridViewTextBoxColumn.Width = 53
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        Me.StateDataGridViewTextBoxColumn.Width = 58
        '
        'SalesDataGridViewTextBoxColumn
        '
        Me.SalesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SalesDataGridViewTextBoxColumn.DataPropertyName = "Sales"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.SalesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SalesDataGridViewTextBoxColumn.HeaderText = "Sales"
        Me.SalesDataGridViewTextBoxColumn.Name = "SalesDataGridViewTextBoxColumn"
        Me.SalesDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalesDataGridViewTextBoxColumn.Width = 58
        '
        'OwnershipDataGridViewTextBoxColumn
        '
        Me.OwnershipDataGridViewTextBoxColumn.DataPropertyName = "Ownership"
        Me.OwnershipDataGridViewTextBoxColumn.HeaderText = "Ownership"
        Me.OwnershipDataGridViewTextBoxColumn.Name = "OwnershipDataGridViewTextBoxColumn"
        Me.OwnershipDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StoresBindingSource
        '
        Me.StoresBindingSource.DataMember = "Stores"
        Me.StoresBindingSource.DataSource = Me.AdaleneDataSet
        '
        'AdaleneDataSet
        '
        Me.AdaleneDataSet.DataSetName = "AdaleneDataSet"
        Me.AdaleneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'radAll
        '
        Me.radAll.AutoSize = True
        Me.radAll.Checked = True
        Me.radAll.Location = New System.Drawing.Point(431, 12)
        Me.radAll.Name = "radAll"
        Me.radAll.Size = New System.Drawing.Size(73, 19)
        Me.radAll.TabIndex = 1
        Me.radAll.TabStop = True
        Me.radAll.Text = "&All stores"
        Me.radAll.UseVisualStyleBackColor = True
        '
        'radCompany
        '
        Me.radCompany.AutoSize = True
        Me.radCompany.Location = New System.Drawing.Point(431, 48)
        Me.radCompany.Name = "radCompany"
        Me.radCompany.Size = New System.Drawing.Size(118, 19)
        Me.radCompany.TabIndex = 2
        Me.radCompany.Text = "&Company-owned"
        Me.radCompany.UseVisualStyleBackColor = True
        '
        'radFranchisee
        '
        Me.radFranchisee.AutoSize = True
        Me.radFranchisee.Location = New System.Drawing.Point(431, 86)
        Me.radFranchisee.Name = "radFranchisee"
        Me.radFranchisee.Size = New System.Drawing.Size(86, 19)
        Me.radFranchisee.TabIndex = 3
        Me.radFranchisee.Text = "&Franchisees"
        Me.radFranchisee.UseVisualStyleBackColor = True
        '
        'StoresTableAdapter
        '
        Me.StoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StoresTableAdapter = Me.StoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Adalene_Project.AdaleneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(431, 129)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(431, 159)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 370)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.radFranchisee)
        Me.Controls.Add(Me.radCompany)
        Me.Controls.Add(Me.radAll)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adalene Fashions"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdaleneDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents radAll As RadioButton
    Friend WithEvents radCompany As RadioButton
    Friend WithEvents radFranchisee As RadioButton
    Friend WithEvents AdaleneDataSet As AdaleneDataSet
    Friend WithEvents StoresBindingSource As BindingSource
    Friend WithEvents StoresTableAdapter As AdaleneDataSetTableAdapters.StoresTableAdapter
    Friend WithEvents TableAdapterManager As AdaleneDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StoreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OwnershipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
End Class
