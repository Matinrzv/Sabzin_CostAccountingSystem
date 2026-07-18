using SabzinBargNafis.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzinBargNafis.Formula
{
    internal class BahaieFormula
    {
        
        public static decimal Jafari_KharidTeyDorePakNashode_Nerkh()
        {
            decimal result = BahaieTamamShodeDataManager.JMGHKHTDPN / BahaieTamamShodeDataManager.JMKHTDPN;
            return result;
        }
        public static decimal Jafari_KharidTeyDorePakshode_Nerkh()
        {
            decimal result = BahaieTamamShodeDataManager.JMGHKHTDPSH / BahaieTamamShodeDataManager.JMKHTDPSH;
            return result;
        }
        public static decimal Jafari_BahaieTamamShodeForoshSabziPakShode_Mablagh()
        {
            decimal Number = -1;
            decimal result = (BahaieTamamShodeDataManager.JMBTSHFSPSH * BahaieTamamShodeDataManager.JMKHTDPN) * (Number *(Number + BahaieTamamShodeDataManager.JMZ));
            return result;
        }
        public static decimal Jafari_BahaieTamamShodeForoshSabziPakShode_Nerkh()
        {
            decimal result = BahaieTamamShodeDataManager.JMGHBTSHFSPSH / BahaieTamamShodeDataManager.JMBTSHFSPSH;
            return result;
        }
        public static decimal Jafari_MandeJahatTolidMahsolMakhlot_Meghdar()
        {
            decimal result = BahaieTamamShodeDataManager.JMKHTDPN - (BahaieTamamShodeDataManager.JMMJTMM * (1 - BahaieTamamShodeDataManager.JMZ));
            return result;
        }
        public static decimal Jafari_MandeJahatTolidMahsolMakhlot_Mablagh()
        {
            decimal result = BahaieTamamShodeDataManager.JMMAD + BahaieTamamShodeDataManager.JMKHTDPN
                + BahaieTamamShodeDataManager.JMKHTDPSH + BahaieTamamShodeDataManager.JMBTSHFSPSH;
            return result;
        }
        public static decimal Jafari_MandeJahatTolidMahsolMakhlot_Nerkh()
        {
            decimal result = BahaieTamamShodeDataManager.JMGHMJTMM / BahaieTamamShodeDataManager.JMMJTMM;
            return result;
        }
        public static decimal Jafari_MasrafSabzieTazeJahatTolidSabziMakhlot_Meghdar()
        {
            
            return 237;
        }
        public static decimal Jafari_MasrafSabzieTazeJahatTolidSabziMakhlot_Nerkh()
        {
            decimal Nerkh = BahaieTamamShodeDataManager.JNMJTMM;
            return Nerkh;
        }
        public static decimal Jafari_MasrafSabzieTazeJahatTolidSabziMakhlot_Mablagh()
        {
            decimal result = Jafari_MasrafSabzieTazeJahatTolidSabziMakhlot_Nerkh() * Jafari_MasrafSabzieTazeJahatTolidSabziMakhlot_Meghdar();
            return result;
        }
        public static decimal Jafari_MandeBadAzTolidSabziTaze_Meghdar()
        {
            decimal Meghdar1 = 237;
            decimal Meghdar = BahaieTamamShodeDataManager.JMMJTMM - Meghdar1;
            return Meghdar;
        }
        public static decimal Jafari_MandeBadAzTolidSabziTaze_Nerkh()
        {
            decimal Nerkh = TarkibDataManager.JafariSum;
            return Nerkh;
        }
        public static decimal Jafari_MandeBadAzTolidSabziTaze_Mablagh()
        {
            decimal result = Jafari_MandeBadAzTolidSabziTaze_Nerkh() * Jafari_MandeBadAzTolidSabziTaze_Meghdar();
            return result;
        }
        public static decimal Jafari_ZaieatAdi_Meghdar()
        {
            decimal Meghdar = BahaieTamamShodeDataManager.JMMBATST - BahaieTamamShodeDataManager.JMMJTSKH;
            return Meghdar;
        }
        public static decimal Jafari_ZaieatAdi_Nerkh()
        {
            decimal Nerkh = BahaieTamamShodeDataManager.JNMBATST - BahaieTamamShodeDataManager.JNMJTSKH;
            return Nerkh;
        }
        public static decimal Jafari_ZaieatAdi_Mablagh()
        {
            decimal Mablagh = BahaieTamamShodeDataManager.JMGHMBATST - BahaieTamamShodeDataManager.JMGHMJTSKH;
            return Mablagh;
        }
        public static decimal Jafari_MandePaianDore_Meghdar()
        {
            decimal Meghdar = BahaieTamamShodeDataManager.JMMBATST - BahaieTamamShodeDataManager.JMMJTSKH - BahaieTamamShodeDataManager.JMZA;
            return Meghdar;
        }
        public static decimal Jafari_MandePaianDore_Nerkh()
        {
            decimal Nerkh = BahaieTamamShodeDataManager.JNMBATST - BahaieTamamShodeDataManager.JNMJTSKH - BahaieTamamShodeDataManager.JNZA;
            return Nerkh;
        }
        public static decimal Jafari_MandePaianDore_Mablagh()
        {
            decimal Mablagh = BahaieTamamShodeDataManager.JMGHMBATST - BahaieTamamShodeDataManager.JMGHMJTSKH - BahaieTamamShodeDataManager.JMGHZA;
            return Mablagh;
        }
        public static decimal Jafari_Zaieat_Meghdar()
        {
            decimal Meghdar = 237;
            decimal result = ((BahaieTamamShodeDataManager.JMBTSHFSPSH + Meghdar) / BahaieTamamShodeDataManager.JMKHTDPN) - 1;
            return result;
        }
        public static decimal Jafari_HoghoghVDastmozdVSarBar_Meghdar()
        {
            decimal Meghdar = BahaieTamamShodeDataManager.JMBTSHFSPSH;
            return Meghdar;
        }
        public static decimal Jafari_HoghoghVDastmozdVSarBar_Mablagh()
        {
            decimal SumBahaieTamamShodeSabziPakShode = BahaieTamamShodeDataManager.JMBTSHFSPSH +
            BahaieTamamShodeDataManager.SHVMBTSHFSPSH + BahaieTamamShodeDataManager.EMGHBTSHFSPSH +
            BahaieTamamShodeDataManager.TMBTSHFSPSH + BahaieTamamShodeDataManager.SHNMBTSHFSPSH +
            BahaieTamamShodeDataManager.GHMBTSHFSPSH + BahaieTamamShodeDataManager.HPMBTSHFSPSH +
            BahaieTamamShodeDataManager.LMBTSHFSPSH + BahaieTamamShodeDataManager.KMBTSHFSPSH +
            BahaieTamamShodeDataManager.GMBTSHFSPSH;
            decimal Mablagh = (BahaieTamamShodeDataManager.JMZA / SumBahaieTamamShodeSabziPakShode) * BahaieTamamShodeDataManager.SumHazineHS;
            return Mablagh;
        }
        public static decimal Jafari_HoghoghVDastmozdVSarBar_Nerkh()
        {
            decimal Nerkh = BahaieTamamShodeDataManager.JMGHHDS / BahaieTamamShodeDataManager.JMHDS;
            return Nerkh;
        }
        public static decimal Jafari_Sum_Meghdar()
        {
            decimal Meghdar = BahaieTamamShodeDataManager.JMBTSHFSPSH;
            return Meghdar;
        }
        public static decimal Jafari_Sum_Mablagh()
        {
            decimal Mablagh = BahaieTamamShodeDataManager.JMGHMAD + BahaieTamamShodeDataManager.JMGHKHTDPN
                + BahaieTamamShodeDataManager.JMGHKHTDPSH + BahaieTamamShodeDataManager.JMGHHDS;
            return Mablagh;
        }
        public static decimal Jafari_Sum_Nerkh()
        {
            decimal Nerkh = BahaieTamamShodeDataManager.JMGHSum / BahaieTamamShodeDataManager.JMSum;
            return Nerkh;
        }
    }
}
