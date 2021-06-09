using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    public enum ScientificAchievements
    {
       [Description("Тези для доповіді")]
       Abstracts,

       [Description("Стаття в профільному виданні")]
       ProfessionalPublication,

       [Description("Доповідь на міжнародній конференції")]
       InternationalConference,

       [Description("Стаття у міжнародному науковому журналі")]
       InternationalPublication,
    }

    public static class ScientificAchievementsProcessor
    {
        public static string ToDescriptionSring(this ScientificAchievements val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
            .GetType()
            .GetField(val.ToString())
            .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
