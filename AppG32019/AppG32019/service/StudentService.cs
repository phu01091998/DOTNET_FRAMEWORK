using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppG32019.model;
using System.IO;
using System.Globalization;

namespace AppG32019.service
{
    class StudentService
    {
        /// <summary>
        /// Lấy thông tin sinh viên dựa vào mã sinh viên
        /// </summary>
        /// <param name="idStudent">mã sinh viên</param>
        /// <returns>Thông tin của sinh viên có mã tương ứng</returns>
        /// nếu sinh viên không tồn tại trả về null;
        public static Student GetStudent(string idStudent)
        {
            var student = new Student {
                Id = idStudent,
                FirstName = "Nguyễn",
                LastName = "Phú",
                DateOfBirth = new DateTime(2002, 2, 22),
                Gender =GENDER.Male,
                PlaceOfBirth ="Thừa Thiên Huế"
            };
            return student;
        }
        /// <summary>
        /// lấy thông tin sv thông  qua file    
        /// </summary>
        /// <param name="pathData">đường dẫn file</param>
        /// <param name="idStudent">mã sv</param>
        /// <returns>return</returns>
        public static Student GetStudent(string pathData, string idStudent)
        {
            if (File.Exists(pathData))
            {
                var lines= File.ReadAllLines(pathData);
                foreach(var line in lines)
                {
                    //cấu trúc của line: msv#họ#tên#ngàysinh#giới tính#nơi sinh
                    var listItem = line.Split(new char[] { '#' });
                    Student student = new Student
                    {
                        Id = listItem[0],
                        FirstName = listItem[1],
                        LastName = listItem[2],
                        //DateOfBirth = new DateTime(2002,2,22),
                        DateOfBirth = DateTime.ParseExact(listItem[3], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Gender = listItem[4] == "male" ? GENDER.Male : (listItem[4] == "female" ? GENDER.Female : GENDER.Other),
                        PlaceOfBirth = listItem[5]


                    };
                    
                    if(student.Id== idStudent)
                    {
                        return student;
                    }
                   
                }
                return null;
            }
            else           
            return null;
        } 
    }
}
