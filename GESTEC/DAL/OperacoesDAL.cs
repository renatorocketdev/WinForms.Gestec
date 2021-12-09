using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace GESTEC.DAL
{
    class OperacoesDAL
    {
        NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");

        public int Salvar(string[] campos, string[] valores, string sqlIncluir)
        {

            int regAfetados = -1;
            try
            {
                Conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sqlIncluir, Conn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlIncluir;

                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }

                regAfetados = cmd.ExecuteNonQuery();
                return regAfetados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
