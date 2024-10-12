using System;
using FeInfo.Common.DTOs;

namespace smz3.countdown.wasm.Extenstions;

public static class TournamentRegistrantExtenstions
{
    public static string RegistrationDateLocal(this TournamentRegistrant registrant) => registrant.RegistrationDate.ToLocalTime().ToString("G");

}
