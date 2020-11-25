<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BasicCalcPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CalcResultBox = New System.Windows.Forms.TextBox()
        Me.LeftValue = New System.Windows.Forms.TextBox()
        Me.RightValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Plus = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Minus = New System.Windows.Forms.Button()
        Me.Divide = New System.Windows.Forms.Button()
        Me.Multiply = New System.Windows.Forms.Button()
        Me.PrevResultIndex = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GetPreviousResult = New System.Windows.Forms.Button()
        Me.PrevResult = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ClearPrevBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CalcResultBox
        '
        Me.CalcResultBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcResultBox.Location = New System.Drawing.Point(109, 155)
        Me.CalcResultBox.Name = "CalcResultBox"
        Me.CalcResultBox.ReadOnly = True
        Me.CalcResultBox.Size = New System.Drawing.Size(286, 20)
        Me.CalcResultBox.TabIndex = 0
        '
        'LeftValue
        '
        Me.LeftValue.Location = New System.Drawing.Point(115, 38)
        Me.LeftValue.Name = "LeftValue"
        Me.LeftValue.Size = New System.Drawing.Size(100, 20)
        Me.LeftValue.TabIndex = 1
        '
        'RightValue
        '
        Me.RightValue.Location = New System.Drawing.Point(115, 70)
        Me.RightValue.Name = "RightValue"
        Me.RightValue.Size = New System.Drawing.Size(100, 20)
        Me.RightValue.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Left Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Right Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Calc Result:"
        '
        'Plus
        '
        Me.Plus.Location = New System.Drawing.Point(117, 109)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(41, 23)
        Me.Plus.TabIndex = 8
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(318, 109)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(100, 23)
        Me.ClearBtn.TabIndex = 9
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.Location = New System.Drawing.Point(164, 109)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(41, 23)
        Me.Minus.TabIndex = 10
        Me.Minus.Text = "-"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'Divide
        '
        Me.Divide.Location = New System.Drawing.Point(211, 109)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(41, 23)
        Me.Divide.TabIndex = 11
        Me.Divide.Text = "/"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'Multiply
        '
        Me.Multiply.Location = New System.Drawing.Point(258, 109)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(41, 23)
        Me.Multiply.TabIndex = 12
        Me.Multiply.Text = "x"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'PrevResultIndex
        '
        Me.PrevResultIndex.Location = New System.Drawing.Point(187, 215)
        Me.PrevResultIndex.Name = "PrevResultIndex"
        Me.PrevResultIndex.Size = New System.Drawing.Size(42, 20)
        Me.PrevResultIndex.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Previous Result Index (1-10):"
        '
        'GetPreviousResult
        '
        Me.GetPreviousResult.Location = New System.Drawing.Point(128, 252)
        Me.GetPreviousResult.Name = "GetPreviousResult"
        Me.GetPreviousResult.Size = New System.Drawing.Size(130, 23)
        Me.GetPreviousResult.TabIndex = 15
        Me.GetPreviousResult.Text = "Get Previous Result"
        Me.GetPreviousResult.UseVisualStyleBackColor = True
        '
        'PrevResult
        '
        Me.PrevResult.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PrevResult.Location = New System.Drawing.Point(109, 295)
        Me.PrevResult.Multiline = True
        Me.PrevResult.Name = "PrevResult"
        Me.PrevResult.ReadOnly = True
        Me.PrevResult.Size = New System.Drawing.Size(286, 36)
        Me.PrevResult.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Previous Result:"
        '
        'ClearPrevBtn
        '
        Me.ClearPrevBtn.Location = New System.Drawing.Point(290, 252)
        Me.ClearPrevBtn.Name = "ClearPrevBtn"
        Me.ClearPrevBtn.Size = New System.Drawing.Size(75, 23)
        Me.ClearPrevBtn.TabIndex = 18
        Me.ClearPrevBtn.Text = "Clear"
        Me.ClearPrevBtn.UseVisualStyleBackColor = True
        '
        'BasicCalcPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 577)
        Me.Controls.Add(Me.ClearPrevBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PrevResult)
        Me.Controls.Add(Me.GetPreviousResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PrevResultIndex)
        Me.Controls.Add(Me.Multiply)
        Me.Controls.Add(Me.Divide)
        Me.Controls.Add(Me.Minus)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RightValue)
        Me.Controls.Add(Me.LeftValue)
        Me.Controls.Add(Me.CalcResultBox)
        Me.Name = "BasicCalcPage"
        Me.Text = "BasicCalc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalcResultBox As TextBox
    Friend WithEvents LeftValue As TextBox
    Friend WithEvents RightValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Plus As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents Minus As Button
    Friend WithEvents Divide As Button
    Friend WithEvents Multiply As Button
    Friend WithEvents PrevResultIndex As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GetPreviousResult As Button
    Friend WithEvents PrevResult As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ClearPrevBtn As Button
End Class
