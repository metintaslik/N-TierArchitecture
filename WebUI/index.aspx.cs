using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var studentRepository = new StudentRepository();
            foreach (Student student in studentRepository.GetStudents())
            {
                Response.Write($"Student ID: {student.Id}<br>" +
                    $"Student Name: {student.Name}<br>" +
                    $"Student DepartmentID: {student.DepId}");
            }
        }
    }
}