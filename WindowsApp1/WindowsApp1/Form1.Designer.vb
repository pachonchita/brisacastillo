<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer


    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblcontra = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtusuario
        '
        Me.txtusuario.BackColor = System.Drawing.SystemColors.Info
        Me.txtusuario.Location = New System.Drawing.Point(400, 85)
        Me.txtusuario.Multiline = True
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(181, 36)
        Me.txtusuario.TabIndex = 0
        '
        'txtcontraseña
        '
        Me.txtcontraseña.BackColor = System.Drawing.SystemColors.Info
        Me.txtcontraseña.Location = New System.Drawing.Point(400, 195)
        Me.txtcontraseña.Multiline = True
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(181, 37)
        Me.txtcontraseña.TabIndex = 1
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(111, 85)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(46, 13)
        Me.lblusuario.TabIndex = 2
        Me.lblusuario.Text = "Usuario:"
        '
        'lblcontra
        '
        Me.lblcontra.AutoSize = True
        Me.lblcontra.Location = New System.Drawing.Point(111, 174)
        Me.lblcontra.Name = "lblcontra"
        Me.lblcontra.Size = New System.Drawing.Size(64, 13)
        Me.lblcontra.TabIndex = 3
        Me.lblcontra.Text = "Contraseña:"
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(64, 267)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(139, 57)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "iniciar sesión"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(309, 267)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(154, 57)
        Me.Btnsalir.TabIndex = 5
        Me.Btnsalir.Text = "salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(613, 369)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblcontra)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtusuario)
        Me.Name = "Form1"
        Me.Text = "inicio de Sesión"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents lblusuario As Label
    Friend WithEvents lblcontra As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents Btnsalir As Button

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click

    End Sub
End Class
