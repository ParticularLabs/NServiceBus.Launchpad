namespace NServiceBus.ServiceIgnition.Version5
{
    using System;
    using System.Collections.Generic;
    using NServiceBus.Persistence;
    using NServiceBus.Persistence.Legacy;

    public static class PersistenceMethods
    {
        public static Dictionary<Persistence, Action<BusConfiguration>> MethodsDictionary = new Dictionary<Persistence, Action<BusConfiguration>>()
        {
            { Persistence.None, None },
            { Persistence.InMemory, InMemory},
            { Persistence.Msmq, Msmq },
            { Persistence.NHibernate, NHibernate },
            { Persistence.RavenDB, Raven },
        };  

        public static void None(BusConfiguration busConfiguration)
        {
            // no persistence, persistence is optional
        }

        public static void InMemory(BusConfiguration busConfiguration)
        {
            // This is not suitable for production use
            // Please choose a more suitable persistence unless you don't care if you lose subscriptions on restart
            busConfiguration.UsePersistence<InMemoryPersistence>();
        }

        public static void Msmq(BusConfiguration busConfiguration)
        {
            busConfiguration.UsePersistence<MsmqPersistence>();
        }

        public static void NHibernate(BusConfiguration busConfiguration)
        {
            busConfiguration.UsePersistence<NHibernatePersistence>();
        }

        public static void Raven(BusConfiguration busConfiguration)
        {
            busConfiguration.UsePersistence<RavenDBPersistence>();
        }
    }
}