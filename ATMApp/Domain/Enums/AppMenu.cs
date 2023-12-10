using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Domain.Enums
{
    public enum AppMenu
    {
        CheckBalance = 1, //starts at 0 if we not assigned
        PlaceDeposit,
        MakeWithdrawal,
        InternalTransfer,
        ViewTransaction,
        Logout
    }
}
