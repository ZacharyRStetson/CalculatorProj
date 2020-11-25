<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RefactorCalcPage
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
        Me.CalcResult = New System.Windows.Forms.TextBox()
        Me.One = New System.Windows.Forms.Button()
        Me.Two = New System.Windows.Forms.Button()
        Me.Three = New System.Windows.Forms.Button()
        Me.Plus = New System.Windows.Forms.Button()
        Me.Minus = New System.Windows.Forms.Button()
        Me.Six = New System.Windows.Forms.Button()
        Me.Five = New System.Windows.Forms.Button()
        Me.Four = New System.Windows.Forms.Button()
        Me.Multiply = New System.Windows.Forms.Button()
        Me.Nine = New System.Windows.Forms.Button()
        Me.Eight = New System.Windows.Forms.Button()
        Me.Seven = New System.Windows.Forms.Button()
        Me.Divide = New System.Windows.Forms.Button()
        Me.Dec = New System.Windows.Forms.Button()
        Me.Zero = New System.Windows.Forms.Button()
        Me.EqualsSymbol = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.EquationStr = New System.Windows.Forms.TextBox()
        Me.MemRecall = New System.Windows.Forms.Button()
        Me.MemIndex = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CalcResult
        '
        Me.CalcResult.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CalcResult.Cursor = System.Windows.Forms.Cursors.No
        Me.CalcResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcResult.Location = New System.Drawing.Point(28, 47)
        Me.CalcResult.Multiline = True
        Me.CalcResult.Name = "CalcResult"
        Me.CalcResult.ReadOnly = True
        Me.CalcResult.Size = New System.Drawing.Size(400, 22)
        Me.CalcResult.TabIndex = 0
        Me.CalcResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'One
        '
        Me.One.Location = New System.Drawing.Point(52, 276)
        Me.One.Name = "One"
        Me.One.Size = New System.Drawing.Size(75, 42)
        Me.One.TabIndex = 4
        Me.One.Text = "1"
        Me.One.UseVisualStyleBackColor = True
        '
        'Two
        '
        Me.Two.Location = New System.Drawing.Point(145, 276)
        Me.Two.Name = "Two"
        Me.Two.Size = New System.Drawing.Size(75, 42)
        Me.Two.TabIndex = 8
        Me.Two.Text = "2"
        Me.Two.UseVisualStyleBackColor = True
        '
        'Three
        '
        Me.Three.Location = New System.Drawing.Point(237, 276)
        Me.Three.Name = "Three"
        Me.Three.Size = New System.Drawing.Size(75, 42)
        Me.Three.TabIndex = 12
        Me.Three.Text = "3"
        Me.Three.UseVisualStyleBackColor = True
        '
        'Plus
        '
        Me.Plus.Location = New System.Drawing.Point(328, 276)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(75, 42)
        Me.Plus.TabIndex = 16
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.Location = New System.Drawing.Point(328, 217)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(75, 42)
        Me.Minus.TabIndex = 20
        Me.Minus.Text = "-"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'Six
        '
        Me.Six.Location = New System.Drawing.Point(237, 217)
        Me.Six.Name = "Six"
        Me.Six.Size = New System.Drawing.Size(75, 42)
        Me.Six.TabIndex = 19
        Me.Six.Text = "6"
        Me.Six.UseVisualStyleBackColor = True
        '
        'Five
        '
        Me.Five.Location = New System.Drawing.Point(145, 217)
        Me.Five.Name = "Five"
        Me.Five.Size = New System.Drawing.Size(75, 42)
        Me.Five.TabIndex = 18
        Me.Five.Text = "5"
        Me.Five.UseVisualStyleBackColor = True
        '
        'Four
        '
        Me.Four.Location = New System.Drawing.Point(52, 217)
        Me.Four.Name = "Four"
        Me.Four.Size = New System.Drawing.Size(75, 42)
        Me.Four.TabIndex = 17
        Me.Four.Text = "4"
        Me.Four.UseVisualStyleBackColor = True
        '
        'Multiply
        '
        Me.Multiply.Location = New System.Drawing.Point(328, 158)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(75, 42)
        Me.Multiply.TabIndex = 24
        Me.Multiply.Text = "*"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'Nine
        '
        Me.Nine.Location = New System.Drawing.Point(237, 158)
        Me.Nine.Name = "Nine"
        Me.Nine.Size = New System.Drawing.Size(75, 42)
        Me.Nine.TabIndex = 23
        Me.Nine.Text = "9"
        Me.Nine.UseVisualStyleBackColor = True
        '
        'Eight
        '
        Me.Eight.Location = New System.Drawing.Point(145, 158)
        Me.Eight.Name = "Eight"
        Me.Eight.Size = New System.Drawing.Size(75, 42)
        Me.Eight.TabIndex = 22
        Me.Eight.Text = "8"
        Me.Eight.UseVisualStyleBackColor = True
        '
        'Seven
        '
        Me.Seven.Location = New System.Drawing.Point(52, 158)
        Me.Seven.Name = "Seven"
        Me.Seven.Size = New System.Drawing.Size(75, 42)
        Me.Seven.TabIndex = 21
        Me.Seven.Text = "7"
        Me.Seven.UseVisualStyleBackColor = True
        '
        'Divide
        '
        Me.Divide.Location = New System.Drawing.Point(328, 101)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(75, 42)
        Me.Divide.TabIndex = 28
        Me.Divide.Text = "/"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'Dec
        '
        Me.Dec.Location = New System.Drawing.Point(237, 334)
        Me.Dec.Name = "Dec"
        Me.Dec.Size = New System.Drawing.Size(75, 42)
        Me.Dec.TabIndex = 27
        Me.Dec.Text = "."
        Me.Dec.UseVisualStyleBackColor = True
        '
        'Zero
        '
        Me.Zero.Location = New System.Drawing.Point(145, 334)
        Me.Zero.Name = "Zero"
        Me.Zero.Size = New System.Drawing.Size(75, 42)
        Me.Zero.TabIndex = 26
        Me.Zero.Text = "0"
        Me.Zero.UseVisualStyleBackColor = True
        '
        'EqualsSymbol
        '
        Me.EqualsSymbol.Location = New System.Drawing.Point(328, 334)
        Me.EqualsSymbol.Name = "EqualsSymbol"
        Me.EqualsSymbol.Size = New System.Drawing.Size(75, 42)
        Me.EqualsSymbol.TabIndex = 25
        Me.EqualsSymbol.Text = "="
        Me.EqualsSymbol.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(52, 334)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 42)
        Me.ClearBtn.TabIndex = 29
        Me.ClearBtn.Text = "C"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'EquationStr
        '
        Me.EquationStr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EquationStr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EquationStr.Cursor = System.Windows.Forms.Cursors.No
        Me.EquationStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquationStr.Location = New System.Drawing.Point(28, 26)
        Me.EquationStr.Multiline = True
        Me.EquationStr.Name = "EquationStr"
        Me.EquationStr.ReadOnly = True
        Me.EquationStr.Size = New System.Drawing.Size(400, 25)
        Me.EquationStr.TabIndex = 30
        Me.EquationStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MemRecall
        '
        Me.MemRecall.Location = New System.Drawing.Point(52, 113)
        Me.MemRecall.Name = "MemRecall"
        Me.MemRecall.Size = New System.Drawing.Size(75, 20)
        Me.MemRecall.TabIndex = 31
        Me.MemRecall.Text = "MR"
        Me.MemRecall.UseVisualStyleBackColor = True
        '
        'MemIndex
        '
        Me.MemIndex.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MemIndex.Location = New System.Drawing.Point(145, 113)
        Me.MemIndex.Name = "MemIndex"
        Me.MemIndex.Size = New System.Drawing.Size(75, 20)
        Me.MemIndex.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = ":"
        '
        'RefactorCalcPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 428)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MemIndex)
        Me.Controls.Add(Me.MemRecall)
        Me.Controls.Add(Me.CalcResult)
        Me.Controls.Add(Me.EquationStr)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Divide)
        Me.Controls.Add(Me.Dec)
        Me.Controls.Add(Me.Zero)
        Me.Controls.Add(Me.EqualsSymbol)
        Me.Controls.Add(Me.Multiply)
        Me.Controls.Add(Me.Nine)
        Me.Controls.Add(Me.Eight)
        Me.Controls.Add(Me.Seven)
        Me.Controls.Add(Me.Minus)
        Me.Controls.Add(Me.Six)
        Me.Controls.Add(Me.Five)
        Me.Controls.Add(Me.Four)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.Three)
        Me.Controls.Add(Me.Two)
        Me.Controls.Add(Me.One)
        Me.Name = "RefactorCalcPage"
        Me.Text = "RefactorCalc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalcResult As TextBox
    Friend WithEvents One As Button
    Friend WithEvents Two As Button
    Friend WithEvents Three As Button
    Friend WithEvents Plus As Button
    Friend WithEvents Minus As Button
    Friend WithEvents Six As Button
    Friend WithEvents Five As Button
    Friend WithEvents Four As Button
    Friend WithEvents Multiply As Button
    Friend WithEvents Nine As Button
    Friend WithEvents Eight As Button
    Friend WithEvents Seven As Button
    Friend WithEvents Divide As Button
    Friend WithEvents Dec As Button
    Friend WithEvents Zero As Button
    Friend WithEvents EqualsSymbol As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents EquationStr As TextBox
    Friend WithEvents MemRecall As Button
    Friend WithEvents MemIndex As TextBox
    Friend WithEvents Label1 As Label
End Class
