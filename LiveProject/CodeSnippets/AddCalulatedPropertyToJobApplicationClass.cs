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