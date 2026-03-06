static bool SetAlarm(bool employed, bool vacation) => employed && !vacation;

Console.WriteLine(SetAlarm(true, false));

Console.WriteLine(SetAlarm(false, false));

Console.WriteLine(SetAlarm(true, true));

Console.WriteLine(SetAlarm(false, true));