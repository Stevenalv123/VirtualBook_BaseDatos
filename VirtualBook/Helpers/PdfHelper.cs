using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.Windows.Forms;
using System.Linq;
using System;
using System.Diagnostics;
using System.IO;

namespace VirtualBook.Helpers
{
    public static class PdfHelper
    {
        public static void ExportarDataGridView(DataGridView dgv, string titulo)
        {
            // Validaciones rápidas
            if (dgv == null)
            {
                MessageBox.Show("DataGridView es nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgv.Rows.Count == 0 || dgv.Columns.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"{titulo}_{DateTime.Now:yyyyMMdd}.pdf"
            })
            {
                // Mostrar con owner si hay forms abiertos (mejora UX)
                DialogResult dr = sfd.ShowDialog(GetActiveWindowOwner());
                if (dr != DialogResult.OK) return;

                try
                {
                    var columnasVisibles = dgv.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).ToList();
                    if (columnasVisibles.Count == 0)
                    {
                        MessageBox.Show("No hay columnas visibles para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Intentar crear fuentes estándar, si falla dejamos null y seguimos
                    PdfFont fuenteNegrita = null;
                    PdfFont fuenteNormal = null;
                    try
                    {
                        fuenteNegrita = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                        fuenteNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                    }
                    catch
                    {
                        // En algunos entornos esto puede fallar; no rompemos la exportación.
                        fuenteNegrita = null;
                        fuenteNormal = null;
                    }

                    // Usamos FileStream con Create para detectar problemas de permisos/lock
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.Read))
                    using (PdfWriter writer = new PdfWriter(fs))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document documento = new Document(pdf, PageSize.A4))
                    {
                        documento.SetMargins(20, 20, 20, 20);

                        // Título
                        Paragraph header = new Paragraph(titulo)
                            .SetFontSize(20)
                            .SetTextAlignment(TextAlignment.CENTER);

                        if (fuenteNegrita != null) header.SetFont(fuenteNegrita);

                        documento.Add(header);
                        documento.Add(new Paragraph("\n"));

                        // Tabla
                        Table table = new Table(UnitValue.CreatePercentArray(columnasVisibles.Count)).UseAllAvailableWidth();

                        // Encabezados
                        foreach (var columna in columnasVisibles)
                        {
                            Paragraph pHeader = new Paragraph(columna.HeaderText ?? string.Empty)
                                .SetFontSize(11)
                                .SetTextAlignment(TextAlignment.CENTER);

                            if (fuenteNegrita != null) pHeader.SetFont(fuenteNegrita);

                            Cell headerCell = new Cell()
                                .Add(pHeader)
                                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                                .SetTextAlignment(TextAlignment.CENTER);

                            table.AddHeaderCell(headerCell);
                        }

                        // Filas de datos (evitar IsNewRow y celdas nulas)
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (row == null) continue;
                            if (row.IsNewRow) continue;

                            foreach (var columna in columnasVisibles)
                            {
                                string valor = SafeGetCellValue(row, columna);
                                Paragraph pCell = new Paragraph(valor).SetFontSize(10);
                                if (fuenteNormal != null) pCell.SetFont(fuenteNormal);

                                table.AddCell(new Cell().Add(pCell));
                            }
                        }

                        documento.Add(table);
                        // documento y pdf se cierran automáticamente al salir del using
                    }

                    MessageBox.Show("Reporte generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Intentar abrir el PDF (no falla la app si no puede)
                    try
                    {
                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = sfd.FileName,
                            UseShellExecute = true
                        };
                        Process.Start(psi);
                    }
                    catch { /* ignoramos errores al abrir */ }
                }
                catch (UnauthorizedAccessException uex)
                {
                    // Permisos/archivo bloqueado
                    MessageBox.Show($"No se puede escribir el archivo (permiso denegado o archivo en uso):\n{uex.Message}\n\nPath: {sfd.FileName}",
                                    "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException ioex)
                {
                    MessageBox.Show($"Error de E/S al crear el PDF:\n{ioex.Message}\n\nPath: {sfd.FileName}",
                                    "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Mensaje con stacktrace para debugging
                    MessageBox.Show($"Error al exportar:\n{ex.Message}\n\nDetalle técnico:\n{ex.ToString()}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static string SafeGetCellValue(DataGridViewRow row, DataGridViewColumn columna)
        {
            try
            {
                if (row == null || columna == null) return string.Empty;

                // Primera opción: usar el índice de la columna (más seguro)
                int idx = columna.Index;
                if (idx >= 0 && idx < row.Cells.Count)
                {
                    var v = row.Cells[idx].Value;
                    return v?.ToString() ?? string.Empty;
                }

                // Fallback: buscar la celda por OwningColumn.Name (si por alguna razón el índice no coincide)
                if (!string.IsNullOrWhiteSpace(columna.Name))
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell?.OwningColumn != null && cell.OwningColumn.Name == columna.Name)
                        {
                            return cell.Value?.ToString() ?? string.Empty;
                        }
                    }
                }

                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        // Obtener owner para ShowDialog
        private static IWin32Window GetActiveWindowOwner()
        {
            if (Application.OpenForms.Count > 0)
                return Application.OpenForms[0];
            return null;
        }
    }
}
