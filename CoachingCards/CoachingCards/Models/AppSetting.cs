using SQLite;

namespace CoachingCards.Models
{
    //app settings - username, email
    public class AppSetting
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}