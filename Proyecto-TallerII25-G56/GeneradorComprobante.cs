using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Proyecto_TallerII25_G56
{
    public class GeneradorComprobante
    {
        private readonly string connectionString = @"Server=DESKTOP-JVILLBE\SQLEXPRESS;Database=Proyecto-Taller2-Grupo56;Integrated Security=True;TrustServerCertificate=True;";

        public bool GenerarComprobantePDF(int idVenta, string rutaDestino)
        {
            try
            {
                // Obtener datos de la venta
                DataTable dtVenta = ObtenerDatosVenta(idVenta);
                if (dtVenta.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Obtener detalles de la venta
                DataTable dtDetalle = ObtenerDetalleVenta(idVenta);

                // Crear el documento PDF
                Document documento = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(rutaDestino, FileMode.Create));
                documento.Open();

                // Fuentes
                iTextSharp.text.Font fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                iTextSharp.text.Font fuenteSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                iTextSharp.text.Font fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                iTextSharp.text.Font fuenteNegrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);

                // Encabezado
                Paragraph titulo = new Paragraph("COMPROBANTE DE VENTA", fuenteTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20;
                documento.Add(titulo);

                // Información del negocio
                Paragraph infoNegocio = new Paragraph();
                infoNegocio.Add(new Chunk("Supermercado\n", fuenteNegrita));
                infoNegocio.Add(new Chunk("Dirección: Av. Independencia 3050\n", fuenteNormal));
                infoNegocio.Add(new Chunk("Teléfono: (123) 456-7890\n", fuenteNormal));
                infoNegocio.Add(new Chunk("Email: super@mercado.com\n\n", fuenteNormal));
                documento.Add(infoNegocio);

                // Línea separadora
                documento.Add(new Paragraph("_____________________________________________________________________\n\n"));

                // Información de la venta
                DataRow rowVenta = dtVenta.Rows[0];

                PdfPTable tablaInfo = new PdfPTable(2);
                tablaInfo.WidthPercentage = 100;
                tablaInfo.SpacingAfter = 20;

                // Columna izquierda
                PdfPCell celdaIzq = new PdfPCell();
                celdaIzq.Border = iTextSharp.text.Rectangle.NO_BORDER;
                celdaIzq.AddElement(new Phrase($"Nº de Venta: {rowVenta["id_venta"]}", fuenteNegrita));
                celdaIzq.AddElement(new Phrase($"Fecha: {Convert.ToDateTime(rowVenta["fecha"]).ToString("dd/MM/yyyy HH:mm")}", fuenteNormal));
                tablaInfo.AddCell(celdaIzq);

                // Columna derecha
                PdfPCell celdaDer = new PdfPCell();
                celdaDer.Border = iTextSharp.text.Rectangle.NO_BORDER;
                celdaDer.AddElement(new Phrase($"Cajero: {rowVenta["cajero"]}", fuenteNormal));
                tablaInfo.AddCell(celdaDer);

                documento.Add(tablaInfo);

                // Tabla de productos
                PdfPTable tablaProductos = new PdfPTable(5);
                tablaProductos.WidthPercentage = 100;
                tablaProductos.SetWidths(new float[] { 1f, 4f, 1.5f, 1.5f, 2f });
                tablaProductos.SpacingAfter = 20;

                // Encabezados de la tabla
                string[] encabezados = { "N°", "Producto", "Cant.", "Precio Unit.",  "Subtotal" };
                foreach (string encabezado in encabezados)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(encabezado, fuenteNegrita));
                    celda.BackgroundColor = new BaseColor(220, 220, 220);
                    celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    celda.Padding = 5;
                    tablaProductos.AddCell(celda);
                }

                // Detalles de productos
                decimal totalGeneral = 0;
                int contador = 1;
                foreach (DataRow row in dtDetalle.Rows)
                {
                    int cantidad = Convert.ToInt32(row["cantidad"]);
                    decimal precioUnitario = Convert.ToDecimal(row["precio_unitario"]);
                    decimal subtotal = Convert.ToDecimal(row["subtotal"]);
                    totalGeneral += subtotal;

                    tablaProductos.AddCell(new PdfPCell(new Phrase(contador.ToString(), fuenteNormal)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5 });
                    tablaProductos.AddCell(new PdfPCell(new Phrase(row["producto"].ToString(), fuenteNormal)) { Padding = 5 });
                    tablaProductos.AddCell(new PdfPCell(new Phrase(cantidad.ToString(), fuenteNormal)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5 });
                    tablaProductos.AddCell(new PdfPCell(new Phrase(precioUnitario.ToString("C2"), fuenteNormal)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
                    tablaProductos.AddCell(new PdfPCell(new Phrase(subtotal.ToString("C2"), fuenteNormal)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
                    contador++;
                }

                documento.Add(tablaProductos);

                // Total
                PdfPTable tablaTotal = new PdfPTable(2);
                tablaTotal.WidthPercentage = 40;
                tablaTotal.HorizontalAlignment = Element.ALIGN_RIGHT;

                PdfPCell celdaTotalLabel = new PdfPCell(new Phrase("TOTAL:", fuenteNegrita));
                celdaTotalLabel.Border = iTextSharp.text.Rectangle.NO_BORDER;
                celdaTotalLabel.HorizontalAlignment = Element.ALIGN_RIGHT;
                celdaTotalLabel.Padding = 5;
                tablaTotal.AddCell(celdaTotalLabel);

                PdfPCell celdaTotalMonto = new PdfPCell(new Phrase(totalGeneral.ToString("C2"), fuenteNegrita));
                celdaTotalMonto.BackgroundColor = new BaseColor(220, 220, 220);
                celdaTotalMonto.HorizontalAlignment = Element.ALIGN_RIGHT;
                celdaTotalMonto.Padding = 5;
                tablaTotal.AddCell(celdaTotalMonto);

                documento.Add(tablaTotal);

                // Pie de página
                Paragraph piePagina = new Paragraph("\n\n¡Gracias por su compra!", fuenteNormal);
                piePagina.Alignment = Element.ALIGN_CENTER;
                documento.Add(piePagina);

                documento.Close();
                writer.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el comprobante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private DataTable ObtenerDatosVenta(int idVenta)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT 
                V.id_venta,
                V.fecha,
                U.nombre + ' ' + U.apellido AS cajero,
                V.monto_total
            FROM Venta V
            INNER JOIN Usuario U ON V.id_usuario = U.id_usuario
            WHERE V.id_venta = @id_venta";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_venta", idVenta);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        private DataTable ObtenerDetalleVenta(int idVenta)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT 
                DV.cantidad,
                P.nombre AS producto,
                DV.precio_unitario,
                DV.subtotal
            FROM DetalleVenta DV
            INNER JOIN Producto P ON DV.id_producto = P.cod_prod
            WHERE DV.id_venta = @id_venta
            ORDER BY DV.id_detalle";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_venta", idVenta);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}