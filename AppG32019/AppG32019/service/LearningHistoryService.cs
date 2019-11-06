using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppG32019.model;

namespace AppG32019.service
{
    public class LearningHistoryService
    {
        public static List<LearningHistory> GetList(string idStudent)
        {
            List<LearningHistory> rs = new List<LearningHistory>();
            for (int i = 1; i <= 12; i++)
            {
                LearningHistory learning = new LearningHistory
                {
                    Id = i.ToString(),
                    YearFrom = 2007 + i,
                    YearEnd = 2008 + i,
                    IdStudent = idStudent
                };
                if (i <= 5)
                    learning.Address = "Tiểu học Phan Bội Châu";
                else if (i <= 9)
                    learning.Address = "Trung học Phan Đăng Lưu";
                else
                    learning.Address = "Phổ Thông Quốc học";
                rs.Add(learning);
            }
            return rs;
        }

    }
}
