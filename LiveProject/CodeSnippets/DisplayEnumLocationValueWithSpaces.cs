 @functions {
            public string returnWithSpaces(string location)
                {
                    string newString = System.Text.RegularExpressions.Regex.Replace(location, "[A-Z]", " $0");
                    newString = newString.Trim();
                    return newString;
                }
            }
            @{
            var testString = Model.JPStudentLocation.ToString();
            var newString = returnWithSpaces(testString);
            }
            @Html.DisplayFor(model => newString)