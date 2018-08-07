        public bool JPSecondJob { get; set; }
        [DisplayName("Company Careers Page")]
        public string JPCareersPage { get; set; }
        
		//***MY CHANGES START HERE
		[DisplayName("Hire Date")]
        public DateTime JPHireDate { get; set; }
		//***MY CHANGES END HERE
		
		
        public virtual JPStudent JPStudent { get; set; }