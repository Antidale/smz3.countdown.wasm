using System;

namespace smz3.countdown.wasm.Extenstions;

public static class DateTimeExtensions
{
    public static string ToLocalString(this DateTimeOffset dateTimeOffset, string stringFormat = "G") => dateTimeOffset.ToLocalTime().ToString(stringFormat);

    public static string ToLocalString(this DateTime dateTime, string stringFormat = "G") => dateTime.ToLocalTime().ToString(stringFormat);
}
