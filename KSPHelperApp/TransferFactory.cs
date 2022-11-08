using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KSPHelperApp
{
    internal static class TransferFactory
    {
        public static Transfer Create()
        {
            var kerbin = new Transfer("Kerbin", 0);
            var lko = new Transfer("Low Kerbin Orbit", 3400);
            var kerTrans = new Transfer("Kerbin Transfer", 950);
            var keostat = new Transfer("Keostationary", 1115);
            var muntrans = new Transfer("Mun Transfer", 860);
            var munorbit = new Transfer("Mun Orbit", 580);
            var mun = new Transfer("Mun", 580);
            var minmustrans = new Transfer("Minmus Transfer", 930);
            var minmusorbit = new Transfer("Minmus Orbit", 150);
            var minmus = new Transfer("Minmus", 180);
            var eelootrans = new Transfer("Eeloo Transfer", 1140);
            var eelooorbit = new Transfer("Eeloo Orbit", 1370);
            var eeloo = new Transfer("Eeloo", 620);
            var mohotrans = new Transfer("Moho Transfer", 760);
            var mohoorbit = new Transfer("Moho Orbit", 2400);
            var moho = new Transfer("Moho", 870);
            var evetrans = new Transfer("Eve Transfer", 150);
            var eveorbit = new Transfer("Eve Orbit", 1400);
            var eve = new Transfer("Eve", 8000);
            var gillytrans = new Transfer("Gilly Transfer", 490);
            var gillyorbit = new Transfer("Gilly Orbit", 410);
            var gilly = new Transfer("Gilly", 30);
            var dunatrans = new Transfer("Duna Transfer", 130);
            var dunaorbit = new Transfer("Duna Orbit", 600);
            var duna = new Transfer("Duna", 1450);
            var iketrans = new Transfer("Ike Transfer", 280);
            var ikeorbit = new Transfer("Ike Orbit", 150);
            var ike = new Transfer("Ike", 390);
            var drestrans = new Transfer("Dres Transfer", 1010);
            var dresorbit = new Transfer("Dres Orbit", 1300);
            var dres = new Transfer("Dres", 430);

            kerbin.AddTransfer(lko);
            lko.AddTransfer(keostat).AddTransfer(muntrans).AddTransfer(minmustrans).AddTransfer(kerTrans);
            kerTrans.AddTransfer(eelootrans).AddTransfer(mohotrans).AddTransfer(evetrans).AddTransfer(dunatrans).AddTransfer(drestrans);
            muntrans.AddTransfer(munorbit);
            munorbit.AddTransfer(mun);
            minmustrans.AddTransfer(minmusorbit);
            minmusorbit.AddTransfer(minmus);

            eelootrans.AddTransfer(eelooorbit);
            eelooorbit.AddTransfer(eeloo);

            mohotrans.AddTransfer(mohoorbit);
            mohoorbit.AddTransfer(moho);

            evetrans.AddTransfer(eveorbit);
            eveorbit.AddTransfer(gillytrans).AddTransfer(eve);
            gillytrans.AddTransfer(gillyorbit);
            gillyorbit.AddTransfer(gilly);

            dunatrans.AddTransfer(dunaorbit);
            dunaorbit.AddTransfer(duna).AddTransfer(iketrans);
            iketrans.AddTransfer(ikeorbit);
            ikeorbit.AddTransfer(ike);

            drestrans.AddTransfer(dresorbit);
            dresorbit.AddTransfer(dres);
            return kerbin;
        }
    }
}
