using System.Collections.Generic;
using System.Text;
using System.Linq; 

public class HumanTimeFormat
{
    public static string formatDuration(int seconds)
    {
        if (seconds <= 0) return "now";
        var secondsPerUnit = new Dictionary<string, int>() { { "year", 31536000 }, { "day", 86400 }, { "hour", 3600 }, { "minute", 60 }, { "second", 1 } };
        var tot = new Dictionary<string, int>() { { "years", 0 }, { "days", 0 }, { "hours", 0 }, { "minutes", 0 }, { "seconds", 0 } };

        if (seconds > secondsPerUnit["year"])
        {
            tot["years"] = seconds / secondsPerUnit["year"];
            seconds %= secondsPerUnit["year"];
        }

        if (seconds > secondsPerUnit["day"])
        {
            tot["days"] = seconds / secondsPerUnit["day"];
            seconds %= secondsPerUnit["day"];
        }

        if (seconds > secondsPerUnit["hour"])
        {
            tot["hours"] = seconds / secondsPerUnit["hour"];
            seconds %= secondsPerUnit["hour"];
        }

        if (seconds > secondsPerUnit["minute"])
        {
            tot["minutes"] = seconds / secondsPerUnit["minute"];
            seconds %= secondsPerUnit["minute"];
        }

        tot["seconds"] = seconds;

        var notnulls = tot.Where(v => v.Value > 0);

        var sb = new StringBuilder();

        var nnlen = notnulls.Count() - 2;
        var i = 0;

        string final = "";

        foreach (var v in notnulls)
        {
            var unit = v.Value > 1 ? v.Key : v.Key.Substring(0, v.Key.Length - 1);

            var amount = v.Value.ToString();

            if (i > nnlen)
            {
                final = amount + " " + unit;
                break;
            }
          
            sb.Append(amount + " " + unit + ", ");
            i++;
        }

        if (sb.Length != 0) {
            sb.Length -= 2;
            sb.Append(" and ");
        };
        sb.Append(final);

        return sb.ToString();
    }
}

// https://www.codewars.com/kata/52742f58faf5485cae000b9a