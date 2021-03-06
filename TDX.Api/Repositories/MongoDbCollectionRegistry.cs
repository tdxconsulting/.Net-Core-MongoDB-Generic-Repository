﻿using System;
using System.Linq;
using System.Collections.Generic;
using TDX.Api.Documents;

namespace TDX.Api.Repositories
{

    public class MongoDbCollectionRegistry
    {
        private List<KeyValuePair<Type, string>> collections;

        public MongoDbCollectionRegistry()
        {
            collections = new List<KeyValuePair<Type, string>>();
            collections.Add(new KeyValuePair<Type, string>(typeof(Note), "Notes"));
            collections.Add(new KeyValuePair<Type, string>(typeof(Widget), "Widgets"));
        }

        public string GetCollectionName(Type t)
        {
            return collections.Where(c => c.Key == t).FirstOrDefault().Value ?? string.Empty;
        }
    }
}
