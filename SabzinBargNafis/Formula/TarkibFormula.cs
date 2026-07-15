using SabzinBargNafis.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzinBargNafis.Formula
{
    internal class TarkibFormula
    {
        public static decimal Sum_Jafari()
        {
            decimal result = TarkibDataManager.JafariGhorme + TarkibDataManager.JafariAsh + TarkibDataManager.JafariPoloi + TarkibDataManager.JafariKoKo + TarkibDataManager.JafariGhelie + TarkibDataManager.JafariPoloiBaSir;
            return result;
        }
        public static decimal Sum_Tare()
        {
            decimal result = TarkibDataManager.TareGhorme + TarkibDataManager.TareAsh + TarkibDataManager.TarePoloi + TarkibDataManager.TareKoKo + TarkibDataManager.TareGhelie + TarkibDataManager.TarePoloiBaSir;
            return result;
        }
        public static decimal Sum_Shevid()
        {
            decimal result = TarkibDataManager.ShevidGhorme + TarkibDataManager.ShevidAsh + TarkibDataManager.ShevidPoloi + TarkibDataManager.ShevidKoKo + TarkibDataManager.ShevidGhelie + TarkibDataManager.ShevidPoloiBaSir;
            return result;
        }
        public static decimal Sum_Esfenag()
        {
            decimal result = TarkibDataManager.EsfenagGhorme + TarkibDataManager.EsfenagAsh + TarkibDataManager.EsfenagPoloi + TarkibDataManager.EsfenagKoKo + TarkibDataManager.EsfenagGhelie + TarkibDataManager.EsfenagPoloiBaSir;
            return result;
        }
        public static decimal Sum_Shanbalile()
        {
            decimal result = TarkibDataManager.ShanbalileGhorme + TarkibDataManager.ShanbalileAsh + TarkibDataManager.ShanbalilePoloi + TarkibDataManager.ShanbalileKoKo + TarkibDataManager.ShanbalileGhelie + TarkibDataManager.ShanbalilePoloiBaSir;
            return result;
        }
        public static decimal Sum_Geshniz()
        {
            decimal result = TarkibDataManager.GhishnizGhorme + TarkibDataManager.GhishnizAsh + TarkibDataManager.GhishnizPoloi + TarkibDataManager.GhishnizKoKo + TarkibDataManager.GhishnizGhelie + TarkibDataManager.GhishnizPoloiBaSir;
            return result;
        }
        public static decimal Sum_Nana()
        {
            decimal result = TarkibDataManager.NanaGhorme + TarkibDataManager.NanaAsh + TarkibDataManager.NanaPoloi + TarkibDataManager.NanaKoKo + TarkibDataManager.NanaGhelie + TarkibDataManager.NanaPoloiBaSir;
            return result;
        }
        public static decimal Sum_Sale_Sabzi()
        {
            decimal result = TarkibDataManager.SaleSabziGhorme + TarkibDataManager.SaleSabziAsh + TarkibDataManager.SaleSabziPoloi + TarkibDataManager.SaleSabziKoKo + TarkibDataManager.SaleSabziGhelie + TarkibDataManager.SaleSabziPoloiBaSir;
            return result;
        }
    }
}
