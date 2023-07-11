using BeautyHall.Models.Db;

namespace BeautyHall.Models.Common.Interfaces
{
    public interface IDBService
    {
        bool UpSert<TObject>(TObject value, string companyId = "");
        bool Delete<TObject>(TObject value);
        IEnumerable<object> Search<TObject>(List<FilterSetting> filters);
    }
}
