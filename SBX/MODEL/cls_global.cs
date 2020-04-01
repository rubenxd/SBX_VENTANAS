using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX.MODEL
{
    public class cls_global
    {
        public void ValidaLetras(KeyPressEventArgs kpe)
        {
            try
            {
                if (Char.IsLetter(kpe.KeyChar))
                {
                    kpe.Handled = false;
                }
                else if (Char.IsControl(kpe.KeyChar))
                {
                    kpe.Handled = false;
                }
                else if (Char.IsSeparator(kpe.KeyChar))
                {
                    kpe.Handled = false;
                }
                else
                {
                    kpe.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ValidaNumeros(KeyPressEventArgs kpe)
        {
            try
            {
                if (Char.IsNumber(kpe.KeyChar))
                {
                    kpe.Handled = false;
                }
                else if (Char.IsControl(kpe.KeyChar))
                {
                    kpe.Handled = false;
                }
                else
                {
                    kpe.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void HabiliarNumerosYletras(KeyPressEventArgs kpe)
        {
            try
            {
                kpe.Handled = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean IsNumericDouble(string valor)
        {
            double result;
            return double.TryParse(valor, out result);
        }

        public Boolean IsNumericDecimal(string valor)
        {
            decimal result;
            return decimal.TryParse(valor, out result);
        }

        public Boolean IsInt(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        public Boolean IsNumericFloat(string valor)
        {
            float result;
            return float.TryParse(valor, out result);
        }

        public bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
