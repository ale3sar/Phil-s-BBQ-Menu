Imports System
Imports System.Resources
Imports System.Drawing
Imports System.IO
Imports System.ComponentModel

Public Class Form1
    Inherits System.Windows.Forms.Form
    Const WS_EX_LAYOUTRTL = &H400000
    Const WS_EX_NOINHERITLAYOUT = &H100000

    '========================================================================================
    'code to implement on-the-fly whole-form mirroring with no inheritance
    '========================================================================================

    Private _mirrored As Boolean = False
    <Description("Change to the right-to-left layout."),
    DefaultValue(False), Localizable(True),
    Category("Appearance"), Browsable(True)>
    Public Property Mirrored() As Boolean
        Get
            Return _mirrored
        End Get
        Set(ByVal Value As Boolean)
            If _mirrored <> Value Then
                _mirrored = Value
                MyBase.OnRightToLeftChanged(EventArgs.Empty)
            End If
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim CP As System.Windows.Forms.CreateParams = MyBase.CreateParams
            If Mirrored Then
                CP.ExStyle = CP.ExStyle Or WS_EX_LAYOUTRTL Or WS_EX_NOINHERITLAYOUT
            End If
            Return CP
        End Get
    End Property

    Dim resx_cur As ResXResourceSet
    Dim resx_us As ResXResourceSet = New ResXResourceSet("en-us.resX")
    Dim resx_mx As ResXResourceSet = New ResXResourceSet("es-MX.resX")
    Dim resx_sa As ResXResourceSet = New ResXResourceSet("ar-SA.resX")




    Private Sub refreshContent()

        Label11.Text = resx_cur.GetString("Label11")
        Label12.Text = resx_cur.GetString("Label12")
        Label13.Text = resx_cur.GetString("Label13")
        Label14.Text = resx_cur.GetString("Label14")
        Label15.Text = resx_cur.GetString("Label15")
        Label16.Text = resx_cur.GetString("Label16")
        Label17.Text = resx_cur.GetString("Label17")
        Label18.Text = resx_cur.GetString("Label18")
        Label19.Text = resx_cur.GetString("Label19")
        Label110.Text = resx_cur.GetString("Label10")
        Label111.Text = resx_cur.GetString("Label111")
        Label112.Text = resx_cur.GetString("Label112")
        Label113.Text = resx_cur.GetString("Label113")
        Label114.Text = resx_cur.GetString("Label114")

        Label21.Text = resx_cur.GetString("Label21")
        Label22.Text = resx_cur.GetString("Label22")
        Label23.Text = resx_cur.GetString("Label23")
        Label24.Text = resx_cur.GetString("Label24")
        Label25.Text = resx_cur.GetString("Label25")
        Label26.Text = resx_cur.GetString("Label26")
        Label27.Text = resx_cur.GetString("Label27")
        Label28.Text = resx_cur.GetString("Label28")
        Label29.Text = resx_cur.GetString("Label29")
        Label210.Text = resx_cur.GetString("Label210")
        Label211.Text = resx_cur.GetString("Label211")
        Label212.Text = resx_cur.GetString("Label212")
        Label213.Text = resx_cur.GetString("Label213")
        Label214.Text = resx_cur.GetString("Label214")
        Label215.Text = resx_cur.GetString("Label215")
        Label216.Text = resx_cur.GetString("Label216")
        Label217.Text = resx_cur.GetString("Label217")
        Label218.Text = resx_cur.GetString("Label218")
        Label219.Text = resx_cur.GetString("Label219")
        Label220.Text = resx_cur.GetString("Label220")
        Label221.Text = resx_cur.GetString("Label221")
        Label222.Text = resx_cur.GetString("Label222")
        Label223.Text = resx_cur.GetString("Label223")
        Label224.Text = resx_cur.GetString("Label224")
        Label225.Text = resx_cur.GetString("Label225")

        Label31.Text = resx_cur.GetString("Label31")
        Label32.Text = resx_cur.GetString("Label32")
        Label33.Text = resx_cur.GetString("Label33")
        Label34.Text = resx_cur.GetString("Label34")
        Label35.Text = resx_cur.GetString("Label35")
        Label36.Text = resx_cur.GetString("Label36")
        Label37.Text = resx_cur.GetString("Label37")
        Label38.Text = resx_cur.GetString("Label38")
        Label39.Text = resx_cur.GetString("Label39")
        Label310.Text = resx_cur.GetString("Label310")
        Label311.Text = resx_cur.GetString("Label311")
        Label312.Text = resx_cur.GetString("Label312")
        Label313.Text = resx_cur.GetString("Label313")
        Label314.Text = resx_cur.GetString("Label314")
        Label315.Text = resx_cur.GetString("Label315")
        Label316.Text = resx_cur.GetString("Label316")
        Label317.Text = resx_cur.GetString("Label317")
        Label318.Text = resx_cur.GetString("Label318")
        Label319.Text = resx_cur.GetString("Label319")
        Label320.Text = resx_cur.GetString("Label320")
        Label321.Text = resx_cur.GetString("Label321")
        Label322.Text = resx_cur.GetString("Label322")
        Label323.Text = resx_cur.GetString("Label323")
        Label324.Text = resx_cur.GetString("Label324")
        Label325.Text = resx_cur.GetString("Label325")

        Label41.Text = resx_cur.GetString("Label41")
        Label42.Text = resx_cur.GetString("Label42")
        Label43.Text = resx_cur.GetString("Label43")
        Label44.Text = resx_cur.GetString("Label44")
        Label45.Text = resx_cur.GetString("Label45")
        Label46.Text = resx_cur.GetString("Label46")
        Label47.Text = resx_cur.GetString("Label47")
        Label48.Text = resx_cur.GetString("Label48")
        Label49.Text = resx_cur.GetString("Label49")
        Label410.Text = resx_cur.GetString("Label410")
        Label411.Text = resx_cur.GetString("Label411")
        Label412.Text = resx_cur.GetString("Label412")
        Label413.Text = resx_cur.GetString("Label413")
        Label414.Text = resx_cur.GetString("Label414")
        Label415.Text = resx_cur.GetString("Label415")
        Label416.Text = resx_cur.GetString("Label416")
        Label417.Text = resx_cur.GetString("Label417")
        Label418.Text = resx_cur.GetString("Label418")
        Label419.Text = resx_cur.GetString("Label419")
        Label420.Text = resx_cur.GetString("Label420")
        Label421.Text = resx_cur.GetString("Label421")
        Label422.Text = resx_cur.GetString("Label422")
        Label423.Text = resx_cur.GetString("Label423")
        Label424.Text = resx_cur.GetString("Label424")
        Label425.Text = resx_cur.GetString("Label425")
        Label426.Text = resx_cur.GetString("Label426")

        p1.Text = resx_cur.GetString("p1")
        p2.Text = resx_cur.GetString("p2")
        p3.Text = resx_cur.GetString("p3")
        p4.Text = resx_cur.GetString("p4")
        p5.Text = resx_cur.GetString("p5")
        p6.Text = resx_cur.GetString("p6")
        p7.Text = resx_cur.GetString("p7")
        p8.Text = resx_cur.GetString("p8")
        p9.Text = resx_cur.GetString("p9")
        p10.Text = resx_cur.GetString("p10")
        p11.Text = resx_cur.GetString("p11")
        p12.Text = resx_cur.GetString("p12")
        p13.Text = resx_cur.GetString("p13")
        p14.Text = resx_cur.GetString("p14")
        p15.Text = resx_cur.GetString("p15")
        p16.Text = resx_cur.GetString("p16")
        p17.Text = resx_cur.GetString("p17")
        p18.Text = resx_cur.GetString("p18")
        p19.Text = resx_cur.GetString("p19")
        p20.Text = resx_cur.GetString("p20")
        p21.Text = resx_cur.GetString("p21")
        p22.Text = resx_cur.GetString("p22")
        p23.Text = resx_cur.GetString("p23")
        p24.Text = resx_cur.GetString("p24")
        p25.Text = resx_cur.GetString("p25")
        p26.Text = resx_cur.GetString("p26")
        p27.Text = resx_cur.GetString("p27")
        p28.Text = resx_cur.GetString("p28")
        p29.Text = resx_cur.GetString("p29")
        p30.Text = resx_cur.GetString("p30")
        p31.Text = resx_cur.GetString("p31")
        p32.Text = resx_cur.GetString("p32")
        p33.Text = resx_cur.GetString("p33")
        p34.Text = resx_cur.GetString("p34")
        p35.Text = resx_cur.GetString("p35")
        p36.Text = resx_cur.GetString("p36")
        p37.Text = resx_cur.GetString("p37")
        p38.Text = resx_cur.GetString("p38")
        p39.Text = resx_cur.GetString("p39")
    End Sub

    Private Sub usFlag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usFlag.Click
        resx_cur = resx_us
        Me.Mirrored() = False
        refreshContent()
    End Sub

    Private Sub mxFlag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mxFlag.Click
        resx_cur = resx_mx
        Me.Mirrored() = False
        refreshContent()
    End Sub

    Private Sub saFlag_Click(sender As Object, e As EventArgs) Handles saFlag.Click
        resx_cur = resx_sa
        Me.Mirrored() = True
        refreshContent()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resx_cur = resx_us
        refreshContent()
    End Sub
End Class
