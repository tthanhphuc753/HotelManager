﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Serializable]
    public class connect
    {
        public string servername;

        public string Servername
        {
            get { return servername; }
            set { servername = value; }
        }

        public string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string passwd;

        public string Passwd
        {
            get { return passwd; }
            set { passwd = value; }
        }

        public string database;

        public string Database
        {
            get { return database; }
            set { database = value; }
        }

        public connect(string _servername, string _database)
        {
            this.servername = _servername;
           
            this.database = _database;
        }

        public void SaveFile(string FileName)
        {
            if (File.Exists("connectdb.dba"))
                File.Delete("connectdb.dba");
            FileStream fs = File.Open(FileName, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }
    }
}
