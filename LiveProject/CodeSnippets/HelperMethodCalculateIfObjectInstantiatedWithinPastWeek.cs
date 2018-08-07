 public static class DateCalculateHelper
    {
        public static bool? CalculateIsObjectCreatedWithinOneWeekOfCurrentDate(DateTime? objectCreatedDate)
        {
            if (objectCreatedDate.HasValue)
            {
                DateTime hiredDate = Convert.ToDateTime(objectCreatedDate);
                var Today = DateTime.Today;
                TimeSpan span = Today.Subtract(hiredDate);
                if (span.Days > 7)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return null;
            }
        }
    }
