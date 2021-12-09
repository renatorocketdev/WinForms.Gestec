using MaterialSkin.Controls;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GESTEC.BLL
{
    class Mascaras
    {
        public void ConverteCNPJ(MaterialSingleLineTextField txtCNPJ, MaterialSingleLineTextField txtEmail)
        {        
            
        }

        #region Mascaras Empresa
        public void MascaraEmpresa(//Parametros
                            MaterialSingleLineTextField txtInscEstadual, MaterialSingleLineTextField txtInscMunicipal, MaterialSingleLineTextField txtCNPJ,
                            MaterialSingleLineTextField txtContato1, MaterialSingleLineTextField txtContato2)
        {
            //Máscara:
            string InscEstadual_Format = Convert.ToUInt64(txtInscEstadual.Text).ToString(@"000\.000\.000\-00");
            string InscMunicipal_Format = Convert.ToUInt64(txtInscMunicipal.Text).ToString(@"000\.000\.000\-00");
            string CNPJ_Format = Convert.ToUInt64(txtCNPJ.Text).ToString(@"00\.000\.000\/0000\-00");
            string Contato1_Format = Convert.ToUInt64(txtContato1.Text).ToString(@"(00)\00000\-0000");
            string Contato2_Format = Convert.ToUInt64(txtContato2.Text).ToString(@"(00)\00000\-0000");
        }
        #endregion

        #region Mascaras Profissionais
        public void MascararProfissional(//Parametros
                                        MaterialSingleLineTextField txtRG, MaterialSingleLineTextField txtCPF, MaterialSingleLineTextField txtPIS, MaterialSingleLineTextField txtCEP,
                                        MaterialSingleLineTextField txtContato1, MaterialSingleLineTextField txtContato2, MaterialSingleLineTextField txtConclusao, 
                                        MaterialSingleLineTextField txtAdmissao1, MaterialSingleLineTextField txtSaida1, MaterialSingleLineTextField txtAdmissao2, 
                                        MaterialSingleLineTextField txtSaida2, MaterialSingleLineTextField txtAdmissao3, MaterialSingleLineTextField txtSaida3)
        {
            string RG_Format = Convert.ToUInt64(txtRG.Text).ToString(@"00\.000\.000\-00");
            string CPF_Format = Convert.ToUInt64(txtCPF.Text).ToString(@"000\.000\.000\-00");
            string CEP_Format = Convert.ToUInt64(txtCEP.Text).ToString(@"00\000\-000");
            string Contato1_Format = Convert.ToUInt64(txtContato1.Text).ToString(@"(00)\00000\-0000");
            string Contato2_Format = Convert.ToUInt64(txtContato2.Text).ToString(@"(00)\00000\-0000");
            string Conclusao_Format = Convert.ToUInt64(txtConclusao.Text).ToString(@"00\/00\/0000");

            string Admissao1_Format = Convert.ToUInt64(txtAdmissao1.Text).ToString(@"00\/00\/0000");
            string Admissao2_Format = Convert.ToUInt64(txtAdmissao2.Text).ToString(@"00\/00\/0000");
            string Admissao3_Format = Convert.ToUInt64(txtAdmissao3.Text).ToString(@"00\/00\/0000");
            string Saida1_Format = Convert.ToUInt64(txtSaida1.Text).ToString(@"00\/00\/0000");
            string Saida2_Format = Convert.ToUInt64(txtSaida2.Text).ToString(@"00\/00\/0000");
            string Saida3_Format = Convert.ToUInt64(txtSaida3.Text).ToString(@"00\/00\/0000");
        }
        #endregion

        #region Mascaras Vagas
        public void MascararVaga(//Parametros
                            MaterialSingleLineTextField txtSalario)
        {
            //Máscara:
            string Salario_Format = string.Format("{0:#.00}", Convert.ToDecimal(txtSalario) / 100);
        }
        #endregion

        #region Mascaras Cargo
        public void MascararCargo(//Parametros
                            MaterialSingleLineTextField txtCPF)
        {
            //Máscara:
            string CPF_Format = Convert.ToUInt64(txtCPF.Text).ToString(@"000\.000\.000\-00");
        }
        #endregion

        #region Mascaras Usuario
        public void MascararUsuario(//Parametros
                            MaterialSingleLineTextField txtCPF)
        {
            //Máscara:
            string CPF_Format = Convert.ToUInt64(txtCPF.Text).ToString(@"000\.000\.000\-00");
        }
        #endregion       
    }
}