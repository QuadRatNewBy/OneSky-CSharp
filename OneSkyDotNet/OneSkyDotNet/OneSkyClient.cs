﻿namespace OneSkyDotNet
{
    public class OneSkyClient : IOneSkyClient
    {
        private static IPluginAnonymous anonymous = null;

        public static IPluginAnonymous Anonymous
        {
            get
            {
                return anonymous;
            }
        }

        public static IOneSkyClient CreateClient(string publicKey, string secretKey)
        {
            var oneSky = new OneSky(publicKey, secretKey);
            return new OneSkyClient(oneSky);
        }

        public IPlatform Platform { get; private set; }

        public IPlugin Plugin { get; private set; }

        internal OneSkyClient(OneSky oneSky)
        {
            this.Platform = new Platform(oneSky);
        }
    }
}