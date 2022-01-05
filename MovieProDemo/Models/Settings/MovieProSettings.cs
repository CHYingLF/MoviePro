using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProDemo.Models.Settings
{
    public class MovieProSettings
    {
        public string TmDbApiKey { get; set; }
        public string DefaultBackdropSize { get; set; }
        public string DefaultPosterSize { get; set; }
        public string DefaultYouTubeKey { get; set; }
        public string DefaultCastImage { get; set; }
        public DefaultCollections DefaultCollection { get; set; }
        public DefaultCredentials DefaultCredential { get; set; }

        public class DefaultCollections
        { 
            public string Name { get; set; }
            public string Description { get; set; }
        }
        public class DefaultCredentials
        {
            public string Role { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
