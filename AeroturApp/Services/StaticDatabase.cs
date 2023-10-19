//using AeroturApp.Models.DataModels;
//using SQLite;

//namespace AeroturApp.Services
//{
//    public class StaticDatabase
//    {
//        public const string DatabaseFilename = "AeroturAppStaticDatabase.db3";
//        private const SQLiteOpenFlags Flags = 
//            SQLiteOpenFlags.ReadWrite | 
//            SQLiteOpenFlags.Create |
//            SQLiteOpenFlags.SharedCache;

//        public static string DatabasePath = Path.Combine(
//            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
//            DatabaseFilename);

//        SQLiteAsyncConnection Database;
//        //public static readonly AsyncLazy<StaticDatabase> Instance = new AsyncLazy<StaticDatabase>(async () =>
//        //{
//        //   var instance = new StaticDatabase();
//        //    try
//        //    {
//        //        CreateTableResult result = await Database.CreateTableAsync<AirportCard>();
//        //    }
//        //    catch 
//        //    {
//        //        throw;
//        //    }
//        //    return instance;
//        //});

//        public StaticDatabase(){}

//        async Task Init()
//        {
//            if (Database != null) return;

//            Database = new SQLiteAsyncConnection(DatabasePath, Flags);
//        }

//        async Task<List<AirportCard>> GetItemsAsync()
//        {
//            await Init();
//            return await Database.Table<AirportCard>().ToListAsync();
//        }

//        async Task<AirportCard> GetAirport( int id)
//        {
//            await Init();
//            return await Database.Table<AirportCard>().Where(i => i.ID == id).FirstOrDefaultAsync();
//        }
//        async Task<List<AirportCard>> GetAirports(string arg, string value)
//        {
//            await Init();
//            return await Database.Table<AirportCard>().Where().ToListAsync();
//        }

//    }
//}
