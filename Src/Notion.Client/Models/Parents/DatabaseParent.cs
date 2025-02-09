﻿using Newtonsoft.Json;

namespace Notion.Client
{
    public class DatabaseParent : IPageParent
    {
        /// <summary>
        /// Always "database_id"
        /// </summary>
        public ParentType Type { get; set; }

        /// <summary>
        /// The ID of the database that this page belongs to.
        /// </summary>
        [JsonProperty("database_id")]
        public string DatabaseId { get; set; }
    }
}
