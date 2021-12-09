using MaterialSkin.Controls;
using MetroFramework.Controls;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace GESTEC.BLL
{
    class CurriculoBLL
    {
        #region Sem Escolaridade, 3 Cursos, 3 Empregos
        public void SE3C3E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MaterialSingleLineTextField txtCurso3,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MetroComboBox cbbSituacao3,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2,
                        MaterialSingleLineTextField txtEmpresa3,
                        MaterialSingleLineTextField txtCargo3,
                        MaskedTextBox txtAdmissao3,
                        MaskedTextBox txtSaida3,
                        RichTextBox rtAtividades3,
                        RichTextBox rtMotivoSaida3
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);

                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 445, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 3
                FormatarTexto.DrawString("Empresa - 3: " + txtEmpresa3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 460, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo3.Text + " (" + txtAdmissao3.Text + " - " + txtSaida3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 475, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 490, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 505, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 520, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 535, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 575, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 590, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 605, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 620, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso3.Text + " (" + cbbSituacao3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 635, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 3 Cursos, 2 Empregos
        public void SE3C2E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MaterialSingleLineTextField txtCurso3,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MetroComboBox cbbSituacao3,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);

                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                    FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Acadêmica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));

                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));

                #region Empresa - 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                #endregion

                #region Empresa - 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 455, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 470, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 485, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                   Fonte, XBrushes.Black, new XRect(50, 500, pagina.Width, pagina.Height));
                #endregion

                #region Curso 3
                FormatarTexto.DrawString(txtCurso3.Text + " (" + cbbSituacao3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 515, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 3 Cursos, 1 Emprego
        public void SE3C1E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MaterialSingleLineTextField txtCurso3,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MetroComboBox cbbSituacao3,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 350, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 365, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 380, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 395, pagina.Width, pagina.Height));
                #endregion

                #region Curso 3
                FormatarTexto.DrawString(txtCurso3.Text + " (" + cbbSituacao3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 410, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 2 Cursos, 3 Empregos
        public void SE2C3E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2,
                        MaterialSingleLineTextField txtEmpresa3,
                        MaterialSingleLineTextField txtCargo3,
                        MaskedTextBox txtAdmissao3,
                        MaskedTextBox txtSaida3,
                        RichTextBox rtAtividades3,
                        RichTextBox rtMotivoSaida3
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                   Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 3
                FormatarTexto.DrawString("Empresa - 3: " + txtEmpresa3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 445, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo3.Text + " (" + txtAdmissao3.Text + " - " + txtSaida3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 460, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 475, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 490, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 505, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 520, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 535, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 550, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 565, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 580, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 2 Cursos, 2 Empregos
        public void SE2C2E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                     Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 455, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 470, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 485, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 500, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 2 Cursos, 1 Emprego
        public void SE2C1E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 350, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 365, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 380, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 395, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 1 Cursos, 3 Empregos
        public void SE1C3E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MetroComboBox cbbSituacao1,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2,
                        MaterialSingleLineTextField txtEmpresa3,
                        MaterialSingleLineTextField txtCargo3,
                        MaskedTextBox txtAdmissao3,
                        MaskedTextBox txtSaida3,
                        RichTextBox rtAtividades3,
                        RichTextBox rtMotivoSaida3
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 3
                FormatarTexto.DrawString("Empresa - 3: " + txtEmpresa3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 445, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo3.Text + " (" + txtAdmissao3.Text + " - " + txtSaida3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 460, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 475, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 490, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 505, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 520, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 560, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 575, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 590, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 1 Cursos, 2 Empregos
        public void SE1C2E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MetroComboBox cbbSituacao1,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 455, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 470, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 485, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 1 Cursos, 1 Emprego
        public void SE1C1E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MetroComboBox cbbSituacao1,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 350, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 365, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 380, pagina.Width, pagina.Height));
                #endregion

                #endregion


                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 3 Cursos
        public void SE3CSE
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MaterialSingleLineTextField txtCurso3,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MetroComboBox cbbSituacao3
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Sem Experiência Profissional",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 260, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 275, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 290, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 305, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso3.Text + " (" + cbbSituacao3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 320, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 2 Cursos
        public void SE2CSE
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Sem Experiência Profissional",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 260, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 275, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 290, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 305, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 1 Cursos
        public void SE1CSE
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtCurso1,
                        MetroComboBox cbbSituacao1
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Sem Experiência Profissional",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 260, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 275, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 290, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 3 Empregos
        public void SESC3E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2,
                        MaterialSingleLineTextField txtEmpresa3,
                        MaterialSingleLineTextField txtCargo3,
                        MaskedTextBox txtAdmissao3,
                        MaskedTextBox txtSaida3,
                        RichTextBox rtAtividades3,
                        RichTextBox rtMotivoSaida3
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);

                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 445, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 3
                FormatarTexto.DrawString("Empresa - 3: " + txtEmpresa3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 460, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo3.Text + " (" + txtAdmissao3.Text + " - " + txtSaida3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 475, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 490, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 505, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 520, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 535, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 575, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 590, pagina.Width, pagina.Height));
                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 2 Empregos
        public void SESC2E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade, 1 Empregos
        public void SESC1E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion              
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 380, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 395, pagina.Width, pagina.Height));

                FormatarTexto.DrawString("Sem Cursos Complementares",
                    Fonte, XBrushes.Black, new XRect(50, 410, pagina.Width, pagina.Height));
                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Sem Escolaridade
        public void SESCSE
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 205, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Sem Experiência Profissional",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 260, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 275, pagina.Width, pagina.Height));

                FormatarTexto.DrawString("Sem Cursos Complementares",
                    Fonte, XBrushes.Black, new XRect(50, 290, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion



        #region Com Escolaridade, 3 Cursos, 3 Empregos
        public void CE3C3E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MaterialSingleLineTextField txtCurso3,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MetroComboBox cbbSituacao3,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2,
                        MaterialSingleLineTextField txtEmpresa3,
                        MaterialSingleLineTextField txtCargo3,
                        MaskedTextBox txtAdmissao3,
                        MaskedTextBox txtSaida3,
                        RichTextBox rtAtividades3,
                        RichTextBox rtMotivoSaida3
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);

                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 445, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 3
                FormatarTexto.DrawString("Empresa - 3: " + txtEmpresa3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 460, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo3.Text + " (" + txtAdmissao3.Text + " - " + txtSaida3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 475, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 490, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 505, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 520, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 535, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 575, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 590, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 605, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 620, pagina.Width, pagina.Height));
                #endregion

                #region Curso 3
                FormatarTexto.DrawString(txtCurso3.Text + " (" + cbbSituacao3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 635, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 3 Cursos, 2 Empregos
        public void CE3C2E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MaterialSingleLineTextField txtCurso3,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MetroComboBox cbbSituacao3,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);

                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                    FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa - 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #region Empresa - 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 470, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 485, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 500, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                   Fonte, XBrushes.Black, new XRect(50, 515, pagina.Width, pagina.Height));
                #endregion

                #region Curso 3
                FormatarTexto.DrawString(txtCurso3.Text + " (" + cbbSituacao3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 530, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 3 Cursos, 1 Emprego
        public void CE3C1E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MaterialSingleLineTextField txtCurso3,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MetroComboBox cbbSituacao3,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 365, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 380, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 395, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 410, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso3.Text + " (" + cbbSituacao3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 425, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 2 Cursos, 3 Empregos
        public void CE2C3E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2,
                        MaterialSingleLineTextField txtEmpresa3,
                        MaterialSingleLineTextField txtCargo3,
                        MaskedTextBox txtAdmissao3,
                        MaskedTextBox txtSaida3,
                        RichTextBox rtAtividades3,
                        RichTextBox rtMotivoSaida3
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 445, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 3
                FormatarTexto.DrawString("Empresa - 3: " + txtEmpresa3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 460, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo3.Text + " (" + txtAdmissao3.Text + " - " + txtSaida3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 475, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 490, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 505, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 520, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 535, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 575, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 590, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 605, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 620, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 2 Cursos, 2 Empregos
        public void CE2C2E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 470, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 485, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 500, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 515, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 2 Cursos, 1 Emprego
        public void CE2C1E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 335, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 375, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 390, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 405, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 420, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 1 Cursos, 3 Empregos
        public void CE1C3E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MetroComboBox cbbSituacao1,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2,
                        MaterialSingleLineTextField txtEmpresa3,
                        MaterialSingleLineTextField txtCargo3,
                        MaskedTextBox txtAdmissao3,
                        MaskedTextBox txtSaida3,
                        RichTextBox rtAtividades3,
                        RichTextBox rtMotivoSaida3
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 445, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 3
                FormatarTexto.DrawString("Empresa - 3: " + txtEmpresa3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 460, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo3.Text + " (" + txtAdmissao3.Text + " - " + txtSaida3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 475, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 490, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 505, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 520, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 535, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 575, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 590, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 605, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 1 Cursos, 2 Empregos
        public void CE1C2E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MetroComboBox cbbSituacao1,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 470, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 485, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 500, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 1 Cursos, 1 Emprego
        public void CE1C1E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MetroComboBox cbbSituacao1,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                #endregion

                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteNgt, XBrushes.Black, new XRect(50, 365, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 380, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 395, pagina.Width, pagina.Height));
                #endregion

                #endregion


                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 3 Cursos
        public void CE3CSE
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MaterialSingleLineTextField txtCurso3,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MetroComboBox cbbSituacao3
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Sem Experiência Profissional",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteTitulo, XBrushes.Black, new XRect(50, 275, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 290, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                #endregion

                #region Curso 3
                FormatarTexto.DrawString(txtCurso3.Text + " (" + cbbSituacao3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 2 Cursos
        public void CE2CSE
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Sem Experiência Profissional",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteTitulo, XBrushes.Black, new XRect(50, 275, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 290, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 305, pagina.Width, pagina.Height));
                #endregion

                #region Curso 2
                FormatarTexto.DrawString(txtCurso2.Text + " (" + cbbSituacao2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 320, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 1 Cursos
        public void CE1CSE
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MetroComboBox cbbSituacao1
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Sem Experiência Profissional",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteTitulo, XBrushes.Black, new XRect(50, 275, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 290, pagina.Width, pagina.Height));

                #region Curso 1
                FormatarTexto.DrawString(txtCurso1.Text + " (" + cbbSituacao1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 305, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 3 Empregos
        public void CESC3E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2,
                        MaterialSingleLineTextField txtEmpresa3,
                        MaterialSingleLineTextField txtCargo3,
                        MaskedTextBox txtAdmissao3,
                        MaskedTextBox txtSaida3,
                        RichTextBox rtAtividades3,
                        RichTextBox rtMotivoSaida3
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 445, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 3
                FormatarTexto.DrawString("Empresa - 3: " + txtEmpresa3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 460, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo3.Text + " (" + txtAdmissao3.Text + " - " + txtSaida3.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 475, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 490, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 505, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 520, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida3.Text,
                    Fonte, XBrushes.Black, new XRect(50, 535, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteTitulo, XBrushes.Black, new XRect(50, 550, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 565, pagina.Width, pagina.Height));

                FormatarTexto.DrawString("Sem Cursos Complementares",
                    Fonte, XBrushes.Black, new XRect(50, 580, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 2 Empregos
        public void CESC2E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 340, pagina.Width, pagina.Height));
                #endregion

                #region Empresa 2
                FormatarTexto.DrawString("Empresa - 2: " + txtEmpresa2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 355, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo2.Text + " (" + txtAdmissao2.Text + " - " + txtSaida2.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 370, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 385, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 400, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 415, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 430, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteTitulo, XBrushes.Black, new XRect(50, 470, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 485, pagina.Width, pagina.Height));

                FormatarTexto.DrawString("Sem Cursos Complementares",
                    Fonte, XBrushes.Black, new XRect(50, 500, pagina.Width, pagina.Height));
                #endregion

                #endregion

                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade, 1 Empregos
        public void CESC1E
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));

                #region Empresa 1
                FormatarTexto.DrawString("Empresa - 1: " + txtEmpresa1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Cargo: " + txtCargo1.Text + " (" + txtAdmissao1.Text + " - " + txtSaida1.Text + ")",
                    Fonte, XBrushes.Black, new XRect(50, 265, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Atividades",
                    FonteNgt, XBrushes.Black, new XRect(50, 280, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtAtividades1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 295, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Motivo da Saida",
                    FonteNgt, XBrushes.Black, new XRect(50, 310, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(rtMotivoSaida1.Text,
                    Fonte, XBrushes.Black, new XRect(50, 325, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteTitulo, XBrushes.Black, new XRect(50, 365, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 380, pagina.Width, pagina.Height));

                FormatarTexto.DrawString("Sem Cursos Complementares",
                    Fonte, XBrushes.Black, new XRect(50, 395, pagina.Width, pagina.Height));
                #endregion

                #endregion


                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion

        #region Com Escolaridade
        public void CESCSE
        (
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade
        #endregion
        )
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var pagina = doc.AddPage();
                var grafico = XGraphics.FromPdfPage(pagina);
                var FormatarTexto = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                var Fonte = new XFont("Arial", 12);
                var FonteTitulo = new XFont("Arial", 14, XFontStyle.Bold);
                var FonteNgt = new XFont("Arial", 12, XFontStyle.Bold);


                #region Cabeçalho
                FormatarTexto.DrawString(txtNomeCompleto.Text,
                FonteTitulo, XBrushes.Black, new XRect(50, 50, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 65, pagina.Width, pagina.Height));

                FormatarTexto.DrawString(txtDataNascimento.Text,
                    Fonte, XBrushes.Black, new XRect(50, 80, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(cbbMunicipio.Text + " " + txtBairro.Text + " / " + cbbEstado.Text,
                    Fonte, XBrushes.Black, new XRect(50, 95, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtEmail.Text,
                    Fonte, XBrushes.Black, new XRect(50, 110, pagina.Width, pagina.Height));
                FormatarTexto.DrawString(txtContato1.Text + " / " + txtContato2.Text,
                    Fonte, XBrushes.Black, new XRect(50, 125, pagina.Width, pagina.Height));
                #endregion

                #region Formação Academica
                FormatarTexto.DrawString("Formação Acadêmica",
                    FonteTitulo, XBrushes.Black, new XRect(50, 150, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 165, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Escolaridade: " + cbbEscolaridade.Text + " - Término: " + txtConclusao.Text,
                    Fonte, XBrushes.Black, new XRect(50, 180, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Faculdade: " + txtFaculdade.Text + " - Curso: " + txtCursoFaculdade.Text,
                    Fonte, XBrushes.Black, new XRect(50, 195, pagina.Width, pagina.Height));
                #endregion

                #region Experiência Profissional
                FormatarTexto.DrawString("Experiência Profissional",
                    FonteTitulo, XBrushes.Black, new XRect(50, 220, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 235, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("Sem Experiência Profissional",
                    Fonte, XBrushes.Black, new XRect(50, 250, pagina.Width, pagina.Height));
                #endregion

                #region Cursos Complementares
                FormatarTexto.DrawString("Cursos Complementares ",
                    FonteTitulo, XBrushes.Black, new XRect(50, 275, pagina.Width, pagina.Height));
                FormatarTexto.DrawString("-------------------------------------------------------",
                    Fonte, XBrushes.Black, new XRect(50, 290, pagina.Width, pagina.Height));

                FormatarTexto.DrawString("Sem Cursos Complementares",
                    Fonte, XBrushes.Black, new XRect(50, 305, pagina.Width, pagina.Height));
                #endregion



                doc.Save("Curriculo.pdf");
                Process.Start("Curriculo.pdf");
            }
        }
        #endregion
    }
}