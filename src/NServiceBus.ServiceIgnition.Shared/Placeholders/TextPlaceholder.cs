﻿namespace NServiceBus.ServiceIgnition
{
    public static class TextPlaceholder
    {
        public static string MessagePlaceholder = "MessagePlaceholder";
        public static string EndpointNamePlaceholder = "{{endpointName}}";
        public static string BusConfigurationCallsPlaceholder = "{{configurationDetails}}";

        public static string SharedProjectName = "Ignited.NServiceBus.Shared";
        public static string ConsoleProjectName = "Ignited.NServiceBus.Console";

        public static string SerializedMethodsFileName = "_SerializedMethods.cs";
        public static string SerializedClassesFileName = "_SerializedClasses.cs";
    }
}