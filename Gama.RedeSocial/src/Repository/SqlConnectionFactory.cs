﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository
{
    public class SqlConnectionFactory
    {
        public static SqlConnection Create()
        {
            return new SqlConnection("");
        }
    }
}
