using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClicknPaste
{
    internal class DBHelper
    {
        static void DBHelper_Mongo()
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);

            // 데이터베이스 및 컬렉션 선택
            IMongoDatabase database = client.GetDatabase("word");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("testcollection");

            // 데이터 삽입
            var document = new BsonDocument
            {
                { "name", "John" },
                { "age", 30 },
                { "city", "New York" }
            };
            collection.InsertOne(document);

            Console.WriteLine("데이터가 삽입되었습니다.");

        }


    }
}
