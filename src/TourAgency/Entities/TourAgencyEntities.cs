using System;
using System.Configuration;
using System.Windows;

namespace TourAgency.Entities
{
    public partial class TourAgencyEntities
    {
        private static TourAgencyEntities _context;
        public static TourAgencyEntities GetContext()
        {
            if (_context == null)
            {
                string[] ConnectionStrings =
{
                ConfigurationManager.ConnectionStrings["TourAgencyEntities"].ConnectionString,
                ConfigurationManager.ConnectionStrings["TourAgencyEntities2"].ConnectionString
            };

                foreach (string connectionString in ConnectionStrings)
                {
                    try
                    {

                        var context = new TourAgencyEntities(connectionString);
                        if (context.Database.Exists())
                        {
                            _context = context;
                            break;
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error connection:" + ex.Message); }
                }
                if (_context == null)
                {
                    throw new Exception("Не удалось подключиться ни через одну строку подключения!");
                }
            }
            return _context;
        }
    }
}
