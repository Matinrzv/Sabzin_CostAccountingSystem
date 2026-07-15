using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzinBargNafis.Data
{
    internal class TarkibDataManager
    {
        // جعفری
        public static decimal JafariGhorme { get; set; }
        public static decimal JafariAsh { get; set; }
        public static decimal JafariPoloi { get; set; }
        public static decimal JafariKoKo { get; set; }
        public static decimal JafariGhelie { get; set; }
        public static decimal JafariPoloiBaSir { get; set; }
        public static decimal JafariSum { get; set; }

        // تره
        public static decimal TareGhorme { get; set; }
        public static decimal TareAsh { get; set; }
        public static decimal TarePoloi { get; set; }
        public static decimal TareKoKo { get; set; }
        public static decimal TareGhelie { get; set; }
        public static decimal TarePoloiBaSir { get; set; }
        public static decimal TareSum { get; set; }

        // شوید
        public static decimal ShevidGhorme { get; set; }
        public static decimal ShevidAsh { get; set; }
        public static decimal ShevidPoloi { get; set; }
        public static decimal ShevidKoKo { get; set; }
        public static decimal ShevidGhelie { get; set; }
        public static decimal ShevidPoloiBaSir { get; set; }
        public static decimal ShevidSum { get; set; }

        // اسفناج
        public static decimal EsfenagGhorme { get; set; }
        public static decimal EsfenagAsh { get; set; }
        public static decimal EsfenagPoloi { get; set; }
        public static decimal EsfenagKoKo { get; set; }
        public static decimal EsfenagGhelie { get; set; }
        public static decimal EsfenagPoloiBaSir { get; set; }
        public static decimal EsfenagSum { get; set; }

        // شنبلیله
        public static decimal ShanbalileGhorme { get; set; }
        public static decimal ShanbalileAsh { get; set; }
        public static decimal ShanbalilePoloi { get; set; }
        public static decimal ShanbalileKoKo { get; set; }
        public static decimal ShanbalileGhelie { get; set; }
        public static decimal ShanbalilePoloiBaSir { get; set; }
        public static decimal ShanbalileSum { get; set; }

        // گشنیز
        public static decimal GhishnizGhorme { get; set; }
        public static decimal GhishnizAsh { get; set; }
        public static decimal GhishnizPoloi { get; set; }
        public static decimal GhishnizKoKo { get; set; }
        public static decimal GhishnizGhelie { get; set; }
        public static decimal GhishnizPoloiBaSir { get; set; }
        public static decimal GhishnizSum { get; set; }

        // نعنا
        public static decimal NanaGhorme { get; set; }
        public static decimal NanaAsh { get; set; }
        public static decimal NanaPoloi { get; set; }
        public static decimal NanaKoKo { get; set; }
        public static decimal NanaGhelie { get; set; }
        public static decimal NanaPoloiBaSir { get; set; }
        public static decimal NanaSum { get; set; }

        // فروش سبزی مخلوط
        public static decimal SaleSabziGhorme { get; set; }
        public static decimal SaleSabziAsh { get; set; }
        public static decimal SaleSabziPoloi { get; set; }
        public static decimal SaleSabziKoKo { get; set; }
        public static decimal SaleSabziGhelie { get; set; }
        public static decimal SaleSabziPoloiBaSir { get; set; }
        public static decimal SaleSabziSum { get; set; }
        
        // دریافت متغیرها
        public static void GetValuesFromForm(FormTarkib formTarkib)
        {
            // جعفری
            JafariGhorme = ToDecimal(formTarkib.txtJafariGhorme.Text);
            JafariAsh = ToDecimal(formTarkib.txtJafariAsh.Text);
            JafariPoloi = ToDecimal(formTarkib.txtJafariPoloi.Text);
            JafariKoKo = ToDecimal(formTarkib.txtJafariKoKo.Text);
            JafariGhelie = ToDecimal(formTarkib.txtJafariGhelie.Text);
            JafariPoloiBaSir = ToDecimal(formTarkib.txtJafariPoloiBaSir.Text);
            JafariSum = ToDecimal(formTarkib.txtJafariSum.Text);
            // تره
            TareGhorme = ToDecimal(formTarkib.txtTareGhorme.Text);
            TareAsh = ToDecimal(formTarkib.txtTareAsh.Text);
            TarePoloi = ToDecimal(formTarkib.txtTarePoloi.Text);
            TareKoKo = ToDecimal(formTarkib.txtTareKoKo.Text);
            TareGhelie = ToDecimal(formTarkib.txtTareGhelie.Text);
            TarePoloiBaSir = ToDecimal(formTarkib.txtTarePoloiBaSir.Text);
            TareSum = ToDecimal(formTarkib.txtTareSum.Text);
            // شوید
            ShevidGhorme = ToDecimal(formTarkib.txtShevidGhorme.Text);
            ShevidAsh = ToDecimal(formTarkib.txtShevidAsh.Text);
            ShevidPoloi = ToDecimal(formTarkib.txtShevidPoloi.Text);
            ShevidKoKo = ToDecimal(formTarkib.txtShevidKoKo.Text);
            ShevidGhelie = ToDecimal(formTarkib.txtShevidGhelie.Text);
            ShevidPoloiBaSir = ToDecimal(formTarkib.txtShevidPoloiBaSir.Text);
            ShevidSum = ToDecimal(formTarkib.txtShevidSum.Text);
            // اسفناج
            EsfenagGhorme = ToDecimal(formTarkib.txtEsfenagGhorme.Text);
            EsfenagAsh = ToDecimal(formTarkib.txtEsfenagAsh.Text);
            EsfenagPoloi = ToDecimal(formTarkib.txtEsfenagPoloi.Text);
            EsfenagKoKo = ToDecimal(formTarkib.txtEsfenagKoKo.Text);
            EsfenagGhelie = ToDecimal(formTarkib.txtEsfenagGhelie.Text);
            EsfenagPoloiBaSir = ToDecimal(formTarkib.txtEsfenagPoloiBaSir.Text);
            EsfenagSum = ToDecimal(formTarkib.txtEsfenagSum.Text);
            // شنبلیله
            ShanbalileGhorme = ToDecimal(formTarkib.txtShanbalileGhorme.Text);
            ShanbalileAsh = ToDecimal(formTarkib.txtShanbalileAsh.Text);
            ShanbalilePoloi = ToDecimal(formTarkib.txtShanbalilePoloi.Text);
            ShanbalileKoKo = ToDecimal(formTarkib.txtShanbalileKoKo.Text);
            ShanbalileGhelie = ToDecimal(formTarkib.txtShanbalileGhelie.Text);
            ShanbalilePoloiBaSir = ToDecimal(formTarkib.txtShanbalilePoloiBaSir.Text);
            ShanbalileSum = ToDecimal(formTarkib.txtShanbalileSum.Text);
            // گشنیز
            GhishnizGhorme = ToDecimal(formTarkib.txtGhishnizGhorme.Text);
            GhishnizAsh = ToDecimal(formTarkib.txtGhishnizAsh.Text);
            GhishnizPoloi = ToDecimal(formTarkib.txtGhishnizPoloi.Text);
            GhishnizKoKo = ToDecimal(formTarkib.txtGhishnizKoKo.Text);
            GhishnizGhelie = ToDecimal(formTarkib.txtGhishnizGhelie.Text);
            GhishnizPoloiBaSir = ToDecimal(formTarkib.txtGhishnizPoloiBaSir.Text);
            GhishnizSum = ToDecimal(formTarkib.txtGhishnizSum.Text);
            // نعنا
            NanaGhorme = ToDecimal(formTarkib.txtNanaGhorme.Text);
            NanaAsh = ToDecimal(formTarkib.txtNanaAsh.Text);
            NanaPoloi = ToDecimal(formTarkib.txtNanaPoloi.Text);
            NanaKoKo = ToDecimal(formTarkib.txtNanaKoKo.Text);
            NanaGhelie = ToDecimal(formTarkib.txtNanaGhelie.Text);
            NanaPoloiBaSir = ToDecimal(formTarkib.txtNanaPoloiBasir.Text);
            NanaSum = ToDecimal(formTarkib.txtNanaSum.Text);
            // فروش سبزی مخلوط
            SaleSabziGhorme = ToDecimal(formTarkib.txtSaleSabziGhorme.Text);
            SaleSabziAsh = ToDecimal(formTarkib.txtSaleSabziAsh.Text);
            SaleSabziPoloi = ToDecimal(formTarkib.txtSaleSabziPoloi.Text);
            SaleSabziKoKo = ToDecimal(formTarkib.txtSaleSabziKoKo.Text);
            SaleSabziGhelie = ToDecimal(formTarkib.txtSaleSabziGhelie.Text);
            SaleSabziPoloiBaSir = ToDecimal(formTarkib.txtSaleSabziPoloiBaSir.Text);
            SaleSabziSum = ToDecimal(formTarkib.txtSaleSabziSum.Text);
        }
        private static decimal ToDecimal(string value)
        {
            if (string.IsNullOrEmpty(value))
                return 0;

            decimal result;
            if (decimal.TryParse(value, out result))
                return result;
            else
                return 0;
        }
    }
}
