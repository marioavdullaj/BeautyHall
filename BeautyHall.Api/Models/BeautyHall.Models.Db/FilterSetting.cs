namespace BeautyHall.Models.Db
{
    public class FilterSetting
    {
        public string? Key { get; set; }
        public object? Value { get; set; }
        public ECompareType Comparisation { get; set; } = ECompareType.Equal;
    }
    public enum ECompareType
    {
        Equal = 0,
        NotEqual = 1,
        Contains = 2,
        NotContains = 3,
        GreaterThan = 4,
        GreaterThanOrEqual = 5,
        LessThan = 6,
        LessThanOrEqual = 7,
        In = 8,
        NotIn = 9,
        SameDay = 10
    }
    public enum EMainComparisation
    {
        None = 0,
        And = 1,
        Or = 2
    }
}
