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
            decimal result = (BahaieTamamShodeDataManager.JMBTSHFSPSH * BahaieTamamShodeDataManager.JMKHTDPN) * (-1(-1 + BahaieTamamShodeDataManager.JMZ));
            return result;
        }
        public static decimal Jafari_BahaieTamamShodeForoshSabziPakShode_Nerkh()
        {
            decimal result = BahaieTamamShodeDataManager.JMGHBTSHFSPSH / BahaieTamamShodeDataManager.JMBTSHFSPSH;
            return result;
        }
    }
}
