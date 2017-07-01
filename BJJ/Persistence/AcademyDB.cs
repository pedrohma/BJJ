using System;
using System.Collections.Generic;
using BJJ.Models;

namespace BJJ.Persistence
{
    public class AcademyDB
    {
        private List<Academy> listAcademy = new List<Academy>();

        internal string addAcademy(Academy academy)
        {
            string value = "";
			try
			{
				if (academy != null)
				{
					listAcademy.Add(academy);
				}
                value = "Success";
			}
			catch (Exception ex)
			{
				string error = ex.Message;
                value = error;
			}
            return value;
        }
    }
}
