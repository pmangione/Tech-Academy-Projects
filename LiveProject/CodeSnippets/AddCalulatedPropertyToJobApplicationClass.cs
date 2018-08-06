public DateTime? JPApplicationDate { get; set; }
public virtual JPStudent JPStudent { get; set; }
        
[NotMapped]
public bool? IsAppliedDateWithinOneWeekOfCurrentDate
{
	get
	{
		return DateCalculateHelper.CalculateIsObjectCreatedWithinOneWeekOfCurrentDate(this.JPApplicationDate);
	}
}
