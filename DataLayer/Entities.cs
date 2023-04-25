﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Serializable]
    public partial class Entities
    {
        private Entities(DbConnection connectionString, bool contextOwnsConnection = true)
            : base(connectionString, contextOwnsConnection) { }
        public static Entities CreateEntities(bool contextOwnsConnection = true)
        {
            //Doc file connect
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
            connect cp = (connect)bf.Deserialize(fs);

            //Decrypt noi dung
            string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
            string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = $"Data Source={servername};Initial Catalog={database};Integrated Security=true";
            entityBuilder.Metadata = @"res://*/HOTEL.csdl|res://*/HOTEL.ssdl|res://*/HOTEL.msl";

            EntityConnection connection = new EntityConnection(entityBuilder.ConnectionString);

            fs.Close();
            return new Entities(connection);
        }

    }
}
