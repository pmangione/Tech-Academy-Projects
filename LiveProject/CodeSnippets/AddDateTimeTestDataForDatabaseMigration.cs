 var hires = new List<JPHire>
            {
            
			//*****REMOVED BY ME
			new JPHire { JPHireId=Guid.NewGuid(),JPStudentId=1, JPCompanyName="Nike",JPJobTitle="Software Engineer",JPJobCategory=JPJobCategory.Development,JPSalary=120000,JPCompanyCity="Portland",JPCompanyState=JPCompanyState.Oregon,JPCareersPage="jobs.nike.com" },
            new JPHire { JPHireId=Guid.NewGuid(),JPStudentId=2, JPCompanyName="New Relic",JPJobTitle="Technical Support Engineer",JPJobCategory=JPJobCategory.Dev_Ops,JPSalary=65000,JPCompanyCity="Portland",JPCompanyState=JPCompanyState.Oregon,JPCareersPage="www.newrelic.com/about/careers" },
            new JPHire { JPHireId=Guid.NewGuid(),JPStudentId=3, JPCompanyName="Google",JPJobTitle="Jr. Database Admin",JPJobCategory=JPJobCategory.Development,JPSalary=75000,JPCompanyCity="Redmond",JPCompanyState=JPCompanyState.Washington,JPCareersPage="careers.google.com" },
            new JPHire { JPHireId=Guid.NewGuid(),JPStudentId=4, JPCompanyName="Walmart",JPJobTitle="QA Engineer",JPJobCategory=JPJobCategory.Development,JPSalary=80000,JPCompanyCity="Vancouver",JPCompanyState=JPCompanyState.Washington,JPCareersPage="careers.walmart.com" },
            new JPHire { JPHireId=Guid.NewGuid(),JPStudentId=5, JPCompanyName="Plaid Electric",JPJobTitle="Software Developer",JPJobCategory=JPJobCategory.Development,JPSalary=90000,JPCompanyCity="Beaverton",JPCompanyState=JPCompanyState.Oregon,JPCareersPage="www.amazon.jobs" }
			//***END OF REMOVED BY ME
			
			
            //****ADDED BY ME
			new JPHire { JPHireId=Guid.NewGuid(),JPStudentId=1, JPCompanyName="Nike",JPJobTitle="Software Engineer",JPJobCategory=JPJobCategory.Development,JPSalary=120000,JPCompanyCity="Portland",JPCompanyState=JPCompanyState.Oregon,JPCareersPage="jobs.nike.com",JPHireDate = Convert.ToDateTime("2018-05-11") },
            new JPHire { JPHireId=Guid.NewGuid(),JPStudentId=2, JPCompanyName="New Relic",JPJobTitle="Technical Support Engineer",JPJobCategory=JPJobCategory.Dev_Ops,JPSalary=65000,JPCompanyCity="Portland",JPCompanyState=JPCompanyState.Oregon,JPCareersPage="www.newrelic.com/about/careers", JPHireDate = Convert.ToDateTime("2018-04-11")},
            new JPHire { JPHireId=Guid.NewGuid(),JPStudentId=3, JPCompanyName="Google",JPJobTitle="Jr. Database Admin",JPJobCategory=JPJobCategory.Development,JPSalary=75000,JPCompanyCity="Redmond",JPCompanyState=JPCompanyState.Washington,JPCareersPage="careers.google.com", JPHireDate = Convert.ToDateTime("2018-02-14") },
            new JPHire { JPHireId=Guid.NewGuid(),JPStudentId=4, JPCompanyName="Walmart",JPJobTitle="QA Engineer",JPJobCategory=JPJobCategory.Development,JPSalary=80000,JPCompanyCity="Vancouver",JPCompanyState=JPCompanyState.Washington,JPCareersPage="careers.walmart.com", JPHireDate = Convert.ToDateTime("2018-02-11") },
            new JPHire { JPHireId=Guid.NewGuid(),JPStudentId=5, JPCompanyName="Plaid Electric",JPJobTitle="Software Developer",JPJobCategory=JPJobCategory.Development,JPSalary=90000,JPCompanyCity="Beaverton",JPCompanyState=JPCompanyState.Oregon,JPCareersPage="www.amazon.jobs", JPHireDate = Convert.ToDateTime("2018-03-15") }
			//***END OF ADDED BY ME
			
            };
            hires.ForEach(s => context.JPHires.AddOrUpdate(p => p.JPHireId, s));