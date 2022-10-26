<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHasilDiagnosa
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
        Me.dgvHasilDiagnosa = New System.Windows.Forms.DataGridView()
        CType(Me.dgvHasilDiagnosa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHasilDiagnosa
        '
        Me.dgvHasilDiagnosa.AllowUserToAddRows = False
        Me.dgvHasilDiagnosa.AllowUserToDeleteRows = False
        Me.dgvHasilDiagnosa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHasilDiagnosa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHasilDiagnosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHasilDiagnosa.Location = New System.Drawing.Point(12, 12)
        Me.dgvHasilDiagnosa.Name = "dgvHasilDiagnosa"
        Me.dgvHasilDiagnosa.ReadOnly = True
        Me.dgvHasilDiagnosa.RowHeadersVisible = False
        Me.dgvHasilDiagnosa.Size = New System.Drawing.Size(553, 275)
        Me.dgvHasilDiagnosa.TabIndex = 0
        '
        'FrmHasilDiagnosa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 299)
        Me.Controls.Add(Me.dgvHasilDiagnosa)
        Me.Name = "FrmHasilDiagnosa"
        Me.Text = "Hasil Diagnosa"
        CType(Me.dgvHasilDiagnosa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvHasilDiagnosa As DataGridView
End Class
