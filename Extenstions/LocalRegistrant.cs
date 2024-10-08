using System;
using FeInfo.Common.DTOs;

namespace smz3.countdown.wasm.Extenstions;

public static class TournamentRegistrantExtenstions
{
    public static string RegisterationDateLocal(this TournamentRegistrant registrant)
    {
        return registrant.RegistrationDate.ToLocalTime().ToString("G");
    }

}
