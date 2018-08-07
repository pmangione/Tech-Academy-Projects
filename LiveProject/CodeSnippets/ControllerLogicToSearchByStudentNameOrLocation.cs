			
            if (!String.IsNullOrEmpty(searchString))
              {
                //****START OF REMOVED BY ME
				students = students.Where(s => s.JPName.Contains(searchString));
                //**END OF REMOVED BY ME

				//**START OF ADDED BY ME
                string searchStringNoSpaces = Regex.Replace(searchString, @"\s+", "");
                students = students.Where(s => s.JPStudentLocation.ToString().Contains(searchString) || s.JPStudentLocation.ToString().Contains(searchStringNoSpaces) || s.JPName.Contains(searchString));
				//**END OF ADDED BY ME
				
				
            }
           