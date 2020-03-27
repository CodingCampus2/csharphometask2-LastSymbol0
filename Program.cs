using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                var enUSCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
                const int halfPadding = Task2.Padding / 2;

                FormattableString balanceMessage = $"{task.Balance:C}";
                string balanceString = balanceMessage.ToString(enUSCulture);

                balanceString = balanceString.PadLeft(halfPadding + balanceString.Length);
                balanceString = balanceString.PadLeft(halfPadding + balanceString.Length, task.DecorativeSign);
                balanceString = balanceString.PadRight(halfPadding + balanceString.Length);
                balanceString = balanceString.PadRight(halfPadding + balanceString.Length, task.DecorativeSign);
                return balanceString;
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
