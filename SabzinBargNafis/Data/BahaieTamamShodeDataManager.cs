using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzinBargNafis.Data
{
    internal class BahaieTamamShodeDataManager
    {
        public static decimal SumHazineHS { get; set; }
        public static decimal HazineAZ { get; set; }
        public static decimal HazineHD { get; set; }
        public static decimal HazineBIme23 { get; set; }
        public static decimal HazineTF { get; set; }
        public static decimal HazineOET { get; set; }
        public static decimal HazineMali { get; set; }

        // کرفس - موجودی اول دوره
        public static decimal KMMAD { get; set; }
        public static decimal KNMAD { get; set; }
        public static decimal KMGHMAD { get; set; }
        //کرفس - خرید طی دوره پاک نشده
        public static decimal KMKHTDPN { get; set; }
        public static decimal KNKHTDPN { get; set; }
        public static decimal KMGHKHTDPN { get; set; }
        // کرفس - خرید طی دوره پاک شده
        public static decimal KMKHTDPSH { get; set; }
        public static decimal KNKHTDPSH { get; set; }
        public static decimal KMGHKHTDPSH { get; set; }
        //کرفس - بهای تمام شده فروش سبزی پاک شده
        public static decimal KMBTSHFSPSH { get; set; }
        public static decimal KNBTSHFSPSH { get; set; }
        public static decimal KMGHBTSHFSPSH { get; set; }
        // کرفس - مانده جهت تولید محصول مخلوط
        public static decimal KMMJTMM { get; set; }
        public static decimal KNMJTMM { get; set; }
        public static decimal KMGHMJTMM { get; set; }
        // کرفس - مصرف جهت تولید سبزی مخلوط
        public static decimal KMMJTSM { get; set; }
        public static decimal KNMJTSM { get; set; }
        public static decimal KMGHMJTSM { get; set; }
        // کرفس - مانده بعد از تولید سبزی تازه
        public static decimal KMMBATST { get; set; }
        public static decimal KNMBATST { get; set; }
        public static decimal KMGHMBATST { get; set ; }

        public static decimal KMMJTSKH { get; set; }
        public static decimal KNMJTSKH { get; set; }
        public static decimal KMGHMJTSKH { get; set; }

        public static decimal KMZA { get; set; }
        public static decimal KNZA { get; set; }
        public static decimal KMGHZA { get; set; }

        public static decimal KMMPD { get; set; }
        public static decimal KNMPD { get; set; }
        public static decimal KMGHMPD { get; set; }

        // کرفس - ضایعات (Z)
        public static decimal KMZ { get; set; }
        public static decimal KNZ { get; set; }
        public static decimal KMGHZ { get; set; }

        // کرفس - هزینه حمل و نقل (HDS)
        public static decimal KMHDS { get; set; }
        public static decimal KNHDS { get; set; }
        public static decimal KMGHHDS { get; set; }

        public static decimal KMSum { get; set; }
        public static decimal KNSum { get; set; }
        public static decimal KMGHSum { get; set; }

        // ====================================================
        // تره - شروع
        // ====================================================

        // تره - موجودی اول دوره
        public static decimal TMMAD { get; set; }
        public static decimal TNMAD { get; set; }
        public static decimal TMGHMAD { get; set; }

        // تره - خرید طی دوره پاک نشده
        public static decimal TMKHTDPN { get; set; }
        public static decimal TNKHTDPN { get; set; }
        public static decimal TMGHKHTDPN { get; set; }

        // تره - خرید طی دوره پاک شده
        public static decimal TMKHTDPSH { get; set; }
        public static decimal TNKHTDPSH { get; set; }
        public static decimal TMGHKHTDPSH { get; set; }

        // تره - بهای تمام شده فروش سبزی پاک شده
        public static decimal TMBTSHFSPSH { get; set; }
        public static decimal TNBTSHFSPSH { get; set; }
        public static decimal TMGHBTSHFSPSH { get; set; }

        // تره - مانده جهت تولید محصول مخلوط
        public static decimal TMMJTMM { get; set; }
        public static decimal TNMJTMM { get; set; }
        public static decimal TMGHMJTMM { get; set; }

        // تره - مصرف جهت تولید سبزی مخلوط
        public static decimal TMMJTSM { get; set; }
        public static decimal TNMJTSM { get; set; }
        public static decimal TMGHMJTSM { get; set; }

        // تره - مانده بعد از تولید سبزی تازه
        public static decimal TMMBATST { get; set; }
        public static decimal TNMBATST { get; set; }
        public static decimal TMGHMBATST { get; set; }

        // تره - مصرف جهت تولید سبزی تازه
        public static decimal TMMJTSKH { get; set; }
        public static decimal TNMJTSKH { get; set; }
        public static decimal TMGHMJTSKH { get; set; }

        // تره - موجودی آخر دوره (ZA)
        public static decimal TMZA { get; set; }
        public static decimal TNZA { get; set; }
        public static decimal TMGHZA { get; set; }

        // تره - مانده پایان دوره (MPD)
        public static decimal TMMPD { get; set; }
        public static decimal TNMPD { get; set; }
        public static decimal TMGHMPD { get; set; }

        // تره - ضایعات (Z)
        public static decimal TMZ { get; set; }
        public static decimal TNZ { get; set; }
        public static decimal TMGHZ { get; set; }

        // تره - هزینه حمل و نقل (HDS)
        public static decimal TMHDS { get; set; }
        public static decimal TNHDS { get; set; }
        public static decimal TMGHHDS { get; set; }

        // تره - جمع کل (Sum)
        public static decimal TMSum { get; set; }
        public static decimal TNSum { get; set; }
        public static decimal TMGHSum { get; set; }
        // ====================================================
        // شنبلیله - شروع
        // ====================================================

        // شنبلیله - موجودی اول دوره
        public static decimal SHNMMAD { get; set; }
        public static decimal SHNNMAD { get; set; }
        public static decimal SHNMGHMAD { get; set; }

        // شنبلیله - خرید طی دوره پاک نشده
        public static decimal SHNMKHTDPN { get; set; }
        public static decimal SHNNKHTDPN { get; set; }
        public static decimal SHNMGHKHTDPN { get; set; }

        // شنبلیله - خرید طی دوره پاک شده
        public static decimal SHNMKHTDPSH { get; set; }
        public static decimal SHNNKHTDPSH { get; set; }
        public static decimal SHNMGHKHTDPSH { get; set; }

        // شنبلیله - بهای تمام شده فروش سبزی پاک شده
        public static decimal SHNMBTSHFSPSH { get; set; }
        public static decimal SHNNBTSHFSPSH { get; set; }
        public static decimal SHNMGHBTSHFSPSH { get; set; }

        // شنبلیله - مانده جهت تولید محصول مخلوط
        public static decimal SHNMMJTMM { get; set; }
        public static decimal SHNNMJTMM { get; set; }
        public static decimal SHNMGHMJTMM { get; set; }

        // شنبلیله - مصرف جهت تولید سبزی مخلوط
        public static decimal SHNMMJTSM { get; set; }
        public static decimal SHNNMJTSM { get; set; }
        public static decimal SHNMGHMJTSM { get; set; }

        // شنبلیله - مانده بعد از تولید سبزی تازه
        public static decimal SHNMMBATST { get; set; }
        public static decimal SHNNMBATST { get; set; }
        public static decimal SHNMGHMBATST { get; set; }

        // شنبلیله - مصرف جهت تولید سبزی تازه
        public static decimal SHNMMJTSKH { get; set; }
        public static decimal SHNNMJTSKH { get; set; }
        public static decimal SHNMGHMJTSKH { get; set; }

        // شنبلیله - موجودی آخر دوره (ZA)
        public static decimal SHNMZA { get; set; }
        public static decimal SHNNZA { get; set; }
        public static decimal SHNMGHZA { get; set; }

        // شنبلیله - مانده پایان دوره (MPD)
        public static decimal SHNMMPD { get; set; }
        public static decimal SHNNMPD { get; set; }
        public static decimal SHNMGHMPD { get; set; }

        // شنبلیله - ضایعات (Z)
        public static decimal SHNMZ { get; set; }
        public static decimal SHNNZ { get; set; }
        public static decimal SHNMGHZ { get; set; }

        // شنبلیله - هزینه حمل و نقل (HDS)
        public static decimal SHNMHDS { get; set; }
        public static decimal SHNNHDS { get; set; }
        public static decimal SHNMGHHDS { get; set; }

        // شنبلیله - جمع کل (Sum)
        public static decimal SHNMSum { get; set; }
        public static decimal SHNNSum { get; set; }
        public static decimal SHNMGHSum { get; set; }

        // ====================================================
        // اسفناج - شروع
        // ====================================================

        // اسفناج - موجودی اول دوره
        public static decimal EMMAD { get; set; }
        public static decimal ENMAD { get; set; }
        public static decimal EMGHMAD { get; set; }

        // اسفناج - خرید طی دوره پاک نشده
        public static decimal EMKHTDPN { get; set; }
        public static decimal ENKHTDPN { get; set; }
        public static decimal EMGHKHTDPN { get; set; }

        // اسفناج - خرید طی دوره پاک شده
        public static decimal EMKHTDPSH { get; set; }
        public static decimal ENKHTDPSH { get; set; }
        public static decimal EMGHKHTDPSH { get; set; }

        // اسفناج - بهای تمام شده فروش سبزی پاک شده
        public static decimal EMBTSHFSPSH { get; set; }
        public static decimal ENBTSHFSPSH { get; set; }
        public static decimal EMGHBTSHFSPSH { get; set; }

        // اسفناج - مانده جهت تولید محصول مخلوط
        public static decimal EMMJTMM { get; set; }
        public static decimal ENMJTMM { get; set; }
        public static decimal EMGHMJTMM { get; set; }

        // اسفناج - مصرف جهت تولید سبزی مخلوط
        public static decimal EMMJTSM { get; set; }
        public static decimal ENMJTSM { get; set; }
        public static decimal EMGHMJTSM { get; set; }

        // اسفناج - مانده بعد از تولید سبزی تازه
        public static decimal EMMBATST { get; set; }
        public static decimal ENMBATST { get; set; }
        public static decimal EMGHMBATST { get; set; }

        // اسفناج - مصرف جهت تولید سبزی تازه
        public static decimal EMMJTSKH { get; set; }
        public static decimal ENMJTSKH { get; set; }
        public static decimal EMGHMJTSKH { get; set; }

        // اسفناج - موجودی آخر دوره (ZA)
        public static decimal EMZA { get; set; }
        public static decimal ENZA { get; set; }
        public static decimal EMGHZA { get; set; }

        // اسفناج - مانده پایان دوره (MPD)
        public static decimal EMMPD { get; set; }
        public static decimal ENMPD { get; set; }
        public static decimal EMGHMPD { get; set; }

        // اسفناج - ضایعات (Z)
        public static decimal EMZ { get; set; }
        public static decimal ENZ { get; set; }
        public static decimal EMGHZ { get; set; }

        // اسفناج - هزینه حمل و نقل (HDS)
        public static decimal EMHDS { get; set; }
        public static decimal ENHDS { get; set; }
        public static decimal EMGHHDS { get; set; }

        // اسفناج - جمع کل (Sum)
        public static decimal EMSum { get; set; }
        public static decimal ENSum { get; set; }
        public static decimal EMGHSum { get; set; }

        // ====================================================
        // جعفری - شروع
        // ====================================================

        // جعفری - موجودی اول دوره
        public static decimal JMMAD { get; set; }
        public static decimal JNMAD { get; set; }
        public static decimal JMGHMAD { get; set; }

        // جعفری - خرید طی دوره پاک نشده
        public static decimal JMKHTDPN { get; set; }
        public static decimal JNKHTDPN { get; set; }
        public static decimal JMGHKHTDPN { get; set; }

        // جعفری - خرید طی دوره پاک شده
        public static decimal JMKHTDPSH { get; set; }
        public static decimal JNKHTDPSH { get; set; }
        public static decimal JMGHKHTDPSH { get; set; }

        // جعفری - بهای تمام شده فروش سبزی پاک شده
        public static decimal JMBTSHFSPSH { get; set; }
        public static decimal JNBTSHFSPSH { get; set; }
        public static decimal JMGHBTSHFSPSH { get; set; }

        // جعفری - مانده جهت تولید محصول مخلوط
        public static decimal JMMJTMM { get; set; }
        public static decimal JNMJTMM { get; set; }
        public static decimal JMGHMJTMM { get; set; }

        // جعفری - مصرف جهت تولید سبزی مخلوط
        public static decimal JMMJTSM { get; set; }
        public static decimal JNMJTSM { get; set; }
        public static decimal JMGHMJTSM { get; set; }

        // جعفری - مانده بعد از تولید سبزی تازه
        public static decimal JMMBATST { get; set; }
        public static decimal JNMBATST { get; set; }
        public static decimal JMGHMBATST { get; set; }

        // جعفری - مصرف جهت تولید سبزی تازه
        public static decimal JMMJTSKH { get; set; }
        public static decimal JNMJTSKH { get; set; }
        public static decimal JMGHMJTSKH { get; set; }

        // جعفری - موجودی آخر دوره (ZA)
        public static decimal JMZA { get; set; }
        public static decimal JNZA { get; set; }
        public static decimal JMGHZA { get; set; }

        // جعفری - مانده پایان دوره (MPD)
        public static decimal JMMPD { get; set; }
        public static decimal JNMPD { get; set; }
        public static decimal JMGHMPD { get; set; }

        // جعفری - ضایعات (Z)
        public static decimal JMZ { get; set; }
        public static decimal JNZ { get; set; }
        public static decimal JMGHZ { get; set; }

        // جعفری - هزینه حمل و نقل (HDS)
        public static decimal JMHDS { get; set; }
        public static decimal JNHDS { get; set; }
        public static decimal JMGHHDS { get; set; }

        // جعفری - جمع کل (Sum)
        public static decimal JMSum { get; set; }
        public static decimal JNSum { get; set; }
        public static decimal JMGHSum { get; set; }

        // ====================================================
        // گشنیز - شروع
        // ====================================================

        // گشنیز - موجودی اول دوره
        public static decimal GMGHMAD { get; set; }
        public static decimal GNMAD { get; set; }
        public static decimal GMMAD { get; set; }

        // گشنیز - خرید طی دوره پاک نشده
        public static decimal GMGHKHTDPN { get; set; }
        public static decimal GNKHTDPN { get; set; }
        public static decimal GMKHTDPN { get; set; }

        // گشنیز - خرید طی دوره پاک شده
        public static decimal GMGHKHTDPSH { get; set; }
        public static decimal GNKHTDPSH { get; set; }
        public static decimal GMKHTDPSH { get; set; }

        // گشنیز - بهای تمام شده فروش سبزی پاک شده
        public static decimal GMGHBTSHFSPSH { get; set; }
        public static decimal GNBTSHFSPSH { get; set; }
        public static decimal GMBTSHFSPSH { get; set; }

        // گشنیز - مانده جهت تولید محصول مخلوط
        public static decimal GMGHMJTMM { get; set; }
        public static decimal GNMJTMM { get; set; }
        public static decimal GMMJTMM { get; set; }

        // گشنیز - مصرف جهت تولید سبزی مخلوط
        public static decimal GMGHMJTSM { get; set; }
        public static decimal GNMJTSM { get; set; }
        public static decimal GMMJTSM { get; set; }

        // گشنیز - مانده بعد از تولید سبزی تازه
        public static decimal GMGHMBATST { get; set; }
        public static decimal GNMBATST { get; set; }
        public static decimal GMMBATST { get; set; }

        // گشنیز - مصرف جهت تولید سبزی تازه
        public static decimal GMGHMJTSKH { get; set; }
        public static decimal GNMJTSKH { get; set; }
        public static decimal GMMJTSKH { get; set; }

        // گشنیز - موجودی آخر دوره (ZA)
        public static decimal GMGHZA { get; set; }
        public static decimal GNZA { get; set; }
        public static decimal GMZA { get; set; }

        // گشنیز - مانده پایان دوره (MPD)
        public static decimal GMGHMPD { get; set; }
        public static decimal GNMPD { get; set; }
        public static decimal GMMPD { get; set; }

        // گشنیز - ضایعات (Z)
        public static decimal GMGHZ { get; set; }
        public static decimal GNZ { get; set; }
        public static decimal GMZ { get; set; }

        // گشنیز - هزینه حمل و نقل (HDS)
        public static decimal GMGHHDS { get; set; }
        public static decimal GNHDS { get; set; }
        public static decimal GMHDS { get; set; }

        // گشنیز - جمع کل (Sum)
        public static decimal GMGHSum { get; set; }
        public static decimal GNSum { get; set; }
        public static decimal GMSum { get; set; }
        // ====================================================
        // شوید - شروع
        // ====================================================

        // شوید - موجودی اول دوره
        public static decimal SHVMMAD { get; set; }
        public static decimal SHVNMAD { get; set; }
        public static decimal SHVMGHMAD { get; set; }

        // شوید - خرید طی دوره پاک نشده
        public static decimal SHVMKHTDPN { get; set; }
        public static decimal SHVNKHTDPN { get; set; }
        public static decimal SHVMGHKHTDPN { get; set; }

        // شوید - خرید طی دوره پاک شده
        public static decimal SHVMKHTDPSH { get; set; }
        public static decimal SHVNKHTDPSH { get; set; }
        public static decimal SHVMGHKHTDPSH { get; set; }

        // شوید - بهای تمام شده فروش سبزی پاک شده
        public static decimal SHVMBTSHFSPSH { get; set; }
        public static decimal SHVNBTSHFSPSH { get; set; }
        public static decimal SHVMGHBTSHFSPSH { get; set; }

        // شوید - مانده جهت تولید محصول مخلوط
        public static decimal SHVMMJTMM { get; set; }
        public static decimal SHVNMJTMM { get; set; }
        public static decimal SHVMGHMJTMM { get; set; }

        // شوید - مصرف جهت تولید سبزی مخلوط
        public static decimal SHVMMJTSM { get; set; }
        public static decimal SHVNMJTSM { get; set; }
        public static decimal SHVMGHMJTSM { get; set; }

        // شوید - مانده بعد از تولید سبزی تازه
        public static decimal SHVMMBATST { get; set; }
        public static decimal SHVNMBATST { get; set; }
        public static decimal SHVMGHMBATST { get; set; }

        // شوید - مصرف جهت تولید سبزی تازه
        public static decimal SHVMMJTSKH { get; set; }
        public static decimal SHVNMJTSKH { get; set; }
        public static decimal SHVMGHMJTSKH { get; set; }

        // شوید - موجودی آخر دوره (ZA)
        public static decimal SHVMZA { get; set; }
        public static decimal SHVNZA { get; set; }
        public static decimal SHVMGHZA { get; set; }

        // شوید - مانده پایان دوره (MPD)
        public static decimal SHVMMPD { get; set; }
        public static decimal SHVNMPD { get; set; }
        public static decimal SHVMGHMPD { get; set; }

        // شوید - ضایعات (Z)
        public static decimal SHVMZ { get; set; }
        public static decimal SHVNZ { get; set; }
        public static decimal SHVMGHZ { get; set; }

        // شوید - هزینه حمل و نقل (HDS)
        public static decimal SHVMHDS { get; set; }
        public static decimal SHVNHDS { get; set; }
        public static decimal SHVMGHHDS { get; set; }

        // شوید - جمع کل (Sum)
        public static decimal SHVMSum { get; set; }
        public static decimal SHVNSum { get; set; }
        public static decimal SHVMGHSum { get; set; }
        // ====================================================
        // قورمه سبزی - شروع
        // ====================================================

        // قورمه سبزی - موجودی اول دوره
        public static decimal GHMMAD { get; set; }
        public static decimal GHNMAD { get; set; }
        public static decimal GHMGHMAD { get; set; }

        // قورمه سبزی - خرید طی دوره پاک نشده
        public static decimal GHMKHTDPN { get; set; }
        public static decimal GHNKHTDPN { get; set; }
        public static decimal GHMGHKHTDPN { get; set; }

        // قورمه سبزی - خرید طی دوره پاک شده
        public static decimal GHMKHTDPSH { get; set; }
        public static decimal GHNKHTDPSH { get; set; }
        public static decimal GHMGHKHTDPSH { get; set; }

        // قورمه سبزی - بهای تمام شده فروش سبزی پاک شده
        public static decimal GHMBTSHFSPSH { get; set; }
        public static decimal GHNBTSHFSPSH { get; set; }
        public static decimal GHMGHBTSHFSPSH { get; set; }

        // قورمه سبزی - مانده جهت تولید محصول مخلوط
        public static decimal GHMMJTMM { get; set; }
        public static decimal GHNMJTMM { get; set; }
        public static decimal GHMGHMJTMM { get; set; }

        // قورمه سبزی - مصرف جهت تولید سبزی مخلوط
        public static decimal GHMMJTSM { get; set; }
        public static decimal GHNMJTSM { get; set; }
        public static decimal GHMGHMJTSM { get; set; }

        // قورمه سبزی - مانده بعد از تولید سبزی تازه
        public static decimal GHMMBATST { get; set; }
        public static decimal GHNMBATST { get; set; }
        public static decimal GHMGHMBATST { get; set; }

        // قورمه سبزی - مصرف جهت تولید سبزی تازه
        public static decimal GHMMJTSKH { get; set; }
        public static decimal GHNMJTSKH { get; set; }
        public static decimal GHMGHMJTSKH { get; set; }

        // قورمه سبزی - موجودی آخر دوره (ZA)
        public static decimal GHMZA { get; set; }
        public static decimal GHNZA { get; set; }
        public static decimal GHMGHZA { get; set; }

        // قورمه سبزی - مانده پایان دوره (MPD)
        public static decimal GHMMPD { get; set; }
        public static decimal GHNMPD { get; set; }
        public static decimal GHMGHMPD { get; set; }

        // قورمه سبزی - ضایعات (Z)
        public static decimal GHMZ { get; set; }
        public static decimal GHNZ { get; set; }
        public static decimal GHMGHZ { get; set; }

        // قورمه سبزی - هزینه حمل و نقل (HDS)
        public static decimal GHMHDS { get; set; }
        public static decimal GHNHDS { get; set; }
        public static decimal GHMGHHDS { get; set; }

        // قورمه سبزی - جمع کل (Sum)
        public static decimal GHMSum { get; set; }
        public static decimal GHNSum { get; set; }
        public static decimal GHMGHSum { get; set; }

        // ====================================================
        // هویج و پیاز - شروع
        // ====================================================

        // هویج و پیاز - موجودی اول دوره
        public static decimal HPMAD { get; set; }  // توجه: در تکست‌باکس‌ها به صورت HPMAD هست
        public static decimal HPNMAD { get; set; }
        public static decimal HPMGHMAD { get; set; }

        // هویج و پیاز - خرید طی دوره پاک نشده
        public static decimal HPMKHTDPN { get; set; }
        public static decimal HPNKHTDPN { get; set; }
        public static decimal HPMGHKHTDPN { get; set; }

        // هویج و پیاز - خرید طی دوره پاک شده
        public static decimal HPMKHTDPSH { get; set; }
        public static decimal HPNKHTDPSH { get; set; }
        public static decimal HPMGHKHTDPSH { get; set; }

        // هویج و پیاز - بهای تمام شده فروش سبزی پاک شده
        public static decimal HPMBTSHFSPSH { get; set; }
        public static decimal HPNBTSHFSPSH { get; set; }
        public static decimal HPMGHBTSHFSPSH { get; set; }

        // هویج و پیاز - مانده جهت تولید محصول مخلوط
        public static decimal HPMMJTMM { get; set; }
        public static decimal HPNMJTMM { get; set; }
        public static decimal HPMGHMJTMM { get; set; }

        // هویج و پیاز - مصرف جهت تولید سبزی مخلوط
        public static decimal HPMMJTSM { get; set; }
        public static decimal HPNMJTSM { get; set; }
        public static decimal HPMGHMJTSM { get; set; }

        // هویج و پیاز - مانده بعد از تولید سبزی تازه
        public static decimal HPMMBATST { get; set; }
        public static decimal HPNMBATST { get; set; }
        public static decimal HPMGHMBATST { get; set; }

        // هویج و پیاز - مصرف جهت تولید سبزی تازه
        public static decimal HPMMJTSKH { get; set; }
        public static decimal HPNMJTSKH { get; set; }
        public static decimal HPMGHMJTSKH { get; set; }

        // هویج و پیاز - موجودی آخر دوره (ZA)
        public static decimal HPMZA { get; set; }
        public static decimal HPNZA { get; set; }
        public static decimal HPMGHZA { get; set; }

        // هویج و پیاز - مانده پایان دوره (MPD)
        public static decimal HPMMPD { get; set; }
        public static decimal HPNMPD { get; set; }
        public static decimal HPMGHMPD { get; set; }

        // هویج و پیاز - ضایعات (Z)
        public static decimal HPMZ { get; set; }
        public static decimal HPNZ { get; set; }
        public static decimal HPMGHZ { get; set; }

        // هویج و پیاز - هزینه حمل و نقل (HDS)
        public static decimal HPMHDS { get; set; }
        public static decimal HPNHDS { get; set; }
        public static decimal HPMGHHDS { get; set; }

        // هویج و پیاز - جمع کل (Sum)
        public static decimal HPMSum { get; set; }
        public static decimal HPNSum { get; set; }
        public static decimal HPMGHSum { get; set; }

        // ====================================================
        // لوبیا سبز - شروع
        // ====================================================

        // لوبیا سبز - موجودی اول دوره
        public static decimal LMMAD { get; set; }
        public static decimal LNMAD { get; set; }
        public static decimal LMGHMAD { get; set; }

        // لوبیا سبز - خرید طی دوره پاک نشده
        public static decimal LMKHTDPN { get; set; }
        public static decimal LNKHTDPN { get; set; }
        public static decimal LMGHKHTDPN { get; set; }

        // لوبیا سبز - خرید طی دوره پاک شده
        public static decimal LMKHTDPSH { get; set; }
        public static decimal LNKHTDPSH { get; set; }
        public static decimal LMGHKHTDPSH { get; set; }

        // لوبیا سبز - بهای تمام شده فروش سبزی پاک شده
        public static decimal LMBTSHFSPSH { get; set; }
        public static decimal LNBTSHFSPSH { get; set; }
        public static decimal LMGHBTSHFSPSH { get; set; }

        // لوبیا سبز - مانده جهت تولید محصول مخلوط
        public static decimal LMMJTMM { get; set; }
        public static decimal LNMJTMM { get; set; }
        public static decimal LMGHMJTMM { get; set; }

        // لوبیا سبز - مصرف جهت تولید سبزی مخلوط
        public static decimal LMMJTSM { get; set; }
        public static decimal LNMJTSM { get; set; }
        public static decimal LMGHMJTSM { get; set; }

        // لوبیا سبز - مانده بعد از تولید سبزی تازه
        public static decimal LMMBATST { get; set; }
        public static decimal LNMBATST { get; set; }
        public static decimal LMGHMBATST { get; set; }

        // لوبیا سبز - مصرف جهت تولید سبزی تازه
        public static decimal LMMJTSKH { get; set; }
        public static decimal LNMJTSKH { get; set; }
        public static decimal LMGHMJTSKH { get; set; }

        // لوبیا سبز - موجودی آخر دوره (ZA)
        public static decimal LMZA { get; set; }
        public static decimal LNZA { get; set; }
        public static decimal LMGHZA { get; set; }

        // لوبیا سبز - مانده پایان دوره (MPD)
        public static decimal LMMPD { get; set; }
        public static decimal LNMPD { get; set; }
        public static decimal LMGHMPD { get; set; }

        // لوبیا سبز - ضایعات (Z)
        public static decimal LMZ { get; set; }
        public static decimal LNZ { get; set; }
        public static decimal LMGHZ { get; set; }

        // لوبیا سبز - هزینه حمل و نقل (HDS)
        public static decimal LMHDS { get; set; }
        public static decimal LNHDS { get; set; }
        public static decimal LMGHHDS { get; set; }

        // لوبیا سبز - جمع کل (Sum)
        public static decimal LMSum { get; set; }
        public static decimal LNSum { get; set; }
        public static decimal LMGHSum { get; set; }
        public static void GetValuesFromForm(FormBahaieTamamShode formBahaie)
        {
            // ====================================================
            // جعفری (J)
            // ====================================================
            JMGHMAD = ToDecimal(formBahaie.txtJMGHMAD.Text);
            JNMAD = ToDecimal(formBahaie.txtJNMAD.Text);
            JMMAD = ToDecimal(formBahaie.txtJMMAD.Text);

            JMGHKHTDPN = ToDecimal(formBahaie.txtJMGHKHTDPN.Text);
            JNKHTDPN = ToDecimal(formBahaie.txtJNKHTDPN.Text);
            JMKHTDPN = ToDecimal(formBahaie.txtJMKHTDPN.Text);

            JMGHKHTDPSH = ToDecimal(formBahaie.txtJMGHKHTDPSH.Text);
            JNKHTDPSH = ToDecimal(formBahaie.txtJNKHTDPSH.Text);
            JMKHTDPSH = ToDecimal(formBahaie.txtJMKHTDPSH.Text);

            JMGHBTSHFSPSH = ToDecimal(formBahaie.txtJMGHBTSHFSPSH.Text);
            JNBTSHFSPSH = ToDecimal(formBahaie.txtJNBTSHFSPSH.Text);
            JMBTSHFSPSH = ToDecimal(formBahaie.txtJMBTSHFSPSH.Text);

            JMGHMJTMM = ToDecimal(formBahaie.txtJMGHMJTMM.Text);
            JNMJTMM = ToDecimal(formBahaie.txtJNMJTMM.Text);
            JMMJTMM = ToDecimal(formBahaie.txtJMMJTMM.Text);

            JMGHMJTSM = ToDecimal(formBahaie.txtJMGHMJTSM.Text);
            JNMJTSM = ToDecimal(formBahaie.txtJNMJTSM.Text);
            JMMJTSM = ToDecimal(formBahaie.txtJMMJTSM.Text);

            JMGHMBATST = ToDecimal(formBahaie.txtJMGHMBATST.Text);
            JNMBATST = ToDecimal(formBahaie.txtJNMBATST.Text);
            JMMBATST = ToDecimal(formBahaie.txtJMMBATST.Text);

            JMGHMJTSKH = ToDecimal(formBahaie.txtJMGHMJTSKH.Text);
            JNMJTSKH = ToDecimal(formBahaie.txtJNMJTSKH.Text);
            JMMJTSKH = ToDecimal(formBahaie.txtJMMJTSKH.Text);

            JMGHZA = ToDecimal(formBahaie.txtJMGHZA.Text);
            JNZA = ToDecimal(formBahaie.txtJNZA.Text);
            JMZA = ToDecimal(formBahaie.txtJMZA.Text);

            JMGHMPD = ToDecimal(formBahaie.txtJMGHMPD.Text);
            JNMPD = ToDecimal(formBahaie.txtJNMPD.Text);
            JMMPD = ToDecimal(formBahaie.txtJMMPD.Text);

            JMGHZ = ToDecimal(formBahaie.txtJMGHZ.Text);
            JNZ = ToDecimal(formBahaie.txtJNZ.Text);
            JMZ = ToDecimal(formBahaie.txtJMZ.Text);

            JMGHHDS = ToDecimal(formBahaie.txtJMGHHDS.Text);
            JNHDS = ToDecimal(formBahaie.txtJNHDS.Text);
            JMHDS = ToDecimal(formBahaie.txtJMHDS.Text);

            JMGHSum = ToDecimal(formBahaie.txtJMGHSum.Text);
            JNSum = ToDecimal(formBahaie.txtJNSum.Text);
            JMSum = ToDecimal(formBahaie.txtJMSum.Text);

            // ====================================================
            // تره (T)
            // ====================================================
            TMGHMAD = ToDecimal(formBahaie.txtTMGHMAD.Text);
            TNMAD = ToDecimal(formBahaie.txtTNMAD.Text);
            TMMAD = ToDecimal(formBahaie.txtTMMAD.Text);

            TMGHKHTDPN = ToDecimal(formBahaie.txtTMGHKHTDPN.Text);
            TNKHTDPN = ToDecimal(formBahaie.txtTNKHTDPN.Text);
            TMKHTDPN = ToDecimal(formBahaie.txtTMKHTDPN.Text);

            TMGHKHTDPSH = ToDecimal(formBahaie.txtTMGHKHTDPSH.Text);
            TNKHTDPSH = ToDecimal(formBahaie.txtTNKHTDPSH.Text);
            TMKHTDPSH = ToDecimal(formBahaie.txtTMKHTDPSH.Text);

            TMGHBTSHFSPSH = ToDecimal(formBahaie.txtTMGHBTSHFSPSH.Text);
            TNBTSHFSPSH = ToDecimal(formBahaie.txtTNBTSHFSPSH.Text);
            TMBTSHFSPSH = ToDecimal(formBahaie.txtTMBTSHFSPSH.Text);

            TMGHMJTMM = ToDecimal(formBahaie.txtTMGHMJTMM.Text);
            TNMJTMM = ToDecimal(formBahaie.txtTNMJTMM.Text);
            TMMJTMM = ToDecimal(formBahaie.txtTMMJTMM.Text);

            TMGHMJTSM = ToDecimal(formBahaie.txtTMGHMJTSM.Text);
            TNMJTSM = ToDecimal(formBahaie.txtTNMJTSM.Text);
            TMMJTSM = ToDecimal(formBahaie.txtTMMJTSM.Text);

            TMGHMBATST = ToDecimal(formBahaie.txtTMGHMBATST.Text);
            TNMBATST = ToDecimal(formBahaie.txtTNMBATST.Text);
            TMMBATST = ToDecimal(formBahaie.txtTMMBATST.Text);

            TMGHMJTSKH = ToDecimal(formBahaie.txtTMGHMJTSKH.Text);
            TNMJTSKH = ToDecimal(formBahaie.txtTNMJTSKH.Text);
            TMMJTSKH = ToDecimal(formBahaie.txtTMMJTSKH.Text);

            TMGHZA = ToDecimal(formBahaie.txtTMGHZA.Text);
            TNZA = ToDecimal(formBahaie.txtTNZA.Text);
            TMZA = ToDecimal(formBahaie.txtTMZA.Text);

            TMGHMPD = ToDecimal(formBahaie.txtTMGHMPD.Text);
            TNMPD = ToDecimal(formBahaie.txtTNMPD.Text);
            TMMPD = ToDecimal(formBahaie.txtTMMPD.Text);

            TMGHZ = ToDecimal(formBahaie.txtTMGHZ.Text);
            TNZ = ToDecimal(formBahaie.txtTNZ.Text);
            TMZ = ToDecimal(formBahaie.txtTMZ.Text);

            TMGHHDS = ToDecimal(formBahaie.txtTMGHHDS.Text);
            TNHDS = ToDecimal(formBahaie.txtTNHDS.Text);
            TMHDS = ToDecimal(formBahaie.txtTMHDS.Text);

            TMGHSum = ToDecimal(formBahaie.txtTMGHSum.Text);
            TNSum = ToDecimal(formBahaie.txtTNSum.Text);
            TMSum = ToDecimal(formBahaie.txtTMSum.Text);

            // ====================================================
            // شنبلیله (SHN)
            // ====================================================
            SHNMGHMAD = ToDecimal(formBahaie.txtSHNMGHMAD.Text);
            SHNNMAD = ToDecimal(formBahaie.txtSHNNMAD.Text);
            SHNMMAD = ToDecimal(formBahaie.txtSHNMMAD.Text);

            SHNMGHKHTDPN = ToDecimal(formBahaie.txtSHNMGHKHTDPN.Text);
            SHNNKHTDPN = ToDecimal(formBahaie.txtSHNNKHTDPN.Text);
            SHNMKHTDPN = ToDecimal(formBahaie.txtSHNMKHTDPN.Text);

            SHNMGHKHTDPSH = ToDecimal(formBahaie.txtSHNMGHKHTDPSH.Text);
            SHNNKHTDPSH = ToDecimal(formBahaie.txtSHNNKHTDPSH.Text);
            SHNMKHTDPSH = ToDecimal(formBahaie.txtSHNMKHTDPSH.Text);

            SHNMGHBTSHFSPSH = ToDecimal(formBahaie.txtSHNMGHBTSHFSPSH.Text);
            SHNNBTSHFSPSH = ToDecimal(formBahaie.txtSHNNBTSHFSPSH.Text);
            SHNMBTSHFSPSH = ToDecimal(formBahaie.txtSHNMBTSHFSPSH.Text);

            SHNMGHMJTMM = ToDecimal(formBahaie.txtSHNMGHMJTMM.Text);
            SHNNMJTMM = ToDecimal(formBahaie.txtSHNNMJTMM.Text);
            SHNMMJTMM = ToDecimal(formBahaie.txtSHNMMJTMM.Text);

            SHNMGHMJTSM = ToDecimal(formBahaie.txtSHNMGHMJTSM.Text);
            SHNNMJTSM = ToDecimal(formBahaie.txtSHNNMJTSM.Text);
            SHNMMJTSM = ToDecimal(formBahaie.txtSHNMMJTSM.Text);

            SHNMGHMBATST = ToDecimal(formBahaie.txtSHNMGHMBATST.Text);
            SHNNMBATST = ToDecimal(formBahaie.txtSHNNMBATST.Text);
            SHNMMBATST = ToDecimal(formBahaie.txtSHNMMBATST.Text);

            SHNMGHMJTSKH = ToDecimal(formBahaie.txtSHNMGHMJTSKH.Text);
            SHNNMJTSKH = ToDecimal(formBahaie.txtSHNNMJTSKH.Text);
            SHNMMJTSKH = ToDecimal(formBahaie.txtSHNMMJTSKH.Text);

            SHNMGHZA = ToDecimal(formBahaie.txtSHNMGHZA.Text);
            SHNNZA = ToDecimal(formBahaie.txtSHNNZA.Text);
            SHNMZA = ToDecimal(formBahaie.txtSHNMZA.Text);

            SHNMGHMPD = ToDecimal(formBahaie.txtSHNMGHMPD.Text);
            SHNNMPD = ToDecimal(formBahaie.txtSHNNMPD.Text);
            SHNMMPD = ToDecimal(formBahaie.txtSHNMMPD.Text);

            SHNMGHZ = ToDecimal(formBahaie.txtSHNMGHZ.Text);
            SHNNZ = ToDecimal(formBahaie.txtSHNNZ.Text);
            SHNMZ = ToDecimal(formBahaie.txtSHNMZ.Text);

            SHNMGHHDS = ToDecimal(formBahaie.txtSHNMGHHDS.Text);
            SHNNHDS = ToDecimal(formBahaie.txtSHNNHDS.Text);
            SHNMHDS = ToDecimal(formBahaie.txtSHNMHDS.Text);

            SHNMGHSum = ToDecimal(formBahaie.txtSHNMGHSum.Text);
            SHNNSum = ToDecimal(formBahaie.txtSHNNSum.Text);
            SHNMSum = ToDecimal(formBahaie.txtSHNMSum.Text);

            // ====================================================
            // اسفناج (E)
            // ====================================================
            EMGHMAD = ToDecimal(formBahaie.txtEMGHMAD.Text);
            ENMAD = ToDecimal(formBahaie.txtENMAD.Text);
            EMMAD = ToDecimal(formBahaie.txtEMMAD.Text);

            EMGHKHTDPN = ToDecimal(formBahaie.txtEMGHKHTDPN.Text);
            ENKHTDPN = ToDecimal(formBahaie.txtENKHTDPN.Text);
            EMKHTDPN = ToDecimal(formBahaie.txtEMKHTDPN.Text);

            EMGHKHTDPSH = ToDecimal(formBahaie.txtEMGHKHTDPSH.Text);
            ENKHTDPSH = ToDecimal(formBahaie.txtENKHTDPSH.Text);
            EMKHTDPSH = ToDecimal(formBahaie.txtEMKHTDPSH.Text);

            EMGHBTSHFSPSH = ToDecimal(formBahaie.txtEMGHBTSHFSPSH.Text);
            ENBTSHFSPSH = ToDecimal(formBahaie.txtENBTSHFSPSH.Text);
            EMBTSHFSPSH = ToDecimal(formBahaie.txtEMBTSHFSPSH.Text);

            EMGHMJTMM = ToDecimal(formBahaie.txtEMGHMJTMM.Text);
            ENMJTMM = ToDecimal(formBahaie.txtENMJTMM.Text);
            EMMJTMM = ToDecimal(formBahaie.txtEMMJTMM.Text);

            EMGHMJTSM = ToDecimal(formBahaie.txtEMGHMJTSM.Text);
            ENMJTSM = ToDecimal(formBahaie.txtENMJTSM.Text);
            EMMJTSM = ToDecimal(formBahaie.txtEMMJTSM.Text);

            EMGHMBATST = ToDecimal(formBahaie.txtEMGHMBATST.Text);
            ENMBATST = ToDecimal(formBahaie.txtENMBATST.Text);
            EMMBATST = ToDecimal(formBahaie.txtEMMBATST.Text);

            EMGHMJTSKH = ToDecimal(formBahaie.txtEMGHMJTSKH.Text);
            ENMJTSKH = ToDecimal(formBahaie.txtENMJTSKH.Text);
            EMMJTSKH = ToDecimal(formBahaie.txtEMMJTSKH.Text);

            EMGHZA = ToDecimal(formBahaie.txtEMGHZA.Text);
            ENZA = ToDecimal(formBahaie.txtENZA.Text);
            EMZA = ToDecimal(formBahaie.txtEMZA.Text);

            EMGHMPD = ToDecimal(formBahaie.txtEMGHMPD.Text);
            ENMPD = ToDecimal(formBahaie.txtENMPD.Text);
            EMMPD = ToDecimal(formBahaie.txtEMMPD.Text);

            EMGHZ = ToDecimal(formBahaie.txtEMGHZ.Text);
            ENZ = ToDecimal(formBahaie.txtENZ.Text);
            EMZ = ToDecimal(formBahaie.txtEMZ.Text);

            EMGHHDS = ToDecimal(formBahaie.txtEMGHHDS.Text);
            ENHDS = ToDecimal(formBahaie.txtENHDS.Text);
            EMHDS = ToDecimal(formBahaie.txtEMHDS.Text);

            EMGHSum = ToDecimal(formBahaie.txtEMGHSum.Text);
            ENSum = ToDecimal(formBahaie.txtENSum.Text);
            EMSum = ToDecimal(formBahaie.txtEMSum.Text);

            // ====================================================
            // گشنیز (G)
            // ====================================================
            GMGHMAD = ToDecimal(formBahaie.txtGMGHMAD.Text);
            GNMAD = ToDecimal(formBahaie.txtGNMAD.Text);
            GMMAD = ToDecimal(formBahaie.txtGMMAD.Text);

            GMGHKHTDPN = ToDecimal(formBahaie.txtGMGHKHTDPN.Text);
            GNKHTDPN = ToDecimal(formBahaie.txtGNKHTDPN.Text);
            GMKHTDPN = ToDecimal(formBahaie.txtGMKHTDPN.Text);

            GMGHKHTDPSH = ToDecimal(formBahaie.txtGMGHKHTDPSH.Text);
            GNKHTDPSH = ToDecimal(formBahaie.txtGNKHTDPSH.Text);
            GMKHTDPSH = ToDecimal(formBahaie.txtGMKHTDPSH.Text);

            GMGHBTSHFSPSH = ToDecimal(formBahaie.txtGMGHBTSHFSPSH.Text);
            GNBTSHFSPSH = ToDecimal(formBahaie.txtGNBTSHFSPSH.Text);
            GMBTSHFSPSH = ToDecimal(formBahaie.txtGMBTSHFSPSH.Text);

            GMGHMJTMM = ToDecimal(formBahaie.txtGMGHMJTMM.Text);
            GNMJTMM = ToDecimal(formBahaie.txtGNMJTMM.Text);
            GMMJTMM = ToDecimal(formBahaie.txtGMMJTMM.Text);

            GMGHMJTSM = ToDecimal(formBahaie.txtGMGHMJTSM.Text);
            GNMJTSM = ToDecimal(formBahaie.txtGNMJTSM.Text);
            GMMJTSM = ToDecimal(formBahaie.txtGMMJTSM.Text);

            GMGHMBATST = ToDecimal(formBahaie.txtGMGHMBATST.Text);
            GNMBATST = ToDecimal(formBahaie.txtGNMBATST.Text);
            GMMBATST = ToDecimal(formBahaie.txtGMMBATST.Text);

            GMGHMJTSKH = ToDecimal(formBahaie.txtGMGHMJTSKH.Text);
            GNMJTSKH = ToDecimal(formBahaie.txtGNMJTSKH.Text);
            GMMJTSKH = ToDecimal(formBahaie.txtGMMJTSKH.Text);

            GMGHZA = ToDecimal(formBahaie.txtGMGHZA.Text);
            GNZA = ToDecimal(formBahaie.txtGNZA.Text);
            GMZA = ToDecimal(formBahaie.txtGMZA.Text);

            GMGHMPD = ToDecimal(formBahaie.txtGMGHMPD.Text);
            GNMPD = ToDecimal(formBahaie.txtGNMPD.Text);
            GMMPD = ToDecimal(formBahaie.txtGMMPD.Text);

            GMGHZ = ToDecimal(formBahaie.txtGMGHZ.Text);
            GNZ = ToDecimal(formBahaie.txtGNZ.Text);
            GMZ = ToDecimal(formBahaie.txtGMZ.Text);

            GMGHHDS = ToDecimal(formBahaie.txtGMGHHDS.Text);
            GNHDS = ToDecimal(formBahaie.txtGNHDS.Text);
            GMHDS = ToDecimal(formBahaie.txtGMHDS.Text);

            GMGHSum = ToDecimal(formBahaie.txtGMGHSum.Text);
            GNSum = ToDecimal(formBahaie.txtGNSum.Text);
            GMSum = ToDecimal(formBahaie.txtGMSum.Text);

            // ====================================================
            // قورمه سبزی (GHM)
            // ====================================================
            GHMGHMAD = ToDecimal(formBahaie.txtGHMGHMAD.Text);
            GHNMAD = ToDecimal(formBahaie.txtGHNMAD.Text);
            GHMMAD = ToDecimal(formBahaie.txtGHMMAD.Text);

            GHMGHKHTDPN = ToDecimal(formBahaie.txtGHMGHKHTDPN.Text);
            GHNKHTDPN = ToDecimal(formBahaie.txtGHNKHTDPN.Text);
            GHMKHTDPN = ToDecimal(formBahaie.txtGHMKHTDPN.Text);

            GHMGHKHTDPSH = ToDecimal(formBahaie.txtGHMGHKHTDPSH.Text);
            GHNKHTDPSH = ToDecimal(formBahaie.txtGHNKHTDPSH.Text);
            GHMKHTDPSH = ToDecimal(formBahaie.txtGHMKHTDPSH.Text);

            GHMGHBTSHFSPSH = ToDecimal(formBahaie.txtGHMGHBTSHFSPSH.Text);
            GHNBTSHFSPSH = ToDecimal(formBahaie.txtGHNBTSHFSPSH.Text);
            GHMBTSHFSPSH = ToDecimal(formBahaie.txtGHMBTSHFSPSH.Text);

            GHMGHMJTMM = ToDecimal(formBahaie.txtGHMGHMJTMM.Text);
            GHNMJTMM = ToDecimal(formBahaie.txtGHNMJTMM.Text);
            GHMMJTMM = ToDecimal(formBahaie.txtGHMMJTMM.Text);

            GHMGHMJTSM = ToDecimal(formBahaie.txtGHMGHMJTSM.Text);
            GHNMJTSM = ToDecimal(formBahaie.txtGHNMJTSM.Text);
            GHMMJTSM = ToDecimal(formBahaie.txtGHMMJTSM.Text);

            GHMGHMBATST = ToDecimal(formBahaie.txtGHMGHMBATST.Text);
            GHNMBATST = ToDecimal(formBahaie.txtGHNMBATST.Text);
            GHMMBATST = ToDecimal(formBahaie.txtGHMMBATST.Text);

            GHMGHMJTSKH = ToDecimal(formBahaie.txtGHMGHMJTSKH.Text);
            GHNMJTSKH = ToDecimal(formBahaie.txtGHNMJTSKH.Text);
            GHMMJTSKH = ToDecimal(formBahaie.txtGHMMJTSKH.Text);

            GHMGHZA = ToDecimal(formBahaie.txtGHMGHZA.Text);
            GHNZA = ToDecimal(formBahaie.txtGHNZA.Text);
            GHMZA = ToDecimal(formBahaie.txtGHMZA.Text);

            GHMGHMPD = ToDecimal(formBahaie.txtGHMGHMPD.Text);
            GHNMPD = ToDecimal(formBahaie.txtGHNMPD.Text);
            GHMMPD = ToDecimal(formBahaie.txtGHMMPD.Text);

            GHMGHZ = ToDecimal(formBahaie.txtGHMGHZ.Text);
            GHNZ = ToDecimal(formBahaie.txtGHNZ.Text);
            GHMZ = ToDecimal(formBahaie.txtGHMZ.Text);

            GHMGHHDS = ToDecimal(formBahaie.txtGHMGHHDS.Text);
            GHNHDS = ToDecimal(formBahaie.txtGHNHDS.Text);
            GHMHDS = ToDecimal(formBahaie.txtGHMHDS.Text);

            GHMGHSum = ToDecimal(formBahaie.txtGHMGHSum.Text);
            GHNSum = ToDecimal(formBahaie.txtGHNSum.Text);
            GHMSum = ToDecimal(formBahaie.txtGHMSum.Text);

            // ====================================================
            // هویج و پیاز (HP)
            // ====================================================
            HPMGHMAD = ToDecimal(formBahaie.txtHPMGHMAD.Text);
            HPNMAD = ToDecimal(formBahaie.txtHPNMAD.Text);
            HPMAD = ToDecimal(formBahaie.txtHPMMAD.Text);

            HPMGHKHTDPN = ToDecimal(formBahaie.txtHPMGHKHTDPN.Text);
            HPNKHTDPN = ToDecimal(formBahaie.txtHPNKHTDPN.Text);
            HPMKHTDPN = ToDecimal(formBahaie.txtHPMKHTDPN.Text);

            HPMGHKHTDPSH = ToDecimal(formBahaie.txtHPMGHKHTDPSH.Text);
            HPNKHTDPSH = ToDecimal(formBahaie.txtHPNKHTDPSH.Text);
            HPMKHTDPSH = ToDecimal(formBahaie.txtHPMKHTDPSH.Text);

            HPMGHBTSHFSPSH = ToDecimal(formBahaie.txtHPMGHBTSHFSPSH.Text);
            HPNBTSHFSPSH = ToDecimal(formBahaie.txtHPNBTSHFSPSH.Text);
            HPMBTSHFSPSH = ToDecimal(formBahaie.txtHPMBTSHFSPSH.Text);

            HPMGHMJTMM = ToDecimal(formBahaie.txtHPMGHMJTMM.Text);
            HPNMJTMM = ToDecimal(formBahaie.txtHPNMJTMM.Text);
            HPMMJTMM = ToDecimal(formBahaie.txtHPMMJTMM.Text);

            HPMGHMJTSM = ToDecimal(formBahaie.txtHPMGHMJTSM.Text);
            HPNMJTSM = ToDecimal(formBahaie.txtHPNMJTSM.Text);
            HPMMJTSM = ToDecimal(formBahaie.txtHPMMJTSM.Text);

            HPMGHMBATST = ToDecimal(formBahaie.txtHPMGHMBATST.Text);
            HPNMBATST = ToDecimal(formBahaie.txtHPNMBATST.Text);
            HPMMBATST = ToDecimal(formBahaie.txtHPMMBATST.Text);

            HPMGHMJTSKH = ToDecimal(formBahaie.txtHPMGHMJTSKH.Text);
            HPNMJTSKH = ToDecimal(formBahaie.txtHPNMJTSKH.Text);
            HPMMJTSKH = ToDecimal(formBahaie.txtHPMMJTSKH.Text);

            HPMGHZA = ToDecimal(formBahaie.txtHPMGHZA.Text);
            HPNZA = ToDecimal(formBahaie.txtHPNZA.Text);
            HPMZA = ToDecimal(formBahaie.txtHPMZA.Text);

            HPMGHMPD = ToDecimal(formBahaie.txtHPMGHMPD.Text);
            HPNMPD = ToDecimal(formBahaie.txtHPNMPD.Text);
            HPMMPD = ToDecimal(formBahaie.txtHPMMPD.Text);

            HPMGHZ = ToDecimal(formBahaie.txtHPMGHZ.Text);
            HPNZ = ToDecimal(formBahaie.txtHPNZ.Text);
            HPMZ = ToDecimal(formBahaie.txtHPMZ.Text);

            HPMGHHDS = ToDecimal(formBahaie.txtHPMGHHDS.Text);
            HPNHDS = ToDecimal(formBahaie.txtHPNHDS.Text);
            HPMHDS = ToDecimal(formBahaie.txtHPMHDS.Text);

            HPMGHSum = ToDecimal(formBahaie.txtHPMGHSum.Text);
            HPNSum = ToDecimal(formBahaie.txtHPNSum.Text);
            HPMSum = ToDecimal(formBahaie.txtHPMSum.Text);

            // ====================================================
            // لوبیا سبز (L)
            // ====================================================
            LMGHMAD = ToDecimal(formBahaie.txtLMGHMAD.Text);
            LNMAD = ToDecimal(formBahaie.txtLNMAD.Text);
            LMMAD = ToDecimal(formBahaie.txtLMMAD.Text);

            LMGHKHTDPN = ToDecimal(formBahaie.txtLMGHKHTDPN.Text);
            LNKHTDPN = ToDecimal(formBahaie.txtLNKHTDPN.Text);
            LMKHTDPN = ToDecimal(formBahaie.txtLMKHTDPN.Text);

            LMGHKHTDPSH = ToDecimal(formBahaie.txtLMGHKHTDPSH.Text);
            LNKHTDPSH = ToDecimal(formBahaie.txtLNKHTDPSH.Text);
            LMKHTDPSH = ToDecimal(formBahaie.txtLMKHTDPSH.Text);

            LMGHBTSHFSPSH = ToDecimal(formBahaie.txtLMGHBTSHFSPSH.Text);
            LNBTSHFSPSH = ToDecimal(formBahaie.txtLNBTSHFSPSH.Text);
            LMBTSHFSPSH = ToDecimal(formBahaie.txtLMBTSHFSPSH.Text);

            LMGHMJTMM = ToDecimal(formBahaie.txtLMGHMJTMM.Text);
            LNMJTMM = ToDecimal(formBahaie.txtLNMJTMM.Text);
            LMMJTMM = ToDecimal(formBahaie.txtLMMJTMM.Text);

            LMGHMJTSM = ToDecimal(formBahaie.txtLMGHMJTSM.Text);
            LNMJTSM = ToDecimal(formBahaie.txtLNMJTSM.Text);
            LMMJTSM = ToDecimal(formBahaie.txtLMMJTSM.Text);

            LMGHMBATST = ToDecimal(formBahaie.txtLMGHMBATST.Text);
            LNMBATST = ToDecimal(formBahaie.txtLNMBATST.Text);
            LMMBATST = ToDecimal(formBahaie.txtLMMBATST.Text);

            LMGHMJTSKH = ToDecimal(formBahaie.txtLMGHMJTSKH.Text);
            LNMJTSKH = ToDecimal(formBahaie.txtLNMJTSKH.Text);
            LMMJTSKH = ToDecimal(formBahaie.txtLMMJTSKH.Text);

            LMGHZA = ToDecimal(formBahaie.txtLMGHZA.Text);
            LNZA = ToDecimal(formBahaie.txtLNZA.Text);
            LMZA = ToDecimal(formBahaie.txtLMZA.Text);

            LMGHMPD = ToDecimal(formBahaie.txtLMGHMPD.Text);
            LNMPD = ToDecimal(formBahaie.txtLNMPD.Text);
            LMMPD = ToDecimal(formBahaie.txtLMMPD.Text);

            LMGHZ = ToDecimal(formBahaie.txtLMGHZ.Text);
            LNZ = ToDecimal(formBahaie.txtLNZ.Text);
            LMZ = ToDecimal(formBahaie.txtLMZ.Text);

            LMGHHDS = ToDecimal(formBahaie.txtLMGHHDS.Text);
            LNHDS = ToDecimal(formBahaie.txtLNHDS.Text);
            LMHDS = ToDecimal(formBahaie.txtLMHDS.Text);

            LMGHSum = ToDecimal(formBahaie.txtLMGHSum.Text);
            LNSum = ToDecimal(formBahaie.txtLNSum.Text);
            LMSum = ToDecimal(formBahaie.txtLMSum.Text);

            // ====================================================
            // کرفس (K)
            // ====================================================
            KMGHMAD = ToDecimal(formBahaie.txtKMGHMAD.Text);
            KNMAD = ToDecimal(formBahaie.txtKNMAD.Text);
            KMMAD = ToDecimal(formBahaie.txtKMMAD.Text);

            KMGHKHTDPN = ToDecimal(formBahaie.txtKMGHKHTDPN.Text);
            KNKHTDPN = ToDecimal(formBahaie.txtKNKHTDPN.Text);
            KMKHTDPN = ToDecimal(formBahaie.txtKMKHTDPN.Text);

            KMGHKHTDPSH = ToDecimal(formBahaie.txtKMGHKHTDPSH.Text);
            KNKHTDPSH = ToDecimal(formBahaie.txtKNKHTDPSH.Text);
            KMKHTDPSH = ToDecimal(formBahaie.txtKMKHTDPSH.Text);

            KMGHBTSHFSPSH = ToDecimal(formBahaie.txtKMGHBTSHFSPSH.Text);
            KNBTSHFSPSH = ToDecimal(formBahaie.txtKNBTSHFSPSH.Text);
            KMBTSHFSPSH = ToDecimal(formBahaie.txtKMBTSHFSPSH.Text);

            KMGHMJTMM = ToDecimal(formBahaie.txtKMGHMJTMM.Text);
            KNMJTMM = ToDecimal(formBahaie.txtKNMJTMM.Text);
            KMMJTMM = ToDecimal(formBahaie.txtKMMJTMM.Text);

            KMGHMJTSM = ToDecimal(formBahaie.txtKMGHMJTSM.Text);
            KNMJTSM = ToDecimal(formBahaie.txtKNMJTSM.Text);
            KMMJTSM = ToDecimal(formBahaie.txtKMMJTSM.Text);

            KMGHMBATST = ToDecimal(formBahaie.txtKMGHMBATST.Text);
            KNMBATST = ToDecimal(formBahaie.txtKNMBATST.Text);
            KMMBATST = ToDecimal(formBahaie.txtKMMBATST.Text);

            KMGHMJTSKH = ToDecimal(formBahaie.txtKMGHMJTSKH.Text);
            KNMJTSKH = ToDecimal(formBahaie.txtKNMJTSKH.Text);
            KMMJTSKH = ToDecimal(formBahaie.txtKMMJTSKH.Text);

            KMGHZA = ToDecimal(formBahaie.txtKMGHZA.Text);
            KNZA = ToDecimal(formBahaie.txtKNZA.Text);
            KMZA = ToDecimal(formBahaie.txtKMZA.Text);

            KMGHMPD = ToDecimal(formBahaie.txtKMGHMPD.Text);
            KNMPD = ToDecimal(formBahaie.txtKNMPD.Text);
            KMMPD = ToDecimal(formBahaie.txtKMMPD.Text);

            KMGHZ = ToDecimal(formBahaie.txtKMGHZ.Text);
            KNZ = ToDecimal(formBahaie.txtKNZ.Text);
            KMZ = ToDecimal(formBahaie.txtKMZ.Text);

            KMGHHDS = ToDecimal(formBahaie.txtKMGHHDS.Text);
            KNHDS = ToDecimal(formBahaie.txtKNHDS.Text);
            KMHDS = ToDecimal(formBahaie.txtKMHDS.Text);

            KMGHSum = ToDecimal(formBahaie.txtKMGHSum.Text);
            KNSum = ToDecimal(formBahaie.txtKNSum.Text);
            KMSum = ToDecimal(formBahaie.txtKMSum.Text);

            // ====================================================
            // شوید (SHV)
            // ====================================================
            SHVMGHMAD = ToDecimal(formBahaie.txtSHVMGHMAD.Text);
            SHVNMAD = ToDecimal(formBahaie.txtSHVNMAD.Text);
            SHVMMAD = ToDecimal(formBahaie.txtSHVMMAD.Text);

            SHVMGHKHTDPN = ToDecimal(formBahaie.txtSHVMGHKHTDPN.Text);
            SHVNKHTDPN = ToDecimal(formBahaie.txtSHVNKHTDPN.Text);
            SHVMKHTDPN = ToDecimal(formBahaie.txtSHVMKHTDPN.Text);

            SHVMGHKHTDPSH = ToDecimal(formBahaie.txtSHVMGHKHTDPSH.Text);
            SHVNKHTDPSH = ToDecimal(formBahaie.txtSHVNKHTDPSH.Text);
            SHVMKHTDPSH = ToDecimal(formBahaie.txtSHVMKHTDPSH.Text);

            SHVMGHBTSHFSPSH = ToDecimal(formBahaie.txtSHVMGHBTSHFSPSH.Text);
            SHVNBTSHFSPSH = ToDecimal(formBahaie.txtSHVNBTSHFSPSH.Text);
            SHVMBTSHFSPSH = ToDecimal(formBahaie.txtSHVMBTSHFSPSH.Text);

            SHVMGHMJTMM = ToDecimal(formBahaie.txtSHVMGHMJTMM.Text);
            SHVNMJTMM = ToDecimal(formBahaie.txtSHVNMJTMM.Text);
            SHVMMJTMM = ToDecimal(formBahaie.txtSHVMMJTMM.Text);

            SHVMGHMJTSM = ToDecimal(formBahaie.txtSHVMGHMJTSM.Text);
            SHVNMJTSM = ToDecimal(formBahaie.txtSHVNMJTSM.Text);
            SHVMMJTSM = ToDecimal(formBahaie.txtSHVMMJTSM.Text);

            SHVMGHMBATST = ToDecimal(formBahaie.txtSHVMGHMBATST.Text);
            SHVNMBATST = ToDecimal(formBahaie.txtSHVNMBATST.Text);
            SHVMMBATST = ToDecimal(formBahaie.txtSHVMMBATST.Text);

            SHVMGHMJTSKH = ToDecimal(formBahaie.txtSHVMGHMJTSKH.Text);
            SHVNMJTSKH = ToDecimal(formBahaie.txtSHVNMJTSKH.Text);
            SHVMMJTSKH = ToDecimal(formBahaie.txtSHVMMJTSKH.Text);

            SHVMGHZA = ToDecimal(formBahaie.txtSHVMGHZA.Text);
            SHVNZA = ToDecimal(formBahaie.txtSHVNZA.Text);
            SHVMZA = ToDecimal(formBahaie.txtSHVMZA.Text);

            SHVMGHMPD = ToDecimal(formBahaie.txtSHVMGHMPD.Text);
            SHVNMPD = ToDecimal(formBahaie.txtSHVNMPD.Text);
            SHVMMPD = ToDecimal(formBahaie.txtSHVMMPD.Text);

            SHVMGHZ = ToDecimal(formBahaie.txtSHVMGHZ.Text);
            SHVNZ = ToDecimal(formBahaie.txtSHVNZ.Text);
            SHVMZ = ToDecimal(formBahaie.txtSHVMZ.Text);

            SHVMGHHDS = ToDecimal(formBahaie.txtSHVMGHHDS.Text);
            SHVNHDS = ToDecimal(formBahaie.txtSHVNHDS.Text);
            SHVMHDS = ToDecimal(formBahaie.txtSHVMHDS.Text);

            SHVMGHSum = ToDecimal(formBahaie.txtSHVMGHSum.Text);
            SHVNSum = ToDecimal(formBahaie.txtSHVNSum.Text);
            SHVMSum = ToDecimal(formBahaie.txtSHVMSum.Text);

            // ====================================================
            // هزینه‌ها (Hazine)
            // ====================================================
            HazineAZ = ToDecimal(formBahaie.txtHazineAZ.Text);
            SumHazineHS = ToDecimal(formBahaie.txtSumHazineHS.Text);
            HazineMali = ToDecimal(formBahaie.txtHazineMali.Text);
            HazineOET = ToDecimal(formBahaie.txtHazineOET.Text);
            HazineTF = ToDecimal(formBahaie.txtHazineTF.Text);
            HazineBIme23 = ToDecimal(formBahaie.txtHazineBIme23.Text);
            HazineHD = ToDecimal(formBahaie.txtHazineHD.Text);
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
