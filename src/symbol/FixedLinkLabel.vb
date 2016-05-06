Imports System.Runtime.InteropServices

Public Class FixedLinkLabel
    Inherits LinkLabel
    Const WM_SETCURSOR As Integer = 32, IDC_HAND As Integer = 32649

    <DllImport("user32.dll")>
    Public Shared Function LoadCursor(hInstance As Integer, lpCursorName As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SetCursor(hCursor As Integer) As Integer
    End Function

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_SETCURSOR Then
            Dim cursor As Integer = LoadCursor(0, IDC_HAND)

            SetCursor(cursor)

            m.Result = IntPtr.Zero
            Return
        End If

        MyBase.WndProc(m)
    End Sub
End Class
