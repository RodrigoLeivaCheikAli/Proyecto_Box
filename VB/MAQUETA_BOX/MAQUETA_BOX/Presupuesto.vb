Imports System.Data.SqlClient

Public Class Presupuesto



    Private Sub Presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_MediosP()


    End Sub
    Public Sub CopiarDatos(dgvOrigen As DataGridView)
        ' Limpiar cualquier dato existente en el DataGridView destino
        DataGridView3.Rows.Clear()


        ' Copiar las columnas, omitiendo la primera columna
        For i As Integer = 1 To dgvOrigen.Columns.Count - 1
            DataGridView3.Columns.Add(CType(dgvOrigen.Columns(i).Clone(), DataGridViewColumn))
        Next

        ' Copiar las filas
        For Each row As DataGridViewRow In dgvOrigen.Rows
            ' Crear una nueva fila en lugar de clonar la fila completa
            Dim newRow As DataGridViewRow = New DataGridViewRow()
            newRow.CreateCells(DataGridView3)

            ' Copiar las celdas, omitiendo la primera celda
            For i As Integer = 1 To row.Cells.Count - 1
                newRow.Cells(i - 1).Value = row.Cells(i).Value
            Next

            ' Agregar la nueva fila al DataGridView destino


            DataGridView3.Rows.Add(newRow)
        Next
        SumarTotalColumn()

    End Sub
    Private Sub SumarTotalColumn()
        Dim totalGeneral As Double = 0
        Dim nombreColumnaResultado As String = "Column7" ' Reemplaza con el nombre de tu columna de resultado

        For Each row As DataGridViewRow In DataGridView3.Rows
            If row.Cells.Count >= 2 Then ' Verificar que haya al menos dos columnas
                Dim valorAnterior As Double = 0
                Dim valorUltimo As Double = 0

                ' Convertir valores de las celdas a double
                If Not IsDBNull(row.Cells(row.Cells.Count - 1).Value) Then
                    valorAnterior = Convert.ToDouble(row.Cells(row.Cells.Count - 1).Value)
                End If

                If Not IsDBNull(row.Cells(row.Cells.Count - 3).Value) Then
                    valorUltimo = Convert.ToDouble(row.Cells(row.Cells.Count - 3).Value)
                End If

                ' Realizar la multiplicación y asignar el resultado a la columna específica
                Dim resultado As Double = valorAnterior * valorUltimo

                ' Buscar la columna por nombre y asignar el resultado
                If DataGridView3.Columns.Contains(nombreColumnaResultado) Then
                    row.Cells(nombreColumnaResultado).Value = resultado
                Else
                    ' Manejar el caso donde la columna no existe (puedes mostrar un mensaje de error o realizar otra acción)
                End If

                ' Sumar al total general
                totalGeneral += resultado
            End If
        Next

        ' Mostrar el total general en la última fila, columna específica
        If DataGridView3.Rows.Count > 0 Then
            Dim Total As DataGridViewRow = DataGridView3.Rows(DataGridView3.Rows.Count - 1)
            If DataGridView3.Columns.Contains(nombreColumnaResultado) Then
                Total.Cells(nombreColumnaResultado).Value = totalGeneral
                ' Manejar el caso donde la columna no existe (puedes mostrar un mensaje de error o realizar otra acción)
            End If
        End If


    End Sub


    Private Sub Cargar_Combo_MediosP()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Consultar_listPrecio")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboMediosP.DataSource = oDs.Tables(0)
            cboMediosP.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboMediosP.ValueMember = oDs.Tables(0).Columns(0).ToString

        End If
        oDs = Nothing
        conexion.Close()

    End Sub


    Private Sub Descuento()
        Dim valor As String
        If cboMediosP.SelectedIndex().ToString IsNot Nothing Then


            If cboMediosP.SelectedIndex = 0 Then
                valor = "10%"
            ElseIf cboMediosP.SelectedIndex = 1 Then
                valor = "5%"
            Else
                valor = "0%"
            End If
        Else
            valor = "0%"
        End If

        lblDescuento.Text = valor
    End Sub




    Private Sub cboMediosP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMediosP.SelectedIndexChanged
        Descuento()
    End Sub
End Class