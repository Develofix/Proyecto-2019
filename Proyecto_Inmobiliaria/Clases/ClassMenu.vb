Public Class ClassMenu
    Inherits MenuStrip

    Friend WithEvents MnuStIUsuario As New ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As New ToolStripSeparator
    Friend WithEvents MnuStICerrarSesion As New ToolStripMenuItem
    Friend WithEvents MnuStIOpciones As New ToolStripMenuItem
    Friend WithEvents MnuStITemas As New ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As New ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As New ToolStripTextBox
    Friend WithEvents MnuStIAzul As New ToolStripMenuItem
    Friend WithEvents MnuStIMarron As New ToolStripMenuItem
    Friend WithEvents MnuStIGris As New ToolStripMenuItem
    Friend WithEvents MnuStIModo As New ToolStripMenuItem
    Friend WithEvents TraslúcidoToolStripMenuItem As New ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As New ToolStripMenuItem
    Friend WithEvents MnuStIRestaurarApariencia As New ToolStripMenuItem







    Public Sub New(ventana As Form)


        ventana.Controls.Add(Me)

        'MnuStIRestaurarApariencia
        '
        MnuStIRestaurarApariencia.Name = "MnuStIRestaurarApariencia"
        MnuStIRestaurarApariencia.Size = New System.Drawing.Size(180, 22)
        MnuStIRestaurarApariencia.Text = "Restaurar apariencia"
        '

        'MnuStIModo
        '
        MnuStIModo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {TraslúcidoToolStripMenuItem, NormalToolStripMenuItem})
        MnuStIModo.Name = "MnuStIModo"
        MnuStIModo.Size = New System.Drawing.Size(180, 22)
        MnuStIModo.Text = "Modo"

        'NormalToolStripMenuItem
        '
        NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        NormalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        NormalToolStripMenuItem.Text = "Sólido"
        '
        'MnuStIOpciones
        '
        MnuStIOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {MnuStITemas, MnuStIModo, MnuStIRestaurarApariencia})
        MnuStIOpciones.Name = "MnuStIOpciones"
        MnuStIOpciones.Size = New System.Drawing.Size(69, 20)
        MnuStIOpciones.Text = "Opciones"



        'MnuStITemas
        '
        MnuStITemas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {MnuStIAzul, MnuStIMarron, MnuStIGris})
        MnuStITemas.Name = "MnuStITemas"
        MnuStITemas.Size = New System.Drawing.Size(180, 22)
        MnuStITemas.Text = "Temas"
        '
        'MnuStIAzul
        '
        MnuStIAzul.Name = "MnuStIAzul"
        MnuStIAzul.Size = New System.Drawing.Size(180, 22)
        MnuStIAzul.Text = "Tema Azul"
        '
        'MnuStIMarron
        '
        MnuStIMarron.Name = "MnuStIMarron"
        MnuStIMarron.Size = New System.Drawing.Size(180, 22)
        MnuStIMarron.Text = "Tema Marrón"
        '
        'MnuStIGris
        '
        MnuStIGris.Name = "MnuStIGris"
        MnuStIGris.Size = New System.Drawing.Size(180, 22)
        MnuStIGris.Text = "Tema Negro"
        '

        '
        'TraslúcidoToolStripMenuItem
        '
        TraslúcidoToolStripMenuItem.Name = "TraslúcidoToolStripMenuItem"
        TraslúcidoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        TraslúcidoToolStripMenuItem.Text = "Traslúcido"



        'MnuStICerrarSesion
        '
        MnuStICerrarSesion.Name = "MnuStICerrarSesion"
        MnuStICerrarSesion.Size = New System.Drawing.Size(143, 22)
        MnuStICerrarSesion.Text = "Ir al login"


        '
        'MnuStIUsuario
        '
        MnuStIUsuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {ToolStripSeparator1, MnuStICerrarSesion})
        MnuStIUsuario.Name = "MnuStIUsuario"
        MnuStIUsuario.Size = New System.Drawing.Size(59, 20)
        MnuStIUsuario.Text = "Usuario"

        'MnuStOpciones
        '

        Me.Dock = DockStyle.None
        Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {MnuStIUsuario, MnuStIOpciones})
        Me.Location = New System.Drawing.Point(0, 1)
        Me.Name = "MnuStOpciones"
        Me.Size = New System.Drawing.Size(256, 24)
        Me.TabIndex = 27
        Me.Text = "MenuStrip1"
    End Sub

    'Tema azul

    Private Sub MnuStIAzul_Click(sender As Object, e As EventArgs) Handles MnuStIAzul.Click

        azul(My.Application.OpenForms(0))
    End Sub

    'Tema marron

    Private Sub SubMnuStIMarron_Click(sender As Object, e As EventArgs) Handles MnuStIMarron.Click

        marron(My.Application.OpenForms(0))
    End Sub

    'Tema Gris

    Private Sub MnuStIGris_Click(sender As Object, e As EventArgs) Handles MnuStIGris.Click

        gris(My.Application.OpenForms(0))
    End Sub



    'Modo Translucido
    Private Sub TraslúcidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraslúcidoToolStripMenuItem.Click
        Metodos.cambiaropacidad(My.Application.OpenForms(0), 0.9)
    End Sub
    'Modo Opaco
    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Metodos.cambiaropacidad(My.Application.OpenForms(0), 1)
    End Sub
    'Restaurar apariencia
    Private Sub MnuStIRestaurarApariencia_Click(sender As Object, e As EventArgs) Handles MnuStIRestaurarApariencia.Click
        azul(My.Application.OpenForms(0))
        Metodos.cambiaropacidad(My.Application.OpenForms(0), 1)
    End Sub

    Private Sub MnuStICerrarSesion_Click(sender As Object, e As EventArgs) Handles MnuStICerrarSesion.Click
        Metodos.volverlogin(My.Application.OpenForms(0))
        Metodos.log = False
    End Sub
End Class
