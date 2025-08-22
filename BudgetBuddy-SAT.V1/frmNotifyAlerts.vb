'------------------------------------------------------------------------------
' File:        frmNotifyAlerts.vb
' Description: Allows the user to set/update per-category spending alerts.
' Author:      Nayan
' Date:        21/08/2025
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On
Imports System.IO
Imports System.Globalization

Public Class frmNotifyAlerts

    Private ReadOnly alertFile As String = "Alerts.csv"   ' CSV format: Category,LimitAmount

    '----------------------------------------------------------------------
    ' Event: Form Load
    ' Purpose: Create the CSV if missing and pre-load saved limit if category
    '          already has an alert.
    '----------------------------------------------------------------------
    Private Sub frmNotifyAlerts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnsureAlertCsvExists()               ' Makes sure Alerts.csv exists.
        If cmbCategory.Items.Count > 0 Then
            cmbCategory.SelectedIndex = 0    ' Select first item so limit loads (if saved).
        End If
    End Sub

    '----------------------------------------------------------------------
    ' Helper: EnsureAlertCsvExists
    ' Purpose: Creates Alerts.csv with a header if it does not exist.
    '----------------------------------------------------------------------
    Private Sub EnsureAlertCsvExists()
        If Not File.Exists(alertFile) Then
            File.WriteAllText(alertFile, "Category,LimitAmount" & Environment.NewLine)
        End If
    End Sub

    '----------------------------------------------------------------------
    ' Event: Category Changed
    ' Purpose: When user picks a category, load its saved alert (if exists).
    '----------------------------------------------------------------------
    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim cat As String = SafeCategory()
        If String.IsNullOrWhiteSpace(cat) Then
            txtLimitAmount.Clear()
            Return
        End If

        Dim limit As Decimal? = GetSavedLimitForCategory(cat)
        If limit.HasValue Then
            txtLimitAmount.Text = limit.Value.ToString("0.##", CultureInfo.InvariantCulture)
        Else
            txtLimitAmount.Clear()
        End If
    End Sub

    '----------------------------------------------------------------------
    ' Helper: SafeCategory
    ' Purpose: Defensive read of selected category.
    '----------------------------------------------------------------------
    Private Function SafeCategory() As String
        If cmbCategory.SelectedItem Is Nothing Then Return String.Empty
        Return cmbCategory.SelectedItem.ToString().Trim()
    End Function

    '----------------------------------------------------------------------
    ' Helper: GetSavedLimitForCategory
    ' Purpose: Reads Alerts.csv and returns saved limit for category.
    '----------------------------------------------------------------------
    Private Function GetSavedLimitForCategory(category As String) As Decimal?
        If Not File.Exists(alertFile) Then Return Nothing

        Dim lines = File.ReadAllLines(alertFile)
        For i As Integer = 1 To lines.Length - 1   ' Skip header
            Dim line As String = lines(i).Trim()
            If line = "" Then Continue For

            Dim parts = line.Split(","c)
            If parts.Length < 2 Then Continue For

            If String.Equals(parts(0).Trim(), category, StringComparison.OrdinalIgnoreCase) Then
                Dim lim As Decimal
                If Decimal.TryParse(parts(1).Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, lim) Then
                    Return lim
                End If
            End If
        Next
        Return Nothing
    End Function

    '----------------------------------------------------------------------
    ' Event: Save Alert
    ' Purpose: Validates input and saves/updates Alerts.csv.
    '----------------------------------------------------------------------
    Private Sub btnSaveAlert_Click(sender As Object, e As EventArgs) Handles btnSaveAlert.Click
        Dim category As String = SafeCategory()
        If String.IsNullOrWhiteSpace(category) Then
            MessageBox.Show("Please select a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim limitText As String = txtLimitAmount.Text.Trim()
        Dim limitAmount As Decimal
        If Not Decimal.TryParse(limitText, NumberStyles.Any, CultureInfo.InvariantCulture, limitAmount) OrElse limitAmount < 0D Then
            MessageBox.Show("Enter a valid non-negative number (e.g. 200 or 200.50).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            UpsertAlert(category, limitAmount)
            MessageBox.Show("Alert saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error saving alert: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '----------------------------------------------------------------------
    ' Helper: UpsertAlert
    ' Purpose: Update alert if category exists, otherwise add a new one.
    '----------------------------------------------------------------------
    Private Sub UpsertAlert(category As String, limitAmount As Decimal)
        EnsureAlertCsvExists()

        Dim lines As List(Of String) = File.ReadAllLines(alertFile).ToList()
        If lines.Count = 0 Then
            lines.Add("Category,LimitAmount")
        End If

        Dim found As Boolean = False
        For i As Integer = 1 To lines.Count - 1   ' Skip header
            Dim parts = lines(i).Split(","c)
            If parts.Length < 2 Then Continue For

            If String.Equals(parts(0).Trim(), category, StringComparison.OrdinalIgnoreCase) Then
                lines(i) = $"{category},{limitAmount.ToString(CultureInfo.InvariantCulture)}"
                found = True
                Exit For
            End If
        Next

        If Not found Then
            lines.Add($"{category},{limitAmount.ToString(CultureInfo.InvariantCulture)}")
        End If

        File.WriteAllLines(alertFile, lines)
    End Sub



    '----------------------------------------------------------------------
    ' OPTIONAL: Close button handler (if you have a Close/Back button).
    '----------------------------------------------------------------------
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() ' Keep navigation consistent with the rest of your app.
        frmDashboard.Show()
    End Sub





End Class
