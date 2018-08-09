public DateTime? JPApplicationDate { get; set; }
public virtual JPStudent JPStudent { get; set; }

//****************MY CHANGES START HERE        
[NotMapped]
public bool? IsAppliedDateWithinOneWeekOfCurrentDate
{
	get
	{
		return DateCalculateHelper.CalculateIsObjectCreatedWithinOneWeekOfCurrentDate(this.JPApplicationDate);
	}
}
//****************MY CHANGES END HERE   
 <a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/Code/JPApplication.cs">LINK TO COMPLETE FILE</a>