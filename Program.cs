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
                string paddingFillerString = new string(task.DecorativeSign, Task2.Padding / 2);

                FormattableString balanceMessage = $"{paddingFillerString,-Task2.Padding}{task.Balance:C}{paddingFillerString,Task2.Padding}";
                
                return balanceMessage.ToString(enUSCulture);
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
